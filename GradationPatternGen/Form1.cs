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
            if((txtImageWidth==null) || (txtImageHeight == null))
            {
                MessageBox.Show("no size", "Show");
                return;
            }
            if ((txtStartColor == null) || (txtStopColor == null))
            {
                MessageBox.Show("no color", "Show");
                return;
            }
            if(txtDivideNum == null)
            {
                MessageBox.Show("no divide", "Show");
                return;
            }
            int width = Convert.ToInt32(txtImageWidth.Text);
            int hegiht = Convert.ToInt32(txtImageHeight.Text);
            int start_color = Convert.ToInt32(txtStartColor.Text);
            int stop_color = Convert.ToInt32(txtStopColor.Text);
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

            int width_increase = width / divide;
            double color_increase = (double)Math.Abs(start_color-stop_color) / (double)(divide-1);
            TestImage = new Bitmap(width, hegiht);
            Graphics curGraphics = Graphics.FromImage(TestImage);
            for(int cnt=0; cnt<divide; cnt++)
            {
                if(start_color>stop_color)
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
                    if (target_color>255)
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

            TestImage.Save(tbSaveName.Text);
            MessageBox.Show("[" + tbSaveName.Text + "] Save Completely!", "Save");
        }

        private void ImageToArray_Load(object sender, EventArgs e)
        {

        }
    }
}
