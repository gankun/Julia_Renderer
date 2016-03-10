using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace JuliaRenderer
{


    class Julia_Raytracer
    {
        private static float WALL_X = -1;
        private static float WALL_Y = -1;
        private static float WALL_Z = -1;
        private float Bound = 2;
        private float Epsilon = .001F;
        private int Niter = 3;

        public Julia_Raytracer()
        {
        }

        public Julia_Raytracer(int niter, float epsilon, float bound)
        {
            Bound = bound;
            Niter = niter;
            Epsilon = epsilon;
        }

        public void Generate(Julia_Set Julia, Vector4 JPlane, Vector4 JC)
        {
            Vector3 light = new Vector3(2.5F, -2F, 4F);
            Vector3 target = new Vector3(0F, 0F, 0F);

            var xres = Julia.xres;
            var yres = Julia.yres;

            for (int x = 0; x < Julia.xres; x++)
            {
                for (int y = 0; y < Julia.yres; y++)
                {
                    float nx = ((float)x - xres / 2.0F) / ((float)xres / 2.0F);
                    float ny = ((float)-y + yres / 2.0F) / ((float)yres / 2.0F);

                    Vector3 eye = new Vector3(0, 0, 4);



                    Vector3 Ray = lookAt(eye, target, nx, ny, 2.0F);

                    Vector3 Background = new Vector3(120F + (120 * nx), 200F, 140F + (100 * ny));

                    // Normalize the colors
                    Background /= 255;

                    // Use raytracing for each pixel
                    int exponent = 2;
                    var Color = Raytrace(eye, Ray, light, eye, Background, JPlane, JC, exponent);
                    //var Color = Background;

                    // Assign each color to the matrix
                    Julia.Red[y * xres + x] = (int)(Color.X * 255);
                    Julia.Green[y * xres + x] = (int)(Color.Y * 255);
                    Julia.Blue[y * xres + x] = (int)(Color.Z * 255);
                }
            }
        }

        public Vector3 Raytrace(
            Vector3 r0, Vector3 rd, Vector3 light,
            Vector3 eye, Vector3 backColor, Vector4 julia_Plane, 
            Vector4 julia_C, int exponent)
        {
            // Initialize color to the background color.
            Vector3 color = backColor;

            rd.Normalize();

            r0 = intersectBound(r0, rd);    

            // Compute the point of the floor plane to calculate shadows for not
            // intersecting the Julia Set

            // Check if we intersect the bounding sphere.
            if (r0.Length() > .001)
            {
                
                // Check that we are within epsilon to a point on the set.
                float distance = d_JuliaDist2(r0, rd, julia_C, julia_Plane, exponent);

                if (distance < Epsilon)
                {
                    // Determine the normal at the Julia Point to calculate shading
                    Vector3 normal = EstimateNormalQJulia(r0, julia_C, julia_Plane,
                                 rd, exponent);

                    // Use Phong Shading model to determine color
                    
                    Vector3 rgb = Phong(light, eye, r0, normal);


                    // Pass the color to determine shadows
                    rgb = Shadow(r0, light, rgb, normal, julia_C, julia_Plane, exponent);
                  
                    return rgb;
                }
            }

            // Did not hit the julia set, compute image of the background.
            Vector3 n = Vector3.Normalize(new Vector3(-WALL_X, -WALL_Y, -WALL_Z));
            Vector3 g = Ground(eye, rd);
            //color = Phong(light, eye, g, n);
            color = Shadow(g, light, color, n, julia_C, julia_Plane, exponent);
            return color;            
        }

        // This function finds the intersection point of our ray with
        // our bounding sphere.
        private Vector3 intersectBound(Vector3 p, Vector3 ray)
        {    
            var B = 2 * Vector3.Dot(p, ray);
            var C = Vector3.Dot(p, p) - Bound;
    
    
            if (B * B - 4 * C < 0)
                return new Vector3(0,0,0);
            var d = (float) Math.Sqrt(B * B - 4 * C);
            var t0 = (-B + d) * .5F;
            var t1 = (-B - d) * .5F;
            return p + (Math.Min(t0, t1) * ray);   
        }

        // Device function to compute distance function, (using points and rays)
        // Use the exponent variable to determine which rule to use for the set
        private float d_JuliaDist2(Vector3 pos, Vector3 ray, Vector4 D_JuliaC,
            Vector4 D_JuliaPlane, int exponent)
        {
            float dist; // distance from the position to either a nearby point in 
                        // set or the last point tested if failed
            ray.Normalize();
            while(true)
            {
                Vector4 z = new Vector4(pos.X, pos.Y, pos.Z, 0);
                z = pos_to_quat(pos, D_JuliaPlane);

                Vector4 zp = new Vector4(1.0F, .02F, .01F, -.05F);
               
                // iterate point to see if it escapes our bounds
                for (int i = 0; i < Niter; i++)
                {   
                    if (exponent > 1){
                        zp = exponent * (Quaternion.mul_Quat(Quaternion.power_Quat(z, exponent - 1), zp));
                        z = Quaternion.power_Quat(z, exponent) + D_JuliaC;
                    }
                    /*
                    if (exponent == -1){
                        //Rule for exponential functions
                        zp = Quaternion.exp_Quat(z) * zp;
                        z = Quaternion.exp_Quat(z) + D_JuliaC;
                    }
                    */
                    if (Vector4.Dot(z, z) > 10)
                    {
                        break;
                    }   
                }
                
                 dist = z.Length() / (2 * zp.Length()) * (float) Math.Log((double) z.Length());
                 pos += ray * dist;
                 
                 //TEST FOR NEGATIVE DISTANCES
                 if (dist < 0)
                    dist *= -1;
                 // Check if the point intersects the surface withing EPSILON
                 // or if the ray has left the bounding sphere
                 float dot_product = Vector3.Dot(pos, pos);
                 
                 if (dist < Epsilon || dot_product > Bound)
                        break;
        
            }
            // return the distance for this ray to the set
            return dist;
    
        }

        private Vector3 EstimateNormalQJulia(Vector3 p, Vector4 c, Vector4 d, 
            Vector3 ray, int exponent)
        {
            float DELTA = .001F;

            Vector3 px1 = new Vector3(p.X - DELTA, p.Y, p.Z);
            Vector3 px2 = new Vector3(p.X + DELTA, p.Y, p.Z);
            float dx1 = d_JuliaDist2(px1, ray, c, d, exponent);
            float dx2 = d_JuliaDist2(px2, ray, c, d, exponent);
            Vector3 py1 = new Vector3(p.X, p.Y - DELTA, p.Z);
            Vector3 py2 = new Vector3(p.X, p.Y + DELTA, p.Z);
            float dy1 = d_JuliaDist2(py1, ray, c, d, exponent);
            float dy2 = d_JuliaDist2(py2, ray, c, d, exponent);
            Vector3 pz1 = new Vector3(p.X, p.Y, p.Z - DELTA);
            Vector3 pz2 = new Vector3(p.X, p.Y, p.Z + DELTA);
            float dz1 = d_JuliaDist2(pz1, ray, c, d, exponent);
            float dz2 = d_JuliaDist2(pz2, ray, c, d, exponent);

            float nx = dx2 - dx1;
            float ny = dy2 - dy1;
            float nz = dz2 - dz1;
     
            Vector3 normal = new Vector3(nx, ny, nz);
            normal.Normalize();

            return normal;
        }

        // Compute the color for a point due to a point light
        // and a spotlight at the eye.
        private Vector3 Phong(Vector3 light, Vector3 eye, Vector3 p, Vector3 N)
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
    
            Vector3 LV = light - p; // vector to the light source
            LV.Normalize();
            Vector3 EV = (eye - p);   // vector to the eye
            EV.Normalize();
            float coA = Vector3.Dot(N, LV); // cos angle between light and normal vectors
            Vector3 refl = (LV - (2.0F * coA * N)); // the reflected Vector

            dif += new Vector3(Math.Abs(N.X), Math.Abs(N.Y), Math.Abs(N.Z)) * .250F; // Add some normal to the color
            
            float addend = amp * (float)Math.Pow(Math.Max(Vector3.Dot(EV, refl), 0.0F), shine);

            return dif * Math.Max(coA, 0.0F) + new Vector3(addend, addend, addend);
    
        }

        private Vector3 Shadow(Vector3 p, Vector3 light, Vector3 color, Vector3 N, Vector4 Jc,
            Vector4 Jplane, int exponent)
        {
            // Get the shadow ray from the intersect point towards the light
            Vector3 shade = (light - p);
            shade.Normalize();

            // Move point along the normal to avoid hitting the same surface
            p += 2 * N * Epsilon;
            float dist = d_JuliaDist2(p, light, Jc, Jplane, exponent);

            // If we hit another surface apply shading to color
            if (dist < Epsilon)
                color = color * (0.4F);

            return color;
        }


        // This function will determine if a ray originating from a point will
        // intersect the "ground." This is defined on the top of the file.
        // Shadows will be drawn to this plane.
        private static Vector3 Ground(Vector3 p, Vector3 ray)
        {
            // get the normal for the plane
            Vector3 P0 = new Vector3(WALL_X, WALL_Y, WALL_Z); // point on the plane

            // make the normal point towards the origin
            Vector3 n = (new Vector3(-WALL_X, -WALL_Y, -WALL_Z));
            n.Normalize();
    
            // L0 is a point on the lineq
            Vector3 L0 = p;
            // L is the direction of the line
            Vector3 L = ray;
    
            // Using plane equation and line equation we get
            // dot((d * L + L0 -P0), n) = 0
            // Solve for d to find intersect

            float d = Vector3.Dot(P0 - L0, n) / Vector3.Dot(L, n);
            Vector3 intersect = d * L + L0;
    
            return intersect;
        }

        // function that determines the ray to use based on the pixel.
        // based on which nx, ny pixel we calculate a ray that will looks
        // towards the target with a zoom x zoom screen
        public static Vector3 lookAt(Vector3 eye, Vector3 target, float nx, float ny, float zoom)
        {
            // align ray towards the target
            
            float X = (target.Z + (nx * zoom) - eye.X);
            float Y = (target.Y + (ny * zoom) - eye.Y);
            float Z = (target.Z - eye.Z);
            return new Vector3(X, Y, Z);
        }

        private static Vector4 pos_to_quat(Vector3 pos, Vector4 plane)
        {
            return new Vector4(pos.X, pos.Y, pos.Z,
                       plane.X * pos.X + plane.Y * pos.Y + plane.Z * pos.Z + plane.W);
        }
    }
}
