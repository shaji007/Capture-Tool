namespace Capture_Tool
{
    partial class AddCaption
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.AcceptsReturn = true;
            this.tbData.Location = new System.Drawing.Point(13, 30);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(347, 20);
            this.tbData.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(285, 62);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(13, 9);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(152, 13);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "Add Caption to the Screenshot";
            // 
            // AddCaption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 94);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCaption";
            this.Text = "AddCaption";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbText;
    }
}