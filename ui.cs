using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace PCBConverter
{

    public partial class UI : Form
    {

        public UI()
        {
            InitializeComponent();
            board = new Board();
            ui_dpiInput.Enabled = false;
            ui_inverseProcessCheckbox.Enabled = false;
            ui_saveButton.Enabled = false;
            ui_boardHeightInput.Enabled = false;
            ui_boardWidthInput.Enabled = false;
        }

        private Board board;
        private string path, file;

        private void ui_openButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "BMP|*.bmp|JPEG|*.jpg|GIF|*.gif|TIFF|*.tif|PNG|*.png|All files|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        board.InputBitmap = (Bitmap)Image.FromFile(dialog.FileName);                   
                    }
                    catch(System.IO.FileNotFoundException)
                    {
                        MessageBox.Show(string.Format("File {0} is not found!", dialog.SafeFileName), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ui_inputBitmap.Image = board.InputBitmap;
                    path = dialog.FileName;
                    file = dialog.SafeFileName;
                    StringBuilder sb = new StringBuilder(128);
                    sb.Append(path.Substring(path.LastIndexOf('\\') + 1, path.Length - path.LastIndexOf('\\') - 1));
                    sb.AppendLine();
                    sb.Append(board.InputBitmapWidth);
                    sb.Append("x");
                    sb.Append(board.InputBitmapHeight);
                    sb.Append(" pixels");
                    sb.AppendLine();
                    sb.Append(board.Format);
                    ui_inputBitmapInfo.Text = sb.ToString();
                    ui_boardWidthInput.Value = board.InputBitmapWidth * ui_stepHorizontalInput.Value;
                    ui_boardHeightInput.Value = board.InputBitmapHeight * ui_stepVerticalInput.Value;
                    controlsChanged();
                    ui_saveButton.Enabled = true;
                    ui_inverseProcessCheckbox.Enabled = true;
                    ui_boardHeightInput.Enabled = true;
                    ui_boardWidthInput.Enabled = true;
                }
            }
        }

        private void ui_boardWidthInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_boardHeightInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_stepHorizontalInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_stepVerticalInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_dpiInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_useDPIcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(ui_useDPIcheckbox.Checked)
            {
                ui_boardWidthInput.Enabled = false;
                ui_boardHeightInput.Enabled = false;
                ui_dpiInput.Enabled = true;
                controlsChanged();
            }
            else
            {
                ui_boardWidthInput.Enabled = true;
                ui_boardHeightInput.Enabled = true;
                ui_dpiInput.Enabled = false;
            }
        }

        private void ui_tileHorizontalInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_tileVerticalInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_tileBorderInput_ValueChanged(object sender, EventArgs e)
        {
            controlsChanged();
        }

        private void ui_exposedColorButton_Click(object sender, EventArgs e)
        {
            using(ColorDialog dialog = new ColorDialog())
            {
                dialog.ShowDialog();
                board.ExposedColor = dialog.Color;
                ui_exposedColorButton.BackColor = dialog.Color;
                controlsChanged();
            }
        }

        private void ui_nonexposedColorButton_Click(object sender, EventArgs e)
        {
            using(ColorDialog dialog = new ColorDialog())
            {
                dialog.ShowDialog();
                board.NonexposedColor = dialog.Color;
                ui_nonexposedColorButton.BackColor = dialog.Color;
                controlsChanged();
            }
        }

        private void ui_inverseProcessCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            board.Inverse = ui_inverseProcessCheckbox.Checked;
            ui_workBitmap.Image = board.Bitmap;
        }

        private void ui_saveButton_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.FileName = file.Substring(0, file.LastIndexOf('.'));
                dialog.Filter = "Bitmap (1 bit per pixel) (*.bmp)|*.bmp|All files (*.*)|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    board.Bitmap.Save(dialog.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void ui_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// Collects all user inputs and gets new processed board Image from board object.
        /// </summary>
        private void controlsChanged()
        {
            if(ui_useDPIcheckbox.Checked)
            {
                ui_boardWidthInput.Value = (board.InputBitmapWidth / ui_dpiInput.Value) * 25.4m;
                ui_boardHeightInput.Value = ui_boardWidthInput.Value * (decimal)board.Ratio;
            }
            try
            {
                board.BoardWidth = (float)ui_boardWidthInput.Value;
                board.BoardHeight = (float)ui_boardHeightInput.Value;
                board.HorizontalStep = (float)ui_stepHorizontalInput.Value;
                board.VerticalStep = (float)ui_stepVerticalInput.Value;
                board.HorizontalTiles = (int)ui_tileHorizontalInput.Value;
                board.VerticalTiles = (int)ui_tileVerticalInput.Value;
                board.Border = (float)ui_tileBorderInput.Value;
                board.ExposedColor = ui_exposedColorButton.BackColor;
                board.NonexposedColor = ui_nonexposedColorButton.BackColor;
            }
            catch(ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(board.Loaded)
            {
                ui_workBitmap.Image = board.Bitmap;
                ui_workBitmapInfo.Text = board.Info;
            }
        }
    }
}