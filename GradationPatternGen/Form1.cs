using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace GradationPatternGen
{
    public partial class GradationPatternGen : Form
    {
        Bitmap TestImage;

        public GradationPatternGen()
        {
            InitializeComponent();
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            if ((txtImageWidth.Text == "") || (txtImageHeight.Text == ""))
            {
                MessageBox.Show("no size", "Show");
                return;
            }
            if(txtDivideNum.Text == "")
            {
                MessageBox.Show("no divide", "Show");
                return;
            }
            if ((txtStartColor.Text == "") || (txtStopColor.Text == ""))
            {
                MessageBox.Show("no color", "Show");
                return;
            }
            int width = Convert.ToInt32(txtImageWidth.Text);
            int hegiht = Convert.ToInt32(txtImageHeight.Text);
            int divide = Convert.ToInt32(txtDivideNum.Text);
            if ((width == 0) || (hegiht == 0))
            {
                MessageBox.Show("size zero", "Show");
                return;
            }
            if (divide == 0)
            {
                MessageBox.Show("divide zero", "Show");
                return;
            }
            int baseNum = (cbHexColor.Checked) ? 16 : 10;
            int start_color = Convert.ToInt32(txtStartColor.Text, baseNum);
            int stop_color = Convert.ToInt32(txtStopColor.Text, baseNum);

            if (start_color > 255)
            {
                start_color = 255;
            }
            if (stop_color > 255)
            {
                stop_color = 255;
            }

            int width_increase = width / divide;
            double color_increase = (double)Math.Abs(start_color - stop_color) / (double)(divide - 1);
            TestImage = new Bitmap(width, hegiht);
            Graphics curGraphics = Graphics.FromImage(TestImage);
            for (int cnt = 0; cnt < divide; cnt++)
            {
                if (start_color > stop_color)
                {
                    int target_color = (int)Math.Round((double)start_color - ((double)cnt * color_increase), 0);
                    if (target_color < 0)
                    {
                        target_color = 0;
                    }
                    SolidBrush brush = new SolidBrush(Color.FromArgb(target_color, target_color, target_color));
                    curGraphics.FillRectangle(brush, cnt * width_increase, 0, width_increase, hegiht);
                }
                else
                {
                    int target_color = (int)Math.Round((double)start_color + ((double)cnt * color_increase), 0);
                    if (target_color > 255)
                    {
                        target_color = 255;
                    }
                    SolidBrush brush = new SolidBrush(Color.FromArgb(target_color, target_color, target_color));
                    curGraphics.FillRectangle(brush, cnt * width_increase, 0, width_increase, hegiht);
                }
            }

            ShowImage ImageForm = new ShowImage(TestImage);
            ImageForm.Visible = true;
        }

        private void btnStripeShowImage_Click(object sender, EventArgs e)
        {
            if ((txtImageWidth.Text == "") || (txtImageHeight.Text == ""))
            {
                MessageBox.Show("no size", "Show");
                return;
            }
            if (txtStripeDivideNum.Text == "")
            {
                MessageBox.Show("no divide", "Show");
                return;
            }
            if ((txtStripeColor1.Text == "") || (txtStripeColor2.Text == ""))
            {
                MessageBox.Show("no color", "Show");
                return;
            }
            int width = Convert.ToInt32(txtImageWidth.Text);
            int hegiht = Convert.ToInt32(txtImageHeight.Text);
            int divide = Convert.ToInt32(txtStripeDivideNum.Text);
            if ((width == 0) || (hegiht == 0))
            {
                MessageBox.Show("size zero", "Show");
                return;
            }
            if (divide == 0)
            {
                MessageBox.Show("divide zero", "Show");
                return;
            }
            int baseNum = (cbHexColor.Checked) ? 16 : 10;
            int color1 = Convert.ToInt32(txtStripeColor1.Text, baseNum);
            int color2 = Convert.ToInt32(txtStripeColor2.Text, baseNum);

            int width_increase = width / divide;
            TestImage = new Bitmap(width, hegiht);
            Graphics curGraphics = Graphics.FromImage(TestImage);
            for (int cnt = 0; cnt < divide; cnt++)
            {
                if (cnt % 2 == 0)
                {
                    int target1 = (color1 >> 0) & 0xFF;
                    int target2 = (color1 >> 8) & 0xFF;
                    int target3 = (color1 >> 16) & 0xFF;
                    SolidBrush brush = new SolidBrush(Color.FromArgb(target1, target2, target3));
                    curGraphics.FillRectangle(brush, cnt * width_increase, 0, width_increase, hegiht);
                }
                else
                {
                    int target1 = (color2 >> 0) & 0xFF;
                    int target2 = (color2 >> 8) & 0xFF;
                    int target3 = (color2 >> 16) & 0xFF;
                    SolidBrush brush = new SolidBrush(Color.FromArgb(target1, target2, target3));
                    curGraphics.FillRectangle(brush, cnt * width_increase, 0, width_increase, hegiht);
                }
            }

            ShowImage ImageForm = new ShowImage(TestImage);
            ImageForm.Visible = true;
        }

        private void btnIncreaseShowImage_Click(object sender, EventArgs e)
        {
            if ((txtImageWidth.Text == "") || (txtImageHeight.Text == ""))
            {
                MessageBox.Show("no size", "Show");
                return;
            }
            if (txtIncreaseDivideNum.Text == "")
            {
                MessageBox.Show("no divide", "Show");
                return;
            }
            if ((txtIncreaseStartColor.Text == "") || (txtIncreaseStopColor.Text == ""))
            {
                MessageBox.Show("no color", "Show");
                return;
            }
            int width = Convert.ToInt32(txtImageWidth.Text);
            int hegiht = Convert.ToInt32(txtImageHeight.Text);
            int divide = Convert.ToInt32(txtIncreaseDivideNum.Text);
            if ((width == 0) || (hegiht == 0))
            {
                MessageBox.Show("size zero", "Show");
                return;
            }
            if (divide == 0)
            {
                MessageBox.Show("divide zero", "Show");
                return;
            }

            int baseNum = (cbHexColor.Checked) ? 16 : 10;
            int start_color = Convert.ToInt32(txtIncreaseStartColor.Text, baseNum);
            int stop_color = Convert.ToInt32(txtIncreaseStopColor.Text, baseNum);

            if (start_color > 16777215)
            {
                start_color = 16777215;
            }
            if (stop_color > 16777215)
            {
                stop_color = 16777215;
            }

            int width_increase = width / divide;
            double color_increase = (double)Math.Abs(start_color - stop_color) / (double)(divide - 1);
            TestImage = new Bitmap(width, hegiht);
            Graphics curGraphics = Graphics.FromImage(TestImage);
            for (int cnt = 0; cnt < divide; cnt++)
            {
                if (start_color > stop_color)
                {
                    int target_color = (int)Math.Round((double)start_color - ((double)cnt * color_increase), 0);
                    if (target_color < 0)
                    {
                        target_color = 0;
                    }
                    int target1 = (target_color >> 0) & 0xFF;
                    int target2 = (target_color >> 8) & 0xFF;
                    int target3 = (target_color >> 16) & 0xFF;
                    SolidBrush brush = new SolidBrush(Color.FromArgb(target1, target2, target3));
                    curGraphics.FillRectangle(brush, cnt * width_increase, 0, width_increase, hegiht);
                }
                else
                {
                    int target_color = (int)Math.Round((double)start_color + ((double)cnt * color_increase), 0);
                    if (target_color > 16777215)
                    {
                        target_color = 16777215;
                    }
                    int target1 = (target_color >> 0) & 0xFF;
                    int target2 = (target_color >> 8) & 0xFF;
                    int target3 = (target_color >> 16) & 0xFF;
                    SolidBrush brush = new SolidBrush(Color.FromArgb(target1, target2, target3));
                    curGraphics.FillRectangle(brush, cnt * width_increase, 0, width_increase, hegiht);
                }
            }

            ShowImage ImageForm = new ShowImage(TestImage);
            ImageForm.Visible = true;
        }

        private void btnLoopShowImage_Click(object sender, EventArgs e)
        {
            if (txtWidthPerLoopColor.Text == "")
            {
                MessageBox.Show("no width", "Show");
                return;
            }
            if (listLoopColor.Items.Count == 0)
            {
                MessageBox.Show("no color item", "Show");
                return;
            }
            if ((txtImageWidth.Text == "") || (txtImageHeight.Text == ""))
            {
                MessageBox.Show("no size", "Show");
                return;
            }

            int width = Convert.ToInt32(txtImageWidth.Text);
            int hegiht = Convert.ToInt32(txtImageHeight.Text);
            int width_increase = Convert.ToInt32(txtWidthPerLoopColor.Text);
            if ((width == 0) || (hegiht == 0))
            {
                MessageBox.Show("size zero", "Show");
                return;
            }
            if (width_increase == 0)
            {
                MessageBox.Show("width per color zero", "Show");
                return;
            }

            int baseNum = (cbHexColor.Checked) ? 16 : 10;

            TestImage = new Bitmap(width, hegiht);
            Graphics curGraphics = Graphics.FromImage(TestImage);
            int cnt = 0;
            int color_index = 0;
            while(cnt < width)
            {
                string current_color = listLoopColor.Items[color_index].ToString();
                int target_color = Convert.ToInt32(current_color, baseNum);
                if (target_color > 16777215)
                {
                    target_color = 16777215;
                }

                int target1 = (target_color >> 0) & 0xFF;
                int target2 = (target_color >> 8) & 0xFF;
                int target3 = (target_color >> 16) & 0xFF;
                SolidBrush brush = new SolidBrush(Color.FromArgb(target1, target2, target3));
                curGraphics.FillRectangle(brush, cnt, 0, width_increase, hegiht);

                cnt += width_increase;
                color_index++;
                if(color_index >= listLoopColor.Items.Count)
                {
                    color_index = 0;
                }
            }

            ShowImage ImageForm = new ShowImage(TestImage);
            ImageForm.Visible = true;
        }

        private void btnClearLoopList_Click(object sender, EventArgs e)
        {
            listLoopColor.Items.Clear();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtColorToAdd.Text == "")
            {
                MessageBox.Show("no color", "Show");
                return;
            }

            int baseNum = (cbHexColor.Checked) ? 16 : 10;
            int add_color = Convert.ToInt32(txtColorToAdd.Text, baseNum);
            if(baseNum == 10)
            {
                listLoopColor.Items.Add(add_color.ToString());
            }
            else
            {
                listLoopColor.Items.Add("0x" + add_color.ToString("X"));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbSaveName == null)
            {
                MessageBox.Show("no file name", "Save");
                return;
            }
            if (TestImage == null)
            {
                MessageBox.Show("no bitmap", "Save");
                return;
            }

            string fileName = System.IO.Path.GetFileNameWithoutExtension(tbSaveName.Text);
            string newFileName;

            ImageFormat format;
            if(rbSaveBmp.Checked)
            {
                format = ImageFormat.Bmp;
                newFileName = fileName + ".bmp";
            }
            else if(rbSavePng.Checked)
            {
                format = ImageFormat.Png;
                newFileName = fileName + ".png";
            }
            else if(rbSaveJpg.Checked)
            {
                format = ImageFormat.Jpeg;
                newFileName = fileName + ".jpg";
            }
            else
            {
                format = ImageFormat.Bmp;
                newFileName = fileName + ".bmp";
            }

            TestImage.Save(newFileName, format);
            MessageBox.Show("[" + newFileName + "] Save Completely!", "Save");
        }

        private void ImageToArray_Load(object sender, EventArgs e)
        {

        }

        private void cbStripes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenContainer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @".");
        }
    }
}
