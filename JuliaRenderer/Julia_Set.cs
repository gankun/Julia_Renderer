using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace JuliaRenderer
{
    
    class Julia_Set
    {                
        public int xres;
        public int yres;

        public int[] Red;
        public int[] Green;
        public int[] Blue;
        
        public Julia_Set(int x, int y)
        {
            xres = x;
            yres = y;
            Red = new int[xres * yres];
            Green = new int[xres * yres];
            Blue = new int[xres * yres];

            for (int i = 0; i < xres * yres; i++) { Red[i] = 0; }
            for (int i = 0; i < xres * yres; i++) { Green[i] = 0; } 
            for (int i = 0; i < xres * yres; i++) { Blue[i] = 0; }
        }

        public void change_res(int new_xres, int new_yres)
        {
            xres = new_xres;
            yres = new_yres;

            Red = new int[xres * yres];
            Green = new int[xres * yres];
            Blue = new int[xres * yres];

            for (int i = 0; i < xres * yres; i++) { Red[i] = 0; }
            for (int i = 0; i < xres * yres; i++) { Green[i] = 0; }
            for (int i = 0; i < xres * yres; i++) { Blue[i] = 0; }
        }

       
        public void Print_PPM(string Save_file)
        {
            using (StreamWriter file =
                new StreamWriter(Save_file))
            {
                file.WriteLine("P3");
                file.WriteLine(String.Format("{0} {1}", xres, yres));
                file.WriteLine("255");
                for (int j = 0; j < yres; j++)
                {
                    for (int i = 0; i < xres; i++)
                    {
                        file.WriteLine(String.Format("{0} {1} {2}", Red[j * xres + i], Green[j * xres + i],
                                         Blue[j * xres + i]));
                    }
                }
            }
        }

        public Bitmap MakeBitmap()
        {
            Bitmap bmap = new Bitmap(xres, yres, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int x = 0; x < xres; x++)
            {
                for (int y = 0; y < yres; y++)
                {
                    bmap.SetPixel(x, y, System.Drawing.Color.FromArgb(Red[y * xres + x], Green[y * xres + x], Blue[y * xres + x]));
                }
            }

            return bmap;
     
        }
        public static Bitmap ReadBitmapFromPPM(string file)
        {
            var reader = new BinaryReader(new FileStream(file, FileMode.Open));
            if (reader.ReadChar() != 'P' || reader.ReadChar() != '6')
                return null;
            reader.ReadChar(); //Eat newline
            string widths = "", heights = "";
            char temp;
            while ((temp = reader.ReadChar()) != ' ')
                widths += temp;
            while ((temp = reader.ReadChar()) >= '0' && temp <= '9')
                heights += temp;
            if (reader.ReadChar() != '2' || reader.ReadChar() != '5' || reader.ReadChar() != '5')
                return null;
            reader.ReadChar(); //Eat the last newline
            int width = int.Parse(widths),
                height = int.Parse(heights);
            Bitmap bitmap = new Bitmap(width, height);
            //Read in the pixels
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    bitmap.SetPixel(x, y, 
                        System.Drawing.Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte()));
            return bitmap;
        }
    }
}
