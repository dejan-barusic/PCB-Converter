using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace PCBConverter
{

    class Board
    {

        public Board()
        {
            colors = new Color[2];
            inverse = false;
            colorDelegate = Utility.Bitmaps.isGray;
        }

        /// <summary>
        /// True if input Image is loaded, false if it is not.
        /// </summary>
        public bool Loaded
        {
            get
            {
                return inputBitmap == null ? false : true;
            }
        }

        /// <summary>
        /// Returns current Image representation of this board.
        /// </summary>
        public Bitmap Bitmap
        {
            get
            {
                int stepCountHorizontal = (int)System.Math.Round(boardWidth / stepHorizontal);
                int stepCountVertical = (int)System.Math.Round(boardHeight / stepVertical);
                boardBitmap = Utility.Bitmaps.resize(inputBitmap, stepCountHorizontal, stepCountVertical);
                if(boardBitmap.PixelFormat != PixelFormat.Format24bppRgb)
                {
                    boardBitmap = Utility.Bitmaps.format(boardBitmap, PixelFormat.Format24bppRgb);
                }
                boardBitmap = Utility.Bitmaps.rgbTo1bppIndexed(boardBitmap, colorDelegate);
                if(tilesHorizontal > 1 || tilesVertical > 1)
                {
                    boardBitmap = Utility.Bitmaps.tile(boardBitmap, tilesHorizontal, tilesVertical, tileBorderHorizontalSteps, tileBorderVerticalSteps);
                }
                if(inverse)
                {
                    boardBitmap = Utility.Bitmaps.invert(boardBitmap);
                }
                Utility.Bitmaps.pallete(boardBitmap, colors);
                return (Bitmap)boardBitmap.Clone();
            }
        }

        /// <summary>
        /// Returns input Image.
        /// </summary>
        public Bitmap InputBitmap
        {
            get
            {
                return (Bitmap)inputBitmap.Clone();
            }
            set
            {
                inputBitmap = value;
                ratio = (float)inputBitmap.Height / inputBitmap.Width;
            }
        }

        /// <summary>
        /// Gets the width, in pixels, of input Image.
        /// </summary>
        public int InputBitmapWidth
        {
            get
            {
                return inputBitmap.Width;
            }
        }

        /// <summary>
        /// Gets the height, in pixels, of input Image.
        /// </summary>
        public int InputBitmapHeight
        {
            get
            {
                return inputBitmap.Height;
            }
        }

        /// <summary>
        /// Gets the sides ratio of Image.
        /// </summary>
        public float Ratio
        {
            get
            {
                return ratio;
            }
        }

        /// <summary>
        /// Gets input Image PixelFormat.
        /// </summary>
        public string Format
        {
            get
            {
                return inputBitmap.PixelFormat.ToString();
            }
        }

        /// <summary>
        /// Gets and sets exposed Color.
        /// </summary>
        public Color ExposedColor
        {
            get
            {
                return colors[1];
            }
            set
            {
                colors[1] = value;
            }
        }

        /// <summary>
        /// Gets and sets nonexposed Color.
        /// </summary>
        public Color NonexposedColor
        {
            get
            {
                return colors[0];
            }
            set
            {
                colors[0] = value;
            }
        }

        /// <summary>
        /// Gets board information as string.
        /// </summary>
        public string Info
        {
            get
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder(128);
                sb.Append("Board size: ");
                sb.Append((boardBitmap.Width * stepHorizontal).ToString("0.00"));
                sb.Append(" x ");
                sb.Append((boardBitmap.Height * stepVertical).ToString("0.00"));
                sb.Append(" mm   |   Horizontal steps: ");
                sb.Append(boardBitmap.Width);
                sb.Append("   |   Vertical steps: ");
                sb.Append(boardBitmap.Height);
                return sb.ToString();
            }
        }

        /// <summary>
        /// Gets and sets number of horizontal tiles.
        /// </summary>
        public int HorizontalTiles
        {
            get
            {
                return tilesHorizontal;
            }
            set
            {
                if(value > 0 && value <= 50)
                {
                    tilesHorizontal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 1 to 50!");
                }
            }
        }

        /// <summary>
        /// Gets and sets number of vertical tiles.
        /// </summary>
        public int VerticalTiles
        {
            get
            {
                return tilesVertical;
            }
            set
            {
                if(value > 0 && value <= 50)
                {
                    tilesVertical = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 1 to 50!");
                }
            }
        }

        /// <summary>
        /// Gets and sets border between tiles.
        /// </summary>
        public float Border
        {
            get
            {
                return tileBorder;
            }
            set
            {
                if(value >= 0f && value <= 100f)
                {
                    tileBorder = value;
                    tileBorderHorizontalSteps = (int)System.Math.Round(tileBorder / stepHorizontal);
                    tileBorderVerticalSteps = (int)System.Math.Round(tileBorder / stepVertical);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 0.0 to 100.0!");
                }
            }
        }

        /// <summary>
        /// Gets and sets total board width in milimeters.
        /// </summary>
        public float BoardWidth
        {
            get
            {
                return boardWidth;
            }
            set
            {
                if(value >= 0f && value <= 1000f)
                {
                    boardWidth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 0.0 to 1000.0!");
                }
            }
        }

        /// <summary>
        /// Gets and sets total board height in milimeters.
        /// </summary>
        public float BoardHeight
        {
            get
            {
                return boardHeight;
            }
            set
            {
                if(value >= 0f && value <= 1000f)
                {
                    boardHeight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 0.0 to 1000.0!");
                }
            }
        }

        /// <summary>
        /// Gets and sets horizontal step in milimeters.
        /// </summary>
        public float HorizontalStep
        {
            get
            {
                return stepHorizontal;
            }
            set
            {
                if(value > 0f && value <= 1f)
                {
                    stepHorizontal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 0.00001 to 1.00000!");
                }
            }
        }

        /// <summary>
        /// Gets and sets vertical step in milimeters.
        /// </summary>
        public float VerticalStep
        {
            get
            {
                return stepVertical;
            }
            set
            {
                if(value > 0f && value <= 1f)
                {
                    stepVertical = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Value must be in range of 0.00001 to 1.00000!");
                }
            }
        }

        /// <summary>
        /// Gets and sets inverse flag.
        /// </summary>
        public bool Inverse
        {
            get
            {
                return inverse;
            }
            set
            {
                inverse = value;
            }
        }

        private Bitmap inputBitmap, boardBitmap;
        private Color[] colors;
        private float ratio, tileBorder, boardWidth, boardHeight, stepVertical, stepHorizontal;
        private bool inverse;
        private int tilesHorizontal, tilesVertical, tileBorderHorizontalSteps, tileBorderVerticalSteps;
        private Utility.Bitmaps.ColorDelegate colorDelegate;
    }
}