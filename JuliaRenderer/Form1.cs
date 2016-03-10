using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

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
            

             
            Julia_Set temp = new Julia_Set(500, 500);
            Julia_Raytracer Tracer = new Julia_Raytracer(3, .001F, 1.95F);
            Tracer.Generate(temp, new Vector4(0, 0, 0, 0), new Vector4(0, 0, 0, 0));
            string target = @"C:\Users\Matthew\Project\WriteLines2.ppm";
            temp.Print_PPM(target);

            var bit = temp.MakeBitmap();
            pictureBox1.Image = bit;
            pictureBox1.Invalidate();
        }

        

     
    }
}
