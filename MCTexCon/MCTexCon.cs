using System;
using System.Linq;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Imaging;

namespace MCTexCon
{
    public class MCTexCon
    {
        #region Universal Properties

        private Image _imageIn { get; set; }
        private Image _imageOut { get; set; }
        private TexMap _mapIn { get; set; }
        private TexMap _mapOut { get; set; }
        private Bitmap _transformImageIn { get; set; }
        private Bitmap _transformImageOut { get; set; }
        private int _blockSize { get; set; }
        private int _inColumnCount = 16;
        private int _inRowCount = 16;
        private int _outColumnCount = 16;
        private int _outRowCount = 16;

        #endregion
        
        #region Desktop API

        private string _outputPath { get; set; }

        /// <summary>Constructor for desktop instance.</summary>
        /// <param name="imageInPath">Fully qualified path to the image file to be converted.</param>
        /// <param name="imageOutPath">Fully qualified path to the location to save the converted file.</param>
        /// <param name="mapInPath">Fully qualified path to the json file of the original version definition for the texture map.</param>
        /// <param name="mapOutPath">Fully qualified path to the json file of the output version definition for the texture map.</param>
        public MCTexCon(string imageInPath, string imageOutPath, string mapInPath, string mapOutPath)
        {
            try
            {
                if (File.Exists(imageInPath))
                {
                    this._imageIn = Image.FromFile(imageInPath);
                    this._transformImageIn = (Bitmap)this._imageIn;
                }
                else
                {
                    throw new Exception($"ERROR: File.Exists({imageInPath})");
                }

                if (!string.IsNullOrEmpty(imageOutPath))
                {
                    this._outputPath = imageOutPath;
                }
                else
                {
                    throw new Exception($"ERROR: imageOutPath can not be NULL or EMPTY.");
                }

                if (File.Exists(mapInPath))
                {
                    string json = File.ReadAllText(mapInPath);
                    this._mapIn = JsonConvert.DeserializeObject<TexMap>(json);
                }
                else
                {
                    throw new Exception($"ERROR: File.Exists({mapInPath})");
                }

                if (File.Exists(mapOutPath))
                {

                    string json = File.ReadAllText(mapOutPath);
                    this._mapOut = JsonConvert.DeserializeObject<TexMap>(json);
                }
                else
                {
                    throw new Exception($"ERROR: File.Exists({mapOutPath})");
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void SaveNewTexMapToFile()
        {
            try
            {
                Convert();

                SaveOutput();

                CleanUp();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #endregion

        #region Customization Methods

        /// <summary>Force the count of rows and columns for the output image
        /// to derive from the max column x and y of the MapOut TexMap respectively.</summary>
        public void DetectRowColCounts()
        {
            try
            {
                this._inColumnCount = this._mapIn.texBlocks.Max(b => b.coord.x);
                this._inRowCount = this._mapIn.texBlocks.Max(b => b.coord.y);
                this._outColumnCount = this._mapOut.texBlocks.Max(b => b.coord.x);
                this._outRowCount = this._mapOut.texBlocks.Max(b => b.coord.y);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// Force the count of rows and columns for the output image
        /// to arguments passed in
        /// </summary>
        /// <param name="inCols">Number of columns to assume the input image is divided into.</param>
        /// <param name="inRows">Number of rows to assume the input image is divided into.</param>
        /// <param name="outCols">Number of columns to create for the output image.</param>
        /// <param name="outRows">Number of rows to create for the output image.</param>
        public void UseCustomRowColCounts(int inCols, int inRows, int outCols, int outRows)
        {
            try
            {
                this._inColumnCount = inCols;
                this._inRowCount = inRows;
                this._outColumnCount = outCols;
                this._outRowCount = outRows;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #endregion

        #region Core Methods

        private void Convert()
        {
            try
            {
                CalculateBlockSize();

                AddImagesToMapInTexBlocks();

                TranslateMapInImagesToMapOutImages();

                InitializeTransformImageOut();

                BuildImageOutFromMapOut();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        
        private void CalculateBlockSize()
        {
            try
            {
                this._blockSize = this._imageIn.Width / this._inRowCount;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void AddImagesToMapInTexBlocks()
        {
            try
            {
                foreach (TexBlock block in this._mapIn.texBlocks)
                {
                    //TODO: Test if this works. Might need to make
                    //      this resiliant to nullObj ref.
                    AddImageToTexBlock(block);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void AddImageToTexBlock(TexBlock block)
        {
            try
            {
                int xCoord = block.coord.x * this._blockSize;
                int yCoord = block.coord.y * this._blockSize;
                Rectangle cloneRect = new Rectangle(xCoord, yCoord, this._blockSize, this._blockSize);
                PixelFormat format = this._imageIn.PixelFormat;
                block.image = this._transformImageIn.Clone(cloneRect, format);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void TranslateMapInImagesToMapOutImages()
        {
            try
            {
                foreach (TexBlock inBlock in this._mapIn.texBlocks)
                {
                    TexBlock outBlock = this._mapOut.texBlocks.FirstOrDefault(b => b.name == inBlock.name);
                    //TODO: Roadmap item: We may want a method that gets all the unused
                    //      coordinates in the _mapOut.textBlocks and drop this in the first location there
                    //      if the outBLock doesn't exist in the _mapOut.textBlocks. For now we'll just
                    //      ignore ones that can't be mapped.
                    if (outBlock == null) continue;

                    outBlock.image = inBlock.image;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void InitializeTransformImageOut()
        {
            try
            {
                int width = this._outColumnCount * this._blockSize;
                int height = this._outRowCount * this._blockSize;
                this._transformImageOut = new Bitmap(width, height);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void BuildImageOutFromMapOut()
        {
            try
            {
                foreach (TexBlock block in this._mapOut.texBlocks)
                {
                    this.MapImageOntoImageOut(block);
                }
                this._imageOut = (Image)this._transformImageOut;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void MapImageOntoImageOut(TexBlock block)
        {
            try
            {
                var xOffset = block.coord.x * this._blockSize;
                var yOffset = block.coord.y * this._blockSize;

                for (int x = 0; x < block.image.Width; x++)
                {
                    for (int y = 0; y < block.image.Height; y++)
                    {
                        Color pixelColor = block.image.GetPixel(x, y);
                        Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
                        this._transformImageOut.SetPixel(x + xOffset, y + yOffset, newColor);
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        
        private void SaveOutput()
        {
            try
            {
                if (!File.Exists(this._outputPath))
                {
                    File.Create(this._outputPath);
                }

                FileStream stream = new FileStream(this._outputPath, FileMode.Create, FileAccess.ReadWrite);


                //this._imageOut.Save(this._outputPath, ImageFormat.Png);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void CleanUp()
        {
            try
            {
                this._imageIn.Dispose();
                this._transformImageIn.Dispose();
                this._imageOut.Dispose();
                this._transformImageOut.Dispose();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #endregion
    }
}