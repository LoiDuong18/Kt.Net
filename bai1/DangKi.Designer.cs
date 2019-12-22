namespace bai1
{
    partial class DangKi
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
            this.label1 = new System.Windows.Forms.Label();
            this.themMaSV = new System.Windows.Forms.TextBox();
            this.huySV = new System.Windows.Forms.Button();
            this.dangKiSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // themMaSV
            // 
            this.themMaSV.Location = new System.Drawing.Point(137, 37);
            this.themMaSV.Name = "themMaSV";
            this.themMaSV.Size = new System.Drawing.Size(200, 22);
            this.themMaSV.TabIndex = 1;
            // 
            // huySV
            // 
            this.huySV.Location = new System.Drawing.Point(246, 109);
            this.huySV.Name = "huySV";
            this.huySV.Size = new System.Drawing.Size(105, 55);
            this.huySV.TabIndex = 2;
            this.huySV.Text = "Hủy";
            this.huySV.UseVisualStyleBackColor = true;
            this.huySV.Click += new System.EventHandler(this.huySV_Click);
            // 
            // dangKiSV
            // 
            this.dangKiSV.Location = new System.Drawing.Point(45, 109);
            this.dangKiSV.Name = "dangKiSV";
            this.dangKiSV.Size = new System.Drawing.Size(105, 55);
            this.dangKiSV.TabIndex = 2;
            this.dangKiSV.Text = "Đăng Kí";
            this.dangKiSV.UseVisualStyleBackColor = true;
            this.dangKiSV.Click += new System.EventHandler(this.dangKiSV_Click);
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.dangKiSV);
            this.Controls.Add(this.huySV);
            this.Controls.Add(this.themMaSV);
            this.Controls.Add(this.label1);
            this.Name = "DangKi";
            this.Text = "DangKi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox themMaSV;
        private System.Windows.Forms.Button huySV;
        private System.Windows.Forms.Button dangKiSV;
    }
}