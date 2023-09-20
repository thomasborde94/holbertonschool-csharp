﻿using System;
using System.Drawing;
using System.IO;

class ImageProcessor
    {
        public static void Inverse(string[] filenames)
        {

            string currentDirName = System.IO.Directory.GetCurrentDirectory();

            foreach (string filename in filenames)
            { 
                string new_filename = filename.Split('.')[0] + "_inverse.jpg";
                Bitmap bmp = new Bitmap(filename);

                //get image dimension
                int width = bmp.Width;
                int height = bmp.Height;

                //negative
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        Color p = bmp.GetPixel(x, y);

                        //extract ARGB value from p
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //finds negative value
                        int rNegativ = 255 - r;
                        int gNegativ = 255 - g;
                        int bNegativ = 255 - b;

                        //set new ARGB value in pixel
                        bmp.SetPixel(x, y, Color.FromArgb(a, rNegativ, gNegativ, bNegativ));
                    }
                }

                //save negative image
                if (new_filename.Split("/").Length > 1)
                    bmp.Save(new_filename.Split("/")[1]);
                else
                    bmp.Save(new_filename);
            }
        }
    }