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
            this.label5 = new System.Windows.Forms.Label();
            this.txtDivideNum = new System.Windows.Forms.TextBox();
            this.cbStripes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(236, 10);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(75, 75);
            this.btnShowImage.TabIndex = 6;
            this.btnShowImage.Text = "Convert Image";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSaveName
            // 
            this.tbSaveName.Location = new System.Drawing.Point(15, 109);
            this.tbSaveName.Name = "tbSaveName";
            this.tbSaveName.Size = new System.Drawing.Size(216, 21);
            this.tbSaveName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image Size: ";
            // 
            // txtImageWidth
            // 
            this.txtImageWidth.Location = new System.Drawing.Point(96, 10);
            this.txtImageWidth.Name = "txtImageWidth";
            this.txtImageWidth.Size = new System.Drawing.Size(50, 21);
            this.txtImageWidth.TabIndex = 0;
            // 
            // txtImageHeight
            // 
            this.txtImageHeight.Location = new System.Drawing.Point(169, 10);
            this.txtImageHeight.Name = "txtImageHeight";
            this.txtImageHeight.Size = new System.Drawing.Size(50, 21);
            this.txtImageHeight.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Divide:";
            // 
            // txtStartColor
            // 
            this.txtStartColor.Location = new System.Drawing.Point(96, 37);
            this.txtStartColor.Name = "txtStartColor";
            this.txtStartColor.Size = new System.Drawing.Size(50, 21);
            this.txtStartColor.TabIndex = 2;
            // 
            // txtStopColor
            // 
            this.txtStopColor.Location = new System.Drawing.Point(169, 37);
            this.txtStopColor.Name = "txtStopColor";
            this.txtStopColor.Size = new System.Drawing.Size(50, 21);
            this.txtStopColor.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // txtDivideNum
            // 
            this.txtDivideNum.Location = new System.Drawing.Point(96, 64);
            this.txtDivideNum.Name = "txtDivideNum";
            this.txtDivideNum.Size = new System.Drawing.Size(50, 21);
            this.txtDivideNum.TabIndex = 4;
            // 
            // cbStripes
            // 
            this.cbStripes.AutoSize = true;
            this.cbStripes.Location = new System.Drawing.Point(157, 66);
            this.cbStripes.Name = "cbStripes";
            this.cbStripes.Size = new System.Drawing.Size(62, 16);
            this.cbStripes.TabIndex = 5;
            this.cbStripes.Text = "stripes";
            this.cbStripes.UseVisualStyleBackColor = true;
            this.cbStripes.CheckedChanged += new System.EventHandler(this.cbStripes_CheckedChanged);
            // 
            // GradationPatternGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 142);
            this.Controls.Add(this.cbStripes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImageHeight);
            this.Controls.Add(this.txtStopColor);
            this.Controls.Add(this.txtDivideNum);
            this.Controls.Add(this.txtStartColor);
            this.Controls.Add(this.txtImageWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSaveName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GradationPatternGen";
            this.Text = "Gradation Pattern Generator";
            this.Load += new System.EventHandler(this.ImageToArray_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDivideNum;
        private System.Windows.Forms.CheckBox cbStripes;
    }
}

