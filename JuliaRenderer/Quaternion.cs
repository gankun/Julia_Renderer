using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cudafy;
using Cudafy.Host;
using Cudafy.Translator;

namespace JuliaRenderer
{
    public static class Quaternion
    {
        /*

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
        public static Vector4 Scale(Vector4 A, float p)
        {
            return new Vector4(A.X * p, A.Y * p, A.Z * p, A.W * p);
        }

        [Cudafy]
        public static Vector3 Scale(Vector3 A, float p)
        {
            return new Vector3(A.X * p, A.Y * p, A.Z * p);
        }

        [Cudafy]
        public static Vector3 Divide(Vector3 A, float p)
        {
            return new Vector3(A.X / p, A.Y / p, A.Z / p);
        }

        [Cudafy]
        public static Vector4 Divide(Vector4 A, float p)
        {
            return new Vector4(A.X / p, A.Y / p, A.Z / p, A.W / p);
        }

        [Cudafy]
        public static Vector4 Add(Vector4 A, Vector4 B)
        {
            return new Vector4(A.X + B.X, A.Y + B.Y, A.Z + B.Z, A.W + B.W);
        }

        [Cudafy]
        public static Vector3 Add(Vector3 A, Vector3 B)
        {
            return new Vector3(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        [Cudafy]
        public static Vector4 Sub(Vector4 A, Vector4 B)
        {
            return new Vector4(A.X - B.X, A.Y - B.Y, A.Z - B.Z, A.W - B.W);
        }

        [Cudafy]
        public static Vector3 Sub(Vector3 A, Vector3 B)
        {
            return new Vector3(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        [Cudafy]
        public static float Dot(Vector3 A, Vector3 B)
        {
            return A.X * B.X + A.Y * B.Y + A.Z * B.Z;
        }

        [Cudafy]
        public static float Dot(Vector4 A, Vector4 B)
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
        public static float Length(Vector3 A)
        {
            return Cudafy.GMath.Sqrt(A.X * A.X + A.Y * A.Y + A.Z * A.Z);
        }

        [Cudafy]
        public static float Length(Vector4 A)
        {
            return Cudafy.GMath.Sqrt(A.X * A.X + A.Y * A.Y + A.Z * A.Z + A.W * A.W);
        }

        [Cudafy]
        public static Vector3 Normalize(Vector3 A)
        {
            var length = Length(A);
            return new Vector3(A.X / length, A.Y / length, A.Z / length);
        }

        [Cudafy]
        public static Vector4 Normalize(Vector4 A)
        {
            var length = Length(A);
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

            product.X = A.X * B.X - Dot(A_yzw, B_yzw);
            Vector3 product_yzw = Add(Add(Scale(B_yzw, A.X), Scale(A_yzw, B.X)), Cross(A_yzw, B_yzw));

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
        */
    }
}
