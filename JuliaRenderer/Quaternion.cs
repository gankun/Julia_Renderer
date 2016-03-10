using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace JuliaRenderer
{
    public static class Quaternion
    {
        /** 
         */
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

        public static Vector4 exp_Quat(Vector4 q)
        {
            float a = q.X;
            Vector3 v = new Vector3(q.Y, q.Z, q.W);
                 
            Vector3 cmplx = (v * (float) (Math.Sin((double) v.Length())) / v.Length());

            Vector4 output = new Vector4((float) Math.Cos(((float) v.Length())), cmplx.X, cmplx.Y, cmplx.Z);

            output *= (float) Math.Exp((double)a);

            return output;
        }
        // Computes the product of two quaternions
        public static Vector4 mul_Quat(Vector4 A, Vector4 B)
        {
            Vector4 product = new Vector4();
            Vector3 A_yzw = new Vector3(A.Y, A.Z, A.W);
            Vector3 B_yzw = new Vector3(B.Y, B.Z, B.W);

            product.X = A.X * B.X - Vector3.Dot(A_yzw, B_yzw);
            Vector3 product_yzw = A.X * B_yzw + B.X * A_yzw + Vector3.Cross(A_yzw, B_yzw);

            product.Y = product_yzw.X;
            product.Z = product_yzw.Y;
            product.W = product_yzw.Z;
            return product;
        }

    }
}
