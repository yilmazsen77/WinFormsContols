namespace WinFormsContols.Dialog_boxes
{
    partial class Font_and_Color
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 236);
            this.textBox1.TabIndex = 0;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(151, 281);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(120, 23);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "EDIT FONT";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(393, 281);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(122, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "EDIT COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Font_and_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 335);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.textBox1);
            this.Name = "Font_and_Color";
            this.Text = "Font_and_Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColor;
    }
}