using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cudafy;
using Cudafy.Host;
using Cudafy.Translator;

namespace JuliaRenderer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void renderButton_Click(object sender, EventArgs e)
        {

            

            CudafyModule km = CudafyTranslator.Cudafy();
            var GPU = CudafyHost.GetDevice(CudafyModes.Target, CudafyModes.DeviceId);
            GPU.LoadModule(km);

            Julia_Set Julia = new Julia_Set(500, 500);
            Julia_Raytracer Tracer = new Julia_Raytracer(GPU, 3, .001F, 1.99F);
            
            Tracer.Generate_GPU(Julia, 
                new int[] {0, 0, 0, 0},
                new int[] {0, 0, 0, 0});

            string target = @"C:\Users\Matthew\Project\WriteLines2.ppm";
            Julia.Print_PPM(target);

            var bit = Julia.MakeBitmap();
            pictureBox1.Image = bit;
            pictureBox1.Invalidate();  

        }
        [Cudafy]
        public static void DummyDrawKernel(GThread thread, int startID, int runs, int[] R, int[] G, int[] B,
            int xres, int yres, int[] JPlane_I, int[] JC_I,
            int niter, float bound, float epsilon)
        {
            int tid = thread.threadIdx.x + startID;
            while (tid < xres * yres) // && (tid < startID + runs))
            {
                if (tid > startID + runs)
                {
                    break;
                }

                int x = tid % xres;
                int y = tid / xres;

                float nx = ((float)x - xres / 2.0F) / ((float)xres / 2.0F);
                float ny = ((float)-y + yres / 2.0F) / ((float)yres / 2.0F);

                Vector3 Color = new Vector3(
                   .5F + (.5F * nx),
                   .5F + (.5F * nx), 
                   .5F + (.5F * ny));

                var eye = new Vector3(0, 0, 4);
                var target = new Vector3(0, 0, 0);
                if (Length3(intersectBound(eye, lookAt(eye, target, nx, ny, 2.0F), 1.99F)) > .001F)
                {
                   Color = new Vector3(0, .1F, 0);
                }
                /*
                if (GMath.Abs(nx) < .1)
                {
                    if (GMath.Abs(ny) < .1)
                    {
                        Color = new Vector3(0, .1F, 0);
                    }
                }
                */
                // Assign each color to the matrix
                R[y * xres + x] = (int)(Color.X * 255);
                G[y * xres + x] = (int)(Color.Y * 255);
                B[y * xres + x] = (int)(Color.Z * 255);

                tid += thread.blockDim.x;
            }

        }

        [Cudafy]
        public static void cudaDrawKernel(GThread thread, int startID, int runs, int[] R, int[] G, int[] B,
            int xres, int yres, int[] JPlane_I, int[] JC_I,
            int niter, float bound, float epsilon)
        {
            var JPlane = new Vector4(JPlane_I[0], JPlane_I[1], JPlane_I[2], JPlane_I[3]);
            var JC = new Vector4(JC_I[0], JC_I[1], JC_I[2], JC_I[3]);

            int tid = thread.threadIdx.x + startID;
            Vector3 light = new Vector3(2.5F, -2F, 4F);
            Vector3 target = new Vector3(0F, 0F, 0F);

            while (tid < xres * yres)
            {
                if (tid > startID + runs)
                {
                    break;
                }

                int x = tid % xres;
                int y = tid / xres;

                float nx = ((float)x - xres / 2.0F) / ((float)xres / 2.0F);
                float ny = ((float)-y + yres / 2.0F) / ((float)yres / 2.0F);

                // Create position for eye and direction eye is facing.
                Vector3 eye = new Vector3(0, 0, 4);
                Vector3 Ray = lookAt(eye, target, nx, ny, 2.0F);

                var Background = new Vector3(
                    .3F + (.2F * nx),
                   .1F, 
                   .5F + (.3F * ny));
                var Color = Background;
                // Use raytracing for each pixel
                int exponent = 2;
                Color = Raytrace(eye, Ray, light, eye, Background,
                   JPlane, JC, exponent, niter, bound, epsilon);
   
                R[y * xres + x] = (int)(Color.X * 255);
                G[y * xres + x] = (int)(Color.Y * 255);
                B[y * xres + x] = (int)(Color.Z * 255);

                tid += thread.blockDim.x;
            }
        }

        [Cudafy]
        public static Vector3 Raytrace(
            Vector3 r0, Vector3 rd, Vector3 light,
            Vector3 eye, Vector3 backColor, Vector4 julia_Plane,
            Vector4 julia_C, int exponent, int niter, float bound,
            float epsilon)
        {
            float WALL_X = 0;
            float WALL_Y = 0;
            float WALL_Z = -1;

            // Initialize color to the background color.
            Vector3 color = backColor;
            
            rd = Normalize3(rd);

            r0 = intersectBound(r0, rd, bound);

            // Compute the point of the floor plane to calculate shadows for not
            // intersecting the Julia Set
           
            // Check if we intersect the bounding sphere.
            if (Length3(r0) > 0)
            {
                
                // Check that we are within epsilon to a point on the set.
                float distance = Julia_Distance(r0, rd, julia_C, julia_Plane,
                    exponent, niter, bound, epsilon);

                if (distance < epsilon)
                {
                    // Determine the normal at the Julia Point to calculate shading
                    Vector3 normal = EstimateNormalQJulia(r0, julia_C, julia_Plane,
                                 rd, exponent, niter, bound, epsilon);

                    // Use Phong Shading model to determine color

                    Vector3 rgb = Phong(light, eye, r0, normal);


                    // Pass the color to determine shadows
                    rgb = Shadow(r0, light, rgb, normal, julia_C, julia_Plane,
                        exponent, niter, bound, epsilon);

                    return rgb;
                }
            }

            

            // Did not hit the julia set, compute image of the background.
            Vector3 n = Normalize3(new Vector3(-WALL_X, -WALL_Y, -WALL_Z));
            Vector3 g = Ground(eye, rd, WALL_X, WALL_Y, WALL_Z);
            //color = Phong(light, eye, g, n);
            color = Shadow(g, light, color, n, julia_C, julia_Plane,
                exponent, niter, bound, epsilon);
            return color;
        }

        // This function finds the intersection point of our ray with
        // our bounding sphere.
        [Cudafy]
        private static Vector3 intersectBound(Vector3 p, Vector3 ray, float bound_radius)
        {

            var B = Dot3(p, ray) * 2;
            var C = Dot3(p, p) - bound_radius;

            if (B * B - 4 * C < 0)
                return new Vector3(0, 0, 0);

            var d = Cudafy.GMath.Sqrt(B * B - 4 * C);

            var t0 = (-B + d) * .5F;
            var t1 = (-B - d) * .5F;

            var distance = Scale3(ray, GMath.Min(t0, t1));

            return Add3(p, distance);
        }

        // Device function to compute distance function, (using points and rays)
        // Use the exponent variable to determine which rule to use for the set
        [Cudafy]
        private static float Julia_Distance(Vector3 pos, Vector3 ray, Vector4 D_JuliaC,
            Vector4 D_JuliaPlane, int exponent, int niter, float bound, float epsilon)
        {
            float dist; // distance from the position to either a nearby point in 
            // set or the last point tested if failed
            ray = Normalize3(ray);
            while (true)
            {
                Vector4 z = new Vector4(pos.X, pos.Y, pos.Z, 0);
                z = pos_to_quat(pos, D_JuliaPlane);

                Vector4 zp = new Vector4(1.0F, .02F, .01F, -.05F);

                // iterate point to see if it escapes our bounds
                for (int i = 0; i < niter; i++)
                {
                    if (exponent > 1)
                    {
                        zp = Scale4(mul_Quat(power_Quat(z, exponent - 1), zp), exponent);
                        z = Add4(power_Quat(z, exponent), D_JuliaC);
                    }

                    if (Dot4(z, z) > 10)
                    {
                        break;
                    }
                }

                dist = Length4(z) / (2 * Length4(zp)) * (float)GMath.Log(Length4(z));
                pos = Add3(pos, (Scale3(ray, dist)));

                //TEST FOR NEGATIVE DISTANCES
                if (dist < 0)
                    dist *= -1;
                // Check if the point intersects the surface withing EPSILON
                // or if the ray has left the bounding sphere
                float dot_product = Dot3(pos, pos);

                if (dist < epsilon || dot_product > bound)
                    break;

            }
            // return the distance for this ray to the set
            return dist;

        }

        [Cudafy]
        private static Vector3 EstimateNormalQJulia(Vector3 p, Vector4 c, Vector4 d,
            Vector3 ray, int exponent, int niter, float bound, float epsilon)
        {
            float DELTA = .001F;

            Vector3 px1 = new Vector3(p.X - DELTA, p.Y, p.Z);
            Vector3 px2 = new Vector3(p.X + DELTA, p.Y, p.Z);
            float dx1 = Julia_Distance(px1, ray, c, d, exponent, niter, bound, epsilon);
            float dx2 = Julia_Distance(px2, ray, c, d, exponent, niter, bound, epsilon);
            Vector3 py1 = new Vector3(p.X, p.Y - DELTA, p.Z);
            Vector3 py2 = new Vector3(p.X, p.Y + DELTA, p.Z);
            float dy1 = Julia_Distance(py1, ray, c, d, exponent, niter, bound, epsilon);
            float dy2 = Julia_Distance(py2, ray, c, d, exponent, niter, bound, epsilon);
            Vector3 pz1 = new Vector3(p.X, p.Y, p.Z - DELTA);
            Vector3 pz2 = new Vector3(p.X, p.Y, p.Z + DELTA);
            float dz1 = Julia_Distance(pz1, ray, c, d, exponent, niter, bound, epsilon);
            float dz2 = Julia_Distance(pz2, ray, c, d, exponent, niter, bound, epsilon);

            float nx = dx2 - dx1;
            float ny = dy2 - dy1;
            float nz = dz2 - dz1;

            Vector3 normal = Normalize3(new Vector3(nx, ny, nz));

            return normal;
        }

        // Compute the color for a point due to a point light
        // and a spotlight at the eye.
        [Cudafy]
        private static Vector3 Phong(Vector3 light, Vector3 eye, Vector3 p, Vector3 N)
        {

            // set the base color of the set
            Vector3 dif = new Vector3(.10F, .50F, .85F);
            dif = new Vector3(.9F, .9F, .9F);
            dif = new Vector3(.8F, 1F, .04F);
            dif = new Vector3(.01F, .7F, .95F); // blue color
            dif = new Vector3(.50F, .80F, .45F);
            // shininess and the amplitude of highlight
            const int shine = 6;
            const float amp = .45F;

            Vector3 LV = Normalize3(Sub3(light, p)); // vector to the light source
            Vector3 EV = Normalize3(Sub3(eye, p));   // vector to the eye

            float coA = Dot3(N, LV); // cos angle between light and normal vectors
            Vector3 refl = Sub3(LV, Scale3(N, 2.0F * coA)); // the reflected Vector

            // Add some normal to the color
            dif = Add3(dif,
                Scale3(
                    new Vector3(GMath.Abs(N.X), GMath.Abs(N.Y), GMath.Abs(N.Z)),
                    .250F));

            float addend = amp * GMath.Pow(GMath.Max(Dot3(EV, refl), 0.0F), shine);

            return Add3(Scale3(dif, GMath.Max(coA, 0)),
                new Vector3(addend, addend, addend));

        }
        [Cudafy]
        private static Vector3 Shadow(Vector3 p, Vector3 light, Vector3 color, Vector3 N, Vector4 Jc,
            Vector4 Jplane, int exponent, int niter, float bound, float epsilon)
        {
            // Get the shadow ray from the intersect point towards the light
            Vector3 shade = Normalize3(Sub3(light, p));

            // Move point along the normal to avoid hitting the same surface
            p = Add3(p, Scale3(N, 2 * epsilon));
            float dist = Julia_Distance(p, light, Jc, Jplane, exponent, niter, bound, epsilon);

            // If we hit another surface apply shading to color
            if (dist < epsilon)
                color = Scale3(color, (0.4F));

            return color;
        }

        // This function will determine if a ray originating from a point will
        // intersect the "ground." This is defined on the top of the file.
        // Shadows will be drawn to this plane.
        [Cudafy]
        private static Vector3 Ground(Vector3 p, Vector3 ray, float WALL_X, float WALL_Y, float WALL_Z)
        {
            // get the normal for the plane
            Vector3 P0 = new Vector3(WALL_X, WALL_Y, WALL_Z); // point on the plane

            // make the normal point towards the origin
            Vector3 n = Normalize3((new Vector3(-WALL_X, -WALL_Y, -WALL_Z)));

            // L0 is a point on the lineq
            Vector3 L0 = p;
            // L is the direction of the line
            Vector3 L = ray;

            // Using plane equation and line equation we get
            // dot((d * L + L0 -P0), n) = 0
            // Solve for d to find intersect

            float d = Dot3(Sub3(P0, L0), n) / Dot3(L, n);
            Vector3 intersect = Add3(Scale3(L, d), L0);
            return intersect;
        }

        // function that determines the ray to use based on the pixel.
        // based on which nx, ny pixel we calculate a ray that will look
        // towards the target with a zoom x zoom screen
        [Cudafy]
        public static Vector3 lookAt(Vector3 eye, Vector3 target, float nx, float ny, float zoom)
        {
            // align ray towards the target

            float X = (target.X + (nx * zoom) - eye.X);
            float Y = (target.Y + (ny * zoom) - eye.Y);
            float Z = (target.Z - eye.Z);
            return Normalize3(new Vector3(X, Y, Z));
        }

        [Cudafy]
        public struct Vector4
        {
            public float X;
            public float Y;
            public float Z;
            public float W;

            public Vector4(float x, float y, float z, float w)
            {
                X = x;
                Y = y;
                Z = z;
                W = w;
            }
        }

        [Cudafy]
        public struct Vector3
        {
            public float X;
            public float Y;
            public float Z;

            public Vector3(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        [Cudafy]
        public static Vector4 Scale4(Vector4 A, float p)
        {
            return new Vector4(A.X * p, A.Y * p, A.Z * p, A.W * p);
        }

        [Cudafy]
        public static Vector3 Scale3(Vector3 A, float p)
        {
            return new Vector3(A.X * p, A.Y * p, A.Z * p);
        }

        [Cudafy]
        public static Vector3 Divide3(Vector3 A, float p)
        {
            return new Vector3(A.X / p, A.Y / p, A.Z / p);
        }

        [Cudafy]
        public static Vector4 Divide4(Vector4 A, float p)
        {
            return new Vector4(A.X / p, A.Y / p, A.Z / p, A.W / p);
        }

        [Cudafy]
        public static Vector4 Add4(Vector4 A, Vector4 B)
        {
            return new Vector4(A.X + B.X, A.Y + B.Y, A.Z + B.Z, A.W + B.W);
        }

        [Cudafy]
        public static Vector3 Add3(Vector3 A, Vector3 B)
        {
            return new Vector3(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        [Cudafy]
        public static Vector4 Sub4(Vector4 A, Vector4 B)
        {
            return new Vector4(A.X - B.X, A.Y - B.Y, A.Z - B.Z, A.W - B.W);
        }

        [Cudafy]
        public static Vector3 Sub3(Vector3 A, Vector3 B)
        {
            return new Vector3(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        [Cudafy]
        public static float Dot3(Vector3 A, Vector3 B)
        {
            return A.X * B.X + A.Y * B.Y + A.Z * B.Z;
        }

        [Cudafy]
        public static float Dot4(Vector4 A, Vector4 B)
        {
            return A.X * B.X + A.Y * B.Y + A.Z * B.Z + A.W * B.W;
        }

        [Cudafy]
        public static Vector3 Cross(Vector3 A, Vector3 B)
        {
            return new Vector3(
                A.Y * B.Z - A.Z * B.Y,
                A.Z * B.X - A.X * B.Z,
                A.X * B.Y - A.Y * B.X);
        }

        [Cudafy]
        public static float Length3(Vector3 A)
        {
            return Cudafy.GMath.Sqrt(A.X * A.X + A.Y * A.Y + A.Z * A.Z);
        }

        [Cudafy]
        public static float Length4(Vector4 A)
        {
            return Cudafy.GMath.Sqrt(A.X * A.X + A.Y * A.Y + A.Z * A.Z + A.W * A.W);
        }

        [Cudafy]
        public static Vector3 Normalize3(Vector3 A)
        {
            var length = Length3(A);
            return new Vector3(A.X / length, A.Y / length, A.Z / length);
        }

        [Cudafy]
        public static Vector4 Normalize4(Vector4 A)
        {
            var length = Length4(A);
            return new Vector4(A.X / length, A.Y / length, A.Z / length, A.W / length);
        }

        [Cudafy]
        public static Vector4 power_Quat(Vector4 q, int p)
        {
            if (p < 1) // ERROR CASE
                return new Vector4(0, 0, 0, 0);

            if (p == 1)
            {
                return q;
            }
            else
                return mul_Quat(q, power_Quat(q, p - 1));
        }

        // Computes the product of two quaternions
        [Cudafy]
        public static Vector4 mul_Quat(Vector4 A, Vector4 B)
        {
            Vector4 product = new Vector4();
            Vector3 A_yzw = new Vector3(A.Y, A.Z, A.W);
            Vector3 B_yzw = new Vector3(B.Y, B.Z, B.W);

            product.X = A.X * B.X - Dot3(A_yzw, B_yzw);
            Vector3 product_yzw = Add3(Add3(Scale3(B_yzw, A.X), Scale3(A_yzw, B.X)), Cross(A_yzw, B_yzw));

            product.Y = product_yzw.X;
            product.Z = product_yzw.Y;
            product.W = product_yzw.Z;
            return product;
        }

        // Convert from position to quaternion
        [Cudafy]
        public static Vector4 pos_to_quat(Vector3 pos, Vector4 plane)
        {
            return new Vector4(pos.X, pos.Y, pos.Z,
                       plane.X * pos.X + plane.Y * pos.Y + plane.Z * pos.Z + plane.W);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
