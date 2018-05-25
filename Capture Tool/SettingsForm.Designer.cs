namespace Capture_Tool
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShowWord = new System.Windows.Forms.CheckBox();
            this.cbSaveWord = new System.Windows.Forms.CheckBox();
            this.cbAddTitle = new System.Windows.Forms.CheckBox();
            this.cbAddCaption = new System.Windows.Forms.CheckBox();
            this.cbSavePDF = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutputPath = new System.Windows.Forms.TextBox();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScreenshotPath = new System.Windows.Forms.TextBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSavePNG = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSavePDF);
            this.groupBox1.Controls.Add(this.cbAddCaption);
            this.groupBox1.Controls.Add(this.cbAddTitle);
            this.groupBox1.Controls.Add(this.cbSaveWord);
            this.groupBox1.Controls.Add(this.cbShowWord);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MS Word";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpen2);
            this.groupBox2.Controls.Add(this.tbScreenshotPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnOpen1);
            this.groupBox2.Controls.Add(this.tbOutputPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path";
            // 
            // cbShowWord
            // 
            this.cbShowWord.AutoSize = true;
            this.cbShowWord.Location = new System.Drawing.Point(7, 20);
            this.cbShowWord.Name = "cbShowWord";
            this.cbShowWord.Size = new System.Drawing.Size(82, 17);
            this.cbShowWord.TabIndex = 0;
            this.cbShowWord.Text = "Show Word";
            this.cbShowWord.UseVisualStyleBackColor = true;
            this.cbShowWord.Click += new System.EventHandler(this.ShowWord_Click);
            // 
            // cbSaveWord
            // 
            this.cbSaveWord.AutoSize = true;
            this.cbSaveWord.Location = new System.Drawing.Point(7, 44);
            this.cbSaveWord.Name = "cbSaveWord";
            this.cbSaveWord.Size = new System.Drawing.Size(80, 17);
            this.cbSaveWord.TabIndex = 1;
            this.cbSaveWord.Text = "Save Word";
            this.cbSaveWord.UseVisualStyleBackColor = true;
            this.cbSaveWord.Click += new System.EventHandler(this.SaveWord_Click);
            // 
            // cbAddTitle
            // 
            this.cbAddTitle.AutoSize = true;
            this.cbAddTitle.Location = new System.Drawing.Point(134, 20);
            this.cbAddTitle.Name = "cbAddTitle";
            this.cbAddTitle.Size = new System.Drawing.Size(68, 17);
            this.cbAddTitle.TabIndex = 2;
            this.cbAddTitle.Text = "Add Title";
            this.cbAddTitle.UseVisualStyleBackColor = true;
            this.cbAddTitle.Click += new System.EventHandler(this.AddTitle_Click);
            // 
            // cbAddCaption
            // 
            this.cbAddCaption.AutoSize = true;
            this.cbAddCaption.Location = new System.Drawing.Point(134, 44);
            this.cbAddCaption.Name = "cbAddCaption";
            this.cbAddCaption.Size = new System.Drawing.Size(84, 17);
            this.cbAddCaption.TabIndex = 3;
            this.cbAddCaption.Text = "Add Caption";
            this.cbAddCaption.UseVisualStyleBackColor = true;
            this.cbAddCaption.Click += new System.EventHandler(this.AddCaption_Click);
            // 
            // cbSavePDF
            // 
            this.cbSavePDF.AutoSize = true;
            this.cbSavePDF.Location = new System.Drawing.Point(7, 67);
            this.cbSavePDF.Name = "cbSavePDF";
            this.cbSavePDF.Size = new System.Drawing.Size(75, 17);
            this.cbSavePDF.TabIndex = 4;
            this.cbSavePDF.Text = "Save PDF";
            this.cbSavePDF.UseVisualStyleBackColor = true;
            this.cbSavePDF.Click += new System.EventHandler(this.SavePDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word/PDF/PNG Output Path";
            // 
            // tbOutputPath
            // 
            this.tbOutputPath.Location = new System.Drawing.Point(10, 37);
            this.tbOutputPath.Name = "tbOutputPath";
            this.tbOutputPath.Size = new System.Drawing.Size(181, 20);
            this.tbOutputPath.TabIndex = 1;
            // 
            // btnOpen1
            // 
            this.btnOpen1.Location = new System.Drawing.Point(197, 35);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(41, 23);
            this.btnOpen1.TabIndex = 2;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.SelectOutputPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Screenshot Path";
            // 
            // tbScreenshotPath
            // 
            this.tbScreenshotPath.Location = new System.Drawing.Point(10, 81);
            this.tbScreenshotPath.Name = "tbScreenshotPath";
            this.tbScreenshotPath.Size = new System.Drawing.Size(181, 20);
            this.tbScreenshotPath.TabIndex = 4;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Location = new System.Drawing.Point(197, 78);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(41, 23);
            this.btnOpen2.TabIndex = 5;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.SelectScreenshotPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSavePNG);
            this.groupBox3.Location = new System.Drawing.Point(13, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image";
            // 
            // cbSavePNG
            // 
            this.cbSavePNG.AutoSize = true;
            this.cbSavePNG.Location = new System.Drawing.Point(12, 20);
            this.cbSavePNG.Name = "cbSavePNG";
            this.cbSavePNG.Size = new System.Drawing.Size(77, 17);
            this.cbSavePNG.TabIndex = 0;
            this.cbSavePNG.Text = "Save PNG";
            this.cbSavePNG.UseVisualStyleBackColor = true;
            this.cbSavePNG.Click += new System.EventHandler(this.SavePNG_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(91, 286);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 319);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSaveWord;
        private System.Windows.Forms.CheckBox cbShowWord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAddCaption;
        private System.Windows.Forms.CheckBox cbAddTitle;
        private System.Windows.Forms.CheckBox cbSavePDF;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TextBox tbOutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.TextBox tbScreenshotPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSavePNG;
        private System.Windows.Forms.Button btnReset;
    }
}