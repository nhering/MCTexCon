using MCTexCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureMapConverter
{
    public partial class ConvertTool : Form
    {
        private FilePath inputImage { get; set; }
        private FilePath inputMap { get; set; }
        private FilePath outputMap { get; set; }

        private Image outputImage { get; set; }

        private OpenFileDialog openFileDialog { get; set; }
        private SaveFileDialog saveFileDialog { get; set; }
        private FolderBrowserDialog folderBrowserDialog
        {
            get
            {
                return new FolderBrowserDialog();
            }
        }

        public ConvertTool()
        {
            InitializeComponent();

            this.inputImage = new FilePath(FilePaths.InputImage, menu_InputTexture);
            this.inputMap = new FilePath(FilePaths.InputMap, menu_InputMap);
            this.outputMap = new FilePath(FilePaths.OutputMap, menu_OutputMap);

            validatePaths();

            resetDialogs();
        }

        private void resetDialogs()
        {
            this.openFileDialog = new OpenFileDialog()
            {
                Title = "Open File"
            };
            this.saveFileDialog = new SaveFileDialog()
            {
                Filter = "PNG Image|*.png",
                Title = "Save Texture Map"
            };
        }

        private void validatePaths()
        {
            this.inputImage.ValidateFile();
            this.inputMap.ValidateFile();
            this.outputMap.ValidateFile();

            if (this.inputImage.MenuItem.Image == null ||
                this.inputMap.MenuItem.Image == null ||
                this.outputMap.MenuItem.Image == null)
            {
                this.menuSaveNewTexture.Enabled = false;
                this.btn_OutputTexture.Enabled = false;
            }
            else
            {
                this.menuSaveNewTexture.Enabled = true;
                this.btn_OutputTexture.Enabled = true;
                updateOutputImage();
            }
        }

        private void updateOutputImage()
        {
            var converter = new MCTexCon.MCTexCon(
                this.inputImage.FileName,
                this.inputImage.FileName,
                this.inputMap.FileName,
                this.outputMap.FileName);
            this.outputImage = converter.GetConvertedImage();
            this.ImageOut.Image = this.outputImage;
        }

        private void menuInputTexture_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.Filter = "PNG Image|*.png";
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.inputImage.FileName = this.openFileDialog.FileName;
                    this.ImageIn.Image = Image.FromFile(this.inputImage.FileName);
                }
                this.validatePaths();
                resetDialogs();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void menuInputMap_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.Filter = "JSON File|*.json";
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.inputMap.FileName = this.openFileDialog.FileName;
                    this.InputMapPath.Text = this.openFileDialog.FileName;
                }
                this.validatePaths();
                resetDialogs();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void menuOutputMap_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog.Filter = "JSON File|*.json";
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.outputMap.FileName = this.openFileDialog.FileName;
                    this.OutputMapPath.Text = this.openFileDialog.FileName;
                }
                this.validatePaths();
                resetDialogs();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void menuSaveNewTexture_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (MemoryStream stream = MCTexCon.MCTexCon.ImageToStream(this.outputImage, ImageFormat.Png))
                    {
                        StreamWriter writer = new StreamWriter(stream);
                        stream.Seek(0, SeekOrigin.Begin);

                        using (FileStream fileStream = new FileStream(this.saveFileDialog.FileName, FileMode.OpenOrCreate))
                        {
                            stream.CopyTo(fileStream);
                            fileStream.Flush();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        internal static class FilePaths
        {
            public const string InputImage = "Input Image";
            public const string OutputImage = "Output Image";
            public const string InputMap = "Input Map";
            public const string OutputMap = "Output Map";
        }

        internal class FilePath
        {
            public string Name { get; set; }
            public string Dir { get; set; }
            public string FileName { get; set; }
            public ToolStripMenuItem MenuItem { get; set; }

            public FilePath(string name, ToolStripMenuItem menuItem)
            {
                this.Name = name;
                this.Dir = string.Empty;
                this.FileName = string.Empty;
                this.MenuItem = menuItem;
            }

            public void ValidateDirectory()
            {
                if (!Directory.Exists(Dir))
                {
                    this.MenuItem.Image = null;
                    return;
                }
                this.MenuItem.Image = Properties.Resources.CheckMark;
            }

            public void ValidateFile()
            {
                var fullpath = Path.Combine(this.Dir, this.FileName);
                if (!File.Exists(fullpath))
                {
                    this.MenuItem.Image = null;
                    return;
                }
                this.MenuItem.Image = Properties.Resources.CheckMark;
            }
        }
    }
}
