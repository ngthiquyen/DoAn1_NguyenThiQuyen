namespace GUI
{
    partial class GUI_DangNhap
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
            this.Btntrove = new System.Windows.Forms.Button();
            this.Btndangnhap = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbquyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btntrove
            // 
            this.Btntrove.BackColor = System.Drawing.Color.Silver;
            this.Btntrove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btntrove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btntrove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btntrove.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btntrove.Location = new System.Drawing.Point(1032, 518);
            this.Btntrove.Name = "Btntrove";
            this.Btntrove.Size = new System.Drawing.Size(147, 60);
            this.Btntrove.TabIndex = 4;
            this.Btntrove.Text = "Thoát";
            this.Btntrove.UseVisualStyleBackColor = false;
            this.Btntrove.Click += new System.EventHandler(this.Btntrove_Click_1);
            // 
            // Btndangnhap
            // 
            this.Btndangnhap.BackColor = System.Drawing.Color.Silver;
            this.Btndangnhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btndangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndangnhap.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btndangnhap.Location = new System.Drawing.Point(819, 518);
            this.Btndangnhap.Name = "Btndangnhap";
            this.Btndangnhap.Size = new System.Drawing.Size(149, 60);
            this.Btndangnhap.TabIndex = 3;
            this.Btndangnhap.Text = "Đăng nhập\r\n";
            this.Btndangnhap.UseVisualStyleBackColor = false;
            this.Btndangnhap.Click += new System.EventHandler(this.Btndangnhap_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(992, 336);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(229, 40);
            this.txtmatkhau.TabIndex = 1;
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdangnhap.Location = new System.Drawing.Point(992, 250);
            this.txtdangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(229, 40);
            this.txtdangnhap.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Screenshot_2024_05_25_163256;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1259, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbquyen
            // 
            this.cbquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbquyen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbquyen.FormattingEnabled = true;
            this.cbquyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cbquyen.Location = new System.Drawing.Point(992, 424);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Size = new System.Drawing.Size(229, 41);
            this.cbquyen.TabIndex = 2;
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 699);
            this.Controls.Add(this.cbquyen);
            this.Controls.Add(this.Btntrove);
            this.Controls.Add(this.Btndangnhap);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtdangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_DangNhap";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btntrove;
        private System.Windows.Forms.Button Btndangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.ComboBox cbquyen;
    }
}