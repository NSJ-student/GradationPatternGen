namespace GradationPatternGen
{
    partial class GradationPatternGen
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSaveName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImageWidth = new System.Windows.Forms.TextBox();
            this.txtImageHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartColor = new System.Windows.Forms.TextBox();
            this.txtStopColor = new System.Windows.Forms.TextBox();
            this.txtDivideNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIncreaseShowImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIncreaseStartColor = new System.Windows.Forms.TextBox();
            this.txtIncreaseDivideNum = new System.Windows.Forms.TextBox();
            this.txtIncreaseStopColor = new System.Windows.Forms.TextBox();
            this.rbSaveJpg = new System.Windows.Forms.RadioButton();
            this.rbSaveBmp = new System.Windows.Forms.RadioButton();
            this.rbSavePng = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStripeColor1 = new System.Windows.Forms.TextBox();
            this.txtStripeDivideNum = new System.Windows.Forms.TextBox();
            this.txtStripeColor2 = new System.Windows.Forms.TextBox();
            this.btnStripeShowImage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.listLoopColor = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtColorToAdd = new System.Windows.Forms.TextBox();
            this.btnLoopShowImage = new System.Windows.Forms.Button();
            this.cbHexColor = new System.Windows.Forms.CheckBox();
            this.btnClearLoopList = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWidthPerLoopColor = new System.Windows.Forms.TextBox();
            this.btnOpenContainer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(17, 130);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(131, 30);
            this.btnShowImage.TabIndex = 6;
            this.btnShowImage.Text = "Convert Image";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(519, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSaveName
            // 
            this.tbSaveName.Location = new System.Drawing.Point(430, 14);
            this.tbSaveName.Name = "tbSaveName";
            this.tbSaveName.Size = new System.Drawing.Size(83, 21);
            this.tbSaveName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image Size: ";
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(96, 12);
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.Size = new System.Drawing.Size(50, 21);
            this.txtImageWidth.TabIndex = 0;
            this.txtImageWidth.Text = "1920";
            this.txtImageWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImageHeight
            // 
            this.txtImageHeight.Location = new System.Drawing.Point(170, 12);
            this.txtImageHeight.Name = "txtImageHeight";
            this.txtImageHeight.Size = new System.Drawing.Size(50, 21);
            this.txtImageHeight.TabIndex = 1;
            this.txtImageHeight.Text = "720";
            this.txtImageHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Divide:";
            // 
            // txtStartColor
            // 
            this.txtStartColor.Location = new System.Drawing.Point(98, 39);
            this.txtStartColor.Name = "txtStartColor";
            this.txtStartColor.Size = new System.Drawing.Size(50, 21);
            this.txtStartColor.TabIndex = 2;
            // 
            // txtStopColor
            // 
            this.txtStopColor.Location = new System.Drawing.Point(98, 67);
            this.txtStopColor.Name = "txtStopColor";
            this.txtStopColor.Size = new System.Drawing.Size(50, 21);
            this.txtStopColor.TabIndex = 3;
            // 
            // txtDivideNum
            // 
            this.txtDivideNum.Location = new System.Drawing.Point(98, 95);
            this.txtDivideNum.Name = "txtDivideNum";
            this.txtDivideNum.Size = new System.Drawing.Size(50, 21);
            this.txtDivideNum.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStartColor);
            this.groupBox1.Controls.Add(this.txtDivideNum);
            this.groupBox1.Controls.Add(this.txtStopColor);
            this.groupBox1.Controls.Add(this.btnShowImage);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 171);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gray Gradation (0~255)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Stop Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIncreaseShowImage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIncreaseStartColor);
            this.groupBox2.Controls.Add(this.txtIncreaseDivideNum);
            this.groupBox2.Controls.Add(this.txtIncreaseStopColor);
            this.groupBox2.Location = new System.Drawing.Point(405, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 171);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horizontal Increase (0~16777215)";
            // 
            // btnIncreaseShowImage
            // 
            this.btnIncreaseShowImage.Location = new System.Drawing.Point(17, 130);
            this.btnIncreaseShowImage.Name = "btnIncreaseShowImage";
            this.btnIncreaseShowImage.Size = new System.Drawing.Size(131, 30);
            this.btnIncreaseShowImage.TabIndex = 13;
            this.btnIncreaseShowImage.Text = "Convert Image";
            this.btnIncreaseShowImage.UseVisualStyleBackColor = true;
            this.btnIncreaseShowImage.Click += new System.EventHandler(this.btnIncreaseShowImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stop Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Divide:";
            // 
            // txtIncreaseStartColor
            // 
            this.txtIncreaseStartColor.Location = new System.Drawing.Point(85, 39);
            this.txtIncreaseStartColor.Name = "txtIncreaseStartColor";
            this.txtIncreaseStartColor.Size = new System.Drawing.Size(63, 21);
            this.txtIncreaseStartColor.TabIndex = 2;
            // 
            // txtIncreaseDivideNum
            // 
            this.txtIncreaseDivideNum.Location = new System.Drawing.Point(85, 95);
            this.txtIncreaseDivideNum.Name = "txtIncreaseDivideNum";
            this.txtIncreaseDivideNum.Size = new System.Drawing.Size(63, 21);
            this.txtIncreaseDivideNum.TabIndex = 4;
            // 
            // txtIncreaseStopColor
            // 
            this.txtIncreaseStopColor.Location = new System.Drawing.Point(85, 67);
            this.txtIncreaseStopColor.Name = "txtIncreaseStopColor";
            this.txtIncreaseStopColor.Size = new System.Drawing.Size(63, 21);
            this.txtIncreaseStopColor.TabIndex = 3;
            // 
            // rbSaveJpg
            // 
            this.rbSaveJpg.AutoSize = true;
            this.rbSaveJpg.Location = new System.Drawing.Point(323, 15);
            this.rbSaveJpg.Name = "rbSaveJpg";
            this.rbSaveJpg.Size = new System.Drawing.Size(46, 16);
            this.rbSaveJpg.TabIndex = 16;
            this.rbSaveJpg.Text = "JPG";
            this.rbSaveJpg.UseVisualStyleBackColor = true;
            // 
            // rbSaveBmp
            // 
            this.rbSaveBmp.AutoSize = true;
            this.rbSaveBmp.Checked = true;
            this.rbSaveBmp.Location = new System.Drawing.Point(267, 15);
            this.rbSaveBmp.Name = "rbSaveBmp";
            this.rbSaveBmp.Size = new System.Drawing.Size(50, 16);
            this.rbSaveBmp.TabIndex = 16;
            this.rbSaveBmp.TabStop = true;
            this.rbSaveBmp.Text = "BMP";
            this.rbSaveBmp.UseVisualStyleBackColor = true;
            // 
            // rbSavePng
            // 
            this.rbSavePng.AutoSize = true;
            this.rbSavePng.Location = new System.Drawing.Point(375, 15);
            this.rbSavePng.Name = "rbSavePng";
            this.rbSavePng.Size = new System.Drawing.Size(49, 16);
            this.rbSavePng.TabIndex = 16;
            this.rbSavePng.Text = "PNG";
            this.rbSavePng.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtStripeColor1);
            this.groupBox3.Controls.Add(this.txtStripeDivideNum);
            this.groupBox3.Controls.Add(this.txtStripeColor2);
            this.groupBox3.Controls.Add(this.btnStripeShowImage);
            this.groupBox3.Location = new System.Drawing.Point(210, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 171);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stripe Pattern (0~16777215)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "Color2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Color1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "Divide:";
            // 
            // txtStripeColor1
            // 
            this.txtStripeColor1.Location = new System.Drawing.Point(75, 39);
            this.txtStripeColor1.Name = "txtStripeColor1";
            this.txtStripeColor1.Size = new System.Drawing.Size(73, 21);
            this.txtStripeColor1.TabIndex = 2;
            // 
            // txtStripeDivideNum
            // 
            this.txtStripeDivideNum.Location = new System.Drawing.Point(75, 95);
            this.txtStripeDivideNum.Name = "txtStripeDivideNum";
            this.txtStripeDivideNum.Size = new System.Drawing.Size(73, 21);
            this.txtStripeDivideNum.TabIndex = 4;
            // 
            // txtStripeColor2
            // 
            this.txtStripeColor2.Location = new System.Drawing.Point(75, 67);
            this.txtStripeColor2.Name = "txtStripeColor2";
            this.txtStripeColor2.Size = new System.Drawing.Size(73, 21);
            this.txtStripeColor2.TabIndex = 3;
            // 
            // btnStripeShowImage
            // 
            this.btnStripeShowImage.Location = new System.Drawing.Point(17, 130);
            this.btnStripeShowImage.Name = "btnStripeShowImage";
            this.btnStripeShowImage.Size = new System.Drawing.Size(131, 30);
            this.btnStripeShowImage.TabIndex = 6;
            this.btnStripeShowImage.Text = "Convert Image";
            this.btnStripeShowImage.UseVisualStyleBackColor = true;
            this.btnStripeShowImage.Click += new System.EventHandler(this.btnStripeShowImage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearLoopList);
            this.groupBox4.Controls.Add(this.btnAddColor);
            this.groupBox4.Controls.Add(this.listLoopColor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtWidthPerLoopColor);
            this.groupBox4.Controls.Add(this.txtColorToAdd);
            this.groupBox4.Controls.Add(this.btnLoopShowImage);
            this.groupBox4.Location = new System.Drawing.Point(15, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 130);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Loop (0~16777215)";
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(160, 25);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(50, 25);
            this.btnAddColor.TabIndex = 14;
            this.btnAddColor.Text = "ADD";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // listLoopColor
            // 
            this.listLoopColor.FormattingEnabled = true;
            this.listLoopColor.ItemHeight = 12;
            this.listLoopColor.Location = new System.Drawing.Point(225, 25);
            this.listLoopColor.Name = "listLoopColor";
            this.listLoopColor.Size = new System.Drawing.Size(144, 88);
            this.listLoopColor.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "Color";
            // 
            // txtColorToAdd
            // 
            this.txtColorToAdd.Location = new System.Drawing.Point(61, 25);
            this.txtColorToAdd.Name = "txtColorToAdd";
            this.txtColorToAdd.Size = new System.Drawing.Size(88, 21);
            this.txtColorToAdd.TabIndex = 2;
            // 
            // btnLoopShowImage
            // 
            this.btnLoopShowImage.Location = new System.Drawing.Point(17, 86);
            this.btnLoopShowImage.Name = "btnLoopShowImage";
            this.btnLoopShowImage.Size = new System.Drawing.Size(193, 30);
            this.btnLoopShowImage.TabIndex = 6;
            this.btnLoopShowImage.Text = "Convert Image";
            this.btnLoopShowImage.UseVisualStyleBackColor = true;
            this.btnLoopShowImage.Click += new System.EventHandler(this.btnLoopShowImage_Click);
            // 
            // cbHexColor
            // 
            this.cbHexColor.AutoSize = true;
            this.cbHexColor.Checked = true;
            this.cbHexColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHexColor.Location = new System.Drawing.Point(416, 362);
            this.cbHexColor.Name = "cbHexColor";
            this.cbHexColor.Size = new System.Drawing.Size(155, 16);
            this.cbHexColor.TabIndex = 17;
            this.cbHexColor.Text = "Use Hex for Color Input";
            this.cbHexColor.UseVisualStyleBackColor = true;
            // 
            // btnClearLoopList
            // 
            this.btnClearLoopList.Location = new System.Drawing.Point(160, 53);
            this.btnClearLoopList.Name = "btnClearLoopList";
            this.btnClearLoopList.Size = new System.Drawing.Size(50, 25);
            this.btnClearLoopList.TabIndex = 15;
            this.btnClearLoopList.Text = "CLR";
            this.btnClearLoopList.UseVisualStyleBackColor = true;
            this.btnClearLoopList.Click += new System.EventHandler(this.btnClearLoopList_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "Width per Color";
            // 
            // txtWidthPerLoopColor
            // 
            this.txtWidthPerLoopColor.Location = new System.Drawing.Point(117, 56);
            this.txtWidthPerLoopColor.Name = "txtWidthPerLoopColor";
            this.txtWidthPerLoopColor.Size = new System.Drawing.Size(32, 21);
            this.txtWidthPerLoopColor.TabIndex = 2;
            this.txtWidthPerLoopColor.Text = "1";
            this.txtWidthPerLoopColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenContainer
            // 
            this.btnOpenContainer.Location = new System.Drawing.Point(416, 327);
            this.btnOpenContainer.Name = "btnOpenContainer";
            this.btnOpenContainer.Size = new System.Drawing.Size(155, 23);
            this.btnOpenContainer.TabIndex = 18;
            this.btnOpenContainer.Text = "Open Save Folder";
            this.btnOpenContainer.UseVisualStyleBackColor = true;
            this.btnOpenContainer.Click += new System.EventHandler(this.btnOpenContainer_Click);
            // 
            // GradationPatternGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 397);
            this.Controls.Add(this.btnOpenContainer);
            this.Controls.Add(this.cbHexColor);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rbSavePng);
            this.Controls.Add(this.rbSaveBmp);
            this.Controls.Add(this.rbSaveJpg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImageHeight);
            this.Controls.Add(this.txtImageWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSaveName);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GradationPatternGen";
            this.Text = "Custom Pattern Generator";
            this.Load += new System.EventHandler(this.ImageToArray_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowImage;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbSaveName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImageWidth;
        private System.Windows.Forms.TextBox txtImageHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartColor;
        private System.Windows.Forms.TextBox txtStopColor;
        private System.Windows.Forms.TextBox txtDivideNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIncreaseStartColor;
        private System.Windows.Forms.TextBox txtIncreaseDivideNum;
        private System.Windows.Forms.TextBox txtIncreaseStopColor;
        private System.Windows.Forms.Button btnIncreaseShowImage;
        private System.Windows.Forms.RadioButton rbSaveJpg;
        private System.Windows.Forms.RadioButton rbSaveBmp;
        private System.Windows.Forms.RadioButton rbSavePng;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStripeColor1;
        private System.Windows.Forms.TextBox txtStripeDivideNum;
        private System.Windows.Forms.TextBox txtStripeColor2;
        private System.Windows.Forms.Button btnStripeShowImage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtColorToAdd;
        private System.Windows.Forms.Button btnLoopShowImage;
        private System.Windows.Forms.ListBox listLoopColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.CheckBox cbHexColor;
        private System.Windows.Forms.Button btnClearLoopList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWidthPerLoopColor;
        private System.Windows.Forms.Button btnOpenContainer;
    }
}

