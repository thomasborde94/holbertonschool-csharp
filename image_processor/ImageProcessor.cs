﻿using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

/// <summary>
/// Defines ImageProcessor class
/// </summary>
class ImageProcessor
    {
        /// <summary>
        /// Inverses an image
        /// </summary>
        /// <param name="filenames">files to inverse</param>
        public static void Inverse(string[] filenames)
        {
            Parallel.ForEach(filenames, filename =>
            {
                string newFilename = Path.GetFileNameWithoutExtension(filename) + "_inverse.jpg";
                Bitmap bmp = new Bitmap(filename);

                int width = bmp.Width;
                int height = bmp.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = bmp.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        int rNegativ = 255 - r;
                        int gNegativ = 255 - g;
                        int bNegativ = 255 - b;

                        bmp.SetPixel(x, y, Color.FromArgb(a, rNegativ, gNegativ, bNegativ));
                    }
                }

                if (newFilename.Split("/").Length > 1)
                    bmp.Save(newFilename.Split("/")[1]);
                else
                    bmp.Save(newFilename);
            });
        }

        /// <summary>
        /// Turns a colored image into grayscale
        /// </summary>
        /// <param name="filenames">files to modify</param>
        public static void Grayscale(string[] filenames)
        {
            foreach (string filename in filenames)
            {
                string newFilename = filename.Split('.')[0] + "_grayscale.jpg";
                Bitmap bmp = new Bitmap(filename);

                int width = bmp.Width;
                int height = bmp.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);

                        int average = (pixel.R + pixel.G + pixel.B) / 3;
                        Color grayscalePixel = Color.FromArgb(pixel.A, average, average, average);
                        bmp.SetPixel(x, y, grayscalePixel);
                    }
                }
                if (newFilename.Split("/").Length > 1)
                    bmp.Save(newFilename.Split("/")[1]);
                else
                    bmp.Save(newFilename);
            }
        }
    }