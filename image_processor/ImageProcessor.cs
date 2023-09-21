﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/// <summary>
/// Defines ImageProcessor class
/// </summary>
class ImageProcessor
    {
    /// <summary>
    /// Inverses images using threading
    /// </summary>
    /// <param name="filenames">images to inverse</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach (filenames, file => {
            CreateInverse(file);
        });
    }

    /// <summary>
    /// Inverses images
    /// </summary>
    /// <param name="file">images to inverse</param>
    private static void CreateInverse(string file)
    {
        Bitmap bmp = new Bitmap(file);
        //  sets up access to data of the image. bitmapData holds information about the locked pixel data
        BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
        //  calculates the number of bytes required to represent a single pixel in the image
        int bytesPerPixel = Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
        // calculates total number of bytes required to store the entire image
        int byteCount = bitmapData.Stride * bmp.Height;
        // create a byte array called pixels with a size equal to byteCount. This array will hold the pixel data of the entire image.
        byte[] pixels = new byte[byteCount];
        // returns a pointer to the first byte of the locked pixel data
        IntPtr ptrFirstPixel = bitmapData.Scan0;
        // copy pixel data from the locked memory pointed to by ptrFirstPixel to the pixels array.
        Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
        int heightInPixels = bitmapData.Height;
        int widthInBytes = bitmapData.Width * bytesPerPixel;

        for (int y = 0; y < heightInPixels; y++)
        {
            int currentLine = y * bitmapData.Stride;
            for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
            {
                int oldBlue = pixels[currentLine + x];
                int oldGreen = pixels[currentLine + x + 1];
                int oldRed = pixels[currentLine + x + 2];

                // calculate new pixel value
                pixels[currentLine + x] = (byte)(255 - oldBlue);
                pixels[currentLine + x + 1] = (byte)(255 - oldGreen);
                pixels[currentLine + x + 2] = (byte)(255 - oldRed);
            }
        }
 
        // copy modified bytes back
        Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
        bmp.UnlockBits(bitmapData);

        //create new file name
        string name = string.Format("{0}_inverse{1}",
                                    Path.GetFileNameWithoutExtension(file),
                                    Path.GetExtension(file));
        //save new image
        bmp.Save(name);
    }

        /// <summary>
        /// Turns a colored image into grayscale
        /// </summary>
        /// <param name="filenames">files to modify</param>
        public static void Grayscale(string[] filenames)
        {

            Parallel.ForEach(filenames, filename =>
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
            });
        }
    }