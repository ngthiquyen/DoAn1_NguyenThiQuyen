namespace GUI
{
    partial class GUI_ChiTietDHN
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
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtslnhap = new System.Windows.Forms.TextBox();
            this.cbtenmh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmadhn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntkdhn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgctdhn = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgctdhn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txtmamh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.txtslnhap);
            this.groupBox1.Controls.Add(this.cbtenmh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbmadhn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 343);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chi tiết đơn hàng nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmamh
            // 
            this.txtmamh.Enabled = false;
            this.txtmamh.Location = new System.Drawing.Point(186, 123);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(272, 26);
            this.txtmamh.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Location = new System.Drawing.Point(34, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã mặt hàng:";
            // 
            // txttongtien
            // 
            this.txttongtien.Enabled = false;
            this.txttongtien.Location = new System.Drawing.Point(186, 281);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(272, 26);
            this.txttongtien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(34, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thành tiền:";
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(186, 227);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(272, 26);
            this.txtgianhap.TabIndex = 4;
            // 
            // txtslnhap
            // 
            this.txtslnhap.Location = new System.Drawing.Point(186, 170);
            this.txtslnhap.Name = "txtslnhap";
            this.txtslnhap.Size = new System.Drawing.Size(272, 26);
            this.txtslnhap.TabIndex = 3;
            // 
            // cbtenmh
            // 
            this.cbtenmh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtenmh.FormattingEnabled = true;
            this.cbtenmh.Location = new System.Drawing.Point(186, 70);
            this.cbtenmh.Name = "cbtenmh";
            this.cbtenmh.Size = new System.Drawing.Size(272, 28);
            this.cbtenmh.TabIndex = 1;
            this.cbtenmh.SelectedIndexChanged += new System.EventHandler(this.cbtenmh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(34, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá nhập:";
            // 
            // cbmadhn
            // 
            this.cbmadhn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmadhn.FormattingEnabled = true;
            this.cbmadhn.Location = new System.Drawing.Point(186, 25);
            this.cbmadhn.Name = "cbmadhn";
            this.cbmadhn.Size = new System.Drawing.Size(272, 28);
            this.cbmadhn.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(34, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mặt hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.btntkdhn);
            this.groupBox2.Location = new System.Drawing.Point(565, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 149);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiêu chí tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(129, 48);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(272, 26);
            this.txttimkiem.TabIndex = 0;
            // 
            // btntkdhn
            // 
            this.btntkdhn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btntkdhn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btntkdhn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btntkdhn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btntkdhn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntkdhn.Location = new System.Drawing.Point(203, 89);
            this.btntkdhn.Name = "btntkdhn";
            this.btntkdhn.Size = new System.Drawing.Size(125, 42);
            this.btntkdhn.TabIndex = 1;
            this.btntkdhn.Text = "Tìm kiếm";
            this.btntkdhn.UseVisualStyleBackColor = false;
            this.btntkdhn.Click += new System.EventHandler(this.btntkdhn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.btnmoi);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Location = new System.Drawing.Point(565, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 167);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnmoi
            // 
            this.btnmoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnmoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnmoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmoi.Location = new System.Drawing.Point(58, 35);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(107, 42);
            this.btnmoi.TabIndex = 0;
            this.btnmoi.Text = "Làm mới";
            this.btnmoi.UseVisualStyleBackColor = false;
            this.btnmoi.Click += new System.EventHandler(this.btnmoi_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Location = new System.Drawing.Point(359, 35);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(125, 42);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnthoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Location = new System.Drawing.Point(289, 99);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(125, 42);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnxoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Location = new System.Drawing.Point(129, 99);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(125, 42);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnthem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Location = new System.Drawing.Point(203, 35);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(125, 42);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgctdhn
            // 
            this.dgctdhn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgctdhn.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgctdhn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgctdhn.Location = new System.Drawing.Point(29, 445);
            this.dgctdhn.Name = "dgctdhn";
            this.dgctdhn.RowHeadersWidth = 62;
            this.dgctdhn.RowTemplate.Height = 28;
            this.dgctdhn.Size = new System.Drawing.Size(1069, 234);
            this.dgctdhn.TabIndex = 12;
            this.dgctdhn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgctdhn_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.nen2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 770);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_ChiTietDHN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1146, 740);
            this.Controls.Add(this.dgctdhn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_ChiTietDHN";
            this.Text = "Quản lý chi tiết đơn hàng nhập";
            this.Load += new System.EventHandler(this.GUI_ChiTietDHN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgctdhn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmadhn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntkdhn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgctdhn;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtslnhap;
        private System.Windows.Forms.ComboBox cbtenmh;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtmamh;
        private System.Windows.Forms.Label label6;
    }
}