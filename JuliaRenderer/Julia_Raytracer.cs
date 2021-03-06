﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cudafy;
using Cudafy.Host;
using Cudafy.Translator;

namespace JuliaRenderer
{
    class Julia_Raytracer
    {
        private Cudafy.Host.GPGPU GPU;
        private float Bound;

        public float Epsilon;
        public float Delta;
        public float Amplitude;
        public int Shine;
        public int Niter;
        public float[] Eye;
        public float[] Light;
        
        public Julia_Raytracer(Cudafy.Host.GPGPU gpu, float bound)
        {
            //setup2();
            GPU = gpu;
            Bound = bound;
            Niter = 1;
            Epsilon = .01F;
            Delta = .01F;
            Shine = 6;
            Amplitude = .45F;

            Eye = new float[3] {0, 0, 5};
            Light = new float[3] {3, 3, 4};
        }
       
        public void Generate_GPU(Julia_Set Julia, float[] JPlane, float[] JC)
        {
            var xres = Julia.xres;
            var yres = Julia.yres;
             
            // Prepare arrays on the GPU
            int[] dev_R = GPU.Allocate<int>(Julia.Red);
            int[] dev_G = GPU.Allocate<int>(Julia.Green);
            int[] dev_B = GPU.Allocate<int>(Julia.Blue);
            float[] dev_JPlane = GPU.Allocate<float>(4);
            float[] dev_JC = GPU.Allocate<float>(4);
            float[] dev_Eye = GPU.Allocate<float>(3);
            float[] dev_Light = GPU.Allocate<float>(3);

            // Copy arrays from Julia_Set to GPU
            GPU.CopyToDevice(Julia.Red, dev_R);
            GPU.CopyToDevice(Julia.Green, dev_G);
            GPU.CopyToDevice(Julia.Blue, dev_B);
            GPU.CopyToDevice(JPlane, dev_JPlane);
            GPU.CopyToDevice(JC, dev_JC);
            GPU.CopyToDevice(Eye, dev_Eye);
            GPU.CopyToDevice(Light, dev_Light);

            // Launch drawKernel on 128 threads and 128 blocks
            int i = 0;
            int parallel = 512;
            
            while (i < Julia.xres * Julia.yres)
            {             
                GPU.Launch(1, 128)
                    .cudaDrawKernel(i, parallel, dev_R, dev_G, dev_B, 
                    Julia.xres, Julia.yres, dev_JPlane, dev_JC, dev_Eye, 
                    dev_Light, Niter, Bound, Epsilon, Delta, Amplitude, Shine);

                i += parallel;
            }

            // Copy back color array from the GPU to the CPU
            GPU.CopyFromDevice(dev_R, Julia.Red);
            GPU.CopyFromDevice(dev_G, Julia.Green);
            GPU.CopyFromDevice(dev_B, Julia.Blue);

            // Free the memory allocated on the GPU
            GPU.Free(dev_R);
            GPU.Free(dev_G);
            GPU.Free(dev_B);
            GPU.Free(dev_JPlane);
            GPU.Free(dev_JC);
            GPU.Free(dev_Eye);
            GPU.Free(dev_Light);
        }

        /* 
         * Use Raytracing to color all points of the screen for a given Julia Set and
         * a constant & Plane value. This approach uses the CPU to compute each pixel.
         * There is no parallelization used.
         */ 
        public void Generate_CPU(Julia_Set Julia, float[] JPlane_I, float[] JC_I)
        {
            var JPlane = new Form1.Vector4(JPlane_I[0], JPlane_I[1], JPlane_I[2], JPlane_I[3]);
            var JC = new Form1.Vector4(JC_I[0], JC_I[1], JC_I[2], JC_I[3]);
            var eye = new Form1.Vector3(Eye[0], Eye[1], Eye[2]);
            
            Form1.Vector3 light = new Form1.Vector3(2.5F, -2F, 4F);
            Form1.Vector3 target = new Form1.Vector3(0F, 0F, 0F);


            int xres = Julia.xres;
            int yres = Julia.yres;
            for (int x = 0; x < Julia.xres; x++)
            {
                for (int y = 0; y < Julia.yres; y++)
                {                    
                    float nx = ((float)x - xres / 2.0F) / ((float)xres / 2.0F);
                    float ny = ((float)-y + yres / 2.0F) / ((float)yres / 2.0F);

                    // Create position for eye and direction eye is facing.
                    
                    Form1.Vector3 Ray = Form1.lookAt(eye, target, nx, ny, 2.0F);

                    Form1.Vector3 Background = new Form1.Vector3(120F + (120 * nx),
                        200F, 140F + (100 * ny));

                    Background = new Form1.Vector3(.3F + (.2F * nx),
                        .1F, .5F + (.3F * ny));

                    // Use raytracing for each pixel
                    int exponent = 2;
                    var Color = Form1.Raytrace(eye, Ray, light, eye, Background,
                        JPlane, JC, exponent, Niter, Bound, Epsilon, Delta,
                        Amplitude, Shine);

                    // Assign each color to the matrix
                    Julia.Red[y * Julia.xres + x] = (int)(Color.X * 255);
                    Julia.Green[y * Julia.xres + x] = (int)(Color.Y * 255);
                    Julia.Blue[y * Julia.xres + x] = (int)(Color.Z * 255);
                }
            }
        }
        
    }
}
