using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Utility
{

    static class Bitmaps
    {

        public delegate bool ColorDelegate(Color pixel, params Color[] colors);

        /// <summary>
        /// Returns new resized Bitmap from source Bitmap.
        /// </summary>
        public static Bitmap resize(Bitmap source, int newWidth, int newHeight)
        {
            Rectangle newSize = new Rectangle(0, 0, newWidth, newHeight);
            return resize(source, newSize);
        }

        public static Bitmap resize(Bitmap source, Rectangle newSize)
        {
            Bitmap resized = new Bitmap(newSize.Width, newSize.Height, source.PixelFormat);
            if(resized.PixelFormat == PixelFormat.Format1bppIndexed || resized.PixelFormat == PixelFormat.Format4bppIndexed || resized.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                resized = format(resized, PixelFormat.Format24bppRgb);
            }
            resized.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            using(var graphics = Graphics.FromImage(resized))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using(var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(source, newSize, 0, 0, source.Width, source.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return resized;
        }

        /// <summary>
        /// Reformats source Bitmap to new PixelFormat and returns as new Bitmap.
        /// </summary>
        public static Bitmap format(Bitmap source, PixelFormat format)
        {
            return source.Clone(new Rectangle(0, 0, source.Width, source.Height), format);
        }

        /// <summary>
        /// Sets source Bitmap Palette to new Colors from Color Array.
        /// </summary>
        public static void pallete(Bitmap bitmap, Color[] colors)
        {
            ColorPalette p = bitmap.Palette;
            for(int i = 0; i < p.Entries.GetLength(0); ++i)
            {
                p.Entries[i] = colors[i];
            }
            bitmap.Palette = p;
        }

        /// <summary>
        /// Returns true if Color is colored.
        /// </summary>
        public static bool isColored(Color color, params Color[] colors)
        {
            const int TRESHOLD = 16;
            if(System.Math.Abs(color.R - color.G) < TRESHOLD && System.Math.Abs(color.R - color.B) < TRESHOLD && System.Math.Abs(color.G - color.B) < TRESHOLD)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returns true if Color is gray.
        /// </summary>
        public static bool isGray(Color color, params Color[] colors)
        {
            return !isColored(color);
        }

        /// <summary>
        /// Performs bitwise inversion on source 1bpp Bitmap and returns result.
        /// </summary>
        public static unsafe Bitmap invert(Bitmap source)
        {
            if(source.PixelFormat != PixelFormat.Format1bppIndexed)
            {
                throw new ArgumentException("Unsuported Bitmap format! Expected PixelFormat.Format1bppIndexed");
            }
            int width = source.Width, height = source.Height;
            Bitmap converted = new Bitmap(width, height, PixelFormat.Format1bppIndexed);
            Rectangle rectangle = new Rectangle(0, 0, width, height);
            BitmapData sourceData = source.LockBits(rectangle, ImageLockMode.ReadOnly, source.PixelFormat);
            BitmapData convertedData = converted.LockBits(rectangle, ImageLockMode.ReadWrite, converted.PixelFormat);
            System.Int32* sourcePointer = (System.Int32*)sourceData.Scan0;
            System.Int32* convertedPointer = (System.Int32*)convertedData.Scan0;
            int end = (sourceData.Stride / 4) * height;
            for(int i = 0; i < end; ++i)
            {
                convertedPointer[i] = (System.Int32)~sourcePointer[i];
            }
            source.UnlockBits(sourceData);
            converted.UnlockBits(convertedData);
            return converted;
        }

        /// <summary>
        /// Converts source bitmap from 24bppRGB to 1bppIndexed and returns converted Bitmap.
        /// Color conversion algorithm is provided by ColorDelegate.
        /// </summary>
        public static unsafe Bitmap rgbTo1bppIndexed(Bitmap source, ColorDelegate colorDelegate)
        {
            if(source.PixelFormat != PixelFormat.Format24bppRgb)
            {
                throw new ArgumentException("Unsuported Bitmap format! Expected PixelFormat.Format24bppRgb");
            }
            int width = source.Width, height = source.Height;
            Bitmap converted = new Bitmap(width, height, PixelFormat.Format1bppIndexed);
            Rectangle rectangle = new Rectangle(0, 0, width, height);
            BitmapData sourceData = source.LockBits(rectangle, ImageLockMode.ReadOnly, source.PixelFormat);
            BitmapData convertedData = converted.LockBits(rectangle, ImageLockMode.ReadWrite, converted.PixelFormat);
            byte* sourcePixelPointer = (byte*)sourceData.Scan0;
            byte* convertedPixelPointer = (byte*)convertedData.Scan0;
            int sourceLine = -sourceData.Stride;
            int convertedLine = -convertedData.Stride;
            for(int y = 0; y < height; ++y)
            {
                sourceLine += sourceData.Stride;
                convertedLine += convertedData.Stride;
                int sourcePixel = sourceLine - 3;
                for(int x = 0; x < width; ++x)
                {
                    sourcePixel += 3;    // index for source pixel (24bbp, rgb format)
                    int convertedPixels = convertedLine + (x >> 3);     // destination byte for pixel (1bpp, ie 8pixels per byte)
                    Color pixelColor = Color.FromArgb(0, sourcePixelPointer[sourcePixel], sourcePixelPointer[sourcePixel + 1], sourcePixelPointer[sourcePixel + 2]);
                    if(colorDelegate(pixelColor))
                    {
                        convertedPixelPointer[convertedPixels] |= (byte)(0x80 >> (x & 0x7));    // mask out pixel bit in destination byte
                    }
                }
            }
            source.UnlockBits(sourceData);
            converted.UnlockBits(convertedData);
            return converted;
        }

        /// <summary>
        /// Returns new tiled 1bppIndexed Bitmap from source 1bppIndexed Bitmap.
        /// </summary>
        public static unsafe Bitmap tile(Bitmap source, int tilesHorizontal, int tilesVertical, int borderHorizontal, int borderVertical)
        {
            if(source.PixelFormat != PixelFormat.Format1bppIndexed)
            {
                throw new ArgumentException("Unsuported Bitmap format! Expected PixelFormat.Format1bppIndexed");
            }
            int sourceHeight = source.Height, sourceWidth = source.Width;
            int resultWidth = sourceWidth * tilesHorizontal + borderHorizontal * (tilesHorizontal - 1);
            int resultHeight = sourceHeight * tilesVertical + borderVertical * (tilesVertical - 1);
            Rectangle rectangle = new Rectangle(0, 0, sourceWidth, sourceHeight);
            BitmapData sourceBitmapData = source.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format1bppIndexed);
            rectangle.Width = resultWidth;
            rectangle.Height = resultHeight;
            Bitmap result = new Bitmap(resultWidth, resultHeight, PixelFormat.Format1bppIndexed);
            BitmapData resultBitmapData = result.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            IntPtr resultPointer = resultBitmapData.Scan0;
            int sourceLine = -sourceBitmapData.Stride;
            int resultLine = -resultBitmapData.Stride;
            byte* sourcePixels = (byte*)sourceBitmapData.Scan0;
            byte* resultPixels = (byte*)resultBitmapData.Scan0;
            byte[] memBuffer = new byte[resultBitmapData.Stride * sourceHeight];
            for(int y = 0; y < sourceHeight; ++y)
            {
                sourceLine += sourceBitmapData.Stride;
                resultLine += resultBitmapData.Stride;
                for(int x = 0, i = 0; x <= resultWidth; ++x, ++i)
                {
                    int sourceByte = sourceLine + (i >> 3);
                    int resultByte = resultLine + (x >> 3);
                    byte tempByte = (byte)((0x80 >> (i & 0x7)) & sourcePixels[sourceByte]);
                    int diff = (x % 8) - (i % 8);
                    if(diff > 0)
                    {
                        tempByte >>= diff;
                    }
                    else if(diff < 0)
                    {
                        tempByte <<= -diff;
                    }
                    resultPixels[resultByte] |= tempByte;
                    if(i + 1 >= sourceWidth)
                    {
                        x += borderHorizontal;
                        i = -1;
                    }
                }
            }
            Marshal.Copy(resultBitmapData.Scan0, memBuffer, 0, memBuffer.Length);
            for(int t = 0; t < tilesVertical; ++t)
            {
                Marshal.Copy(memBuffer, 0, resultPointer, memBuffer.Length);
                resultPointer += memBuffer.Length + resultBitmapData.Stride * borderVertical;
            }
            source.UnlockBits(sourceBitmapData);
            result.UnlockBits(resultBitmapData);
            return result;
        }
    }
}