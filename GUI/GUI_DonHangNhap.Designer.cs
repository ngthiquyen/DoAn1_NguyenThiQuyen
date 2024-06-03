namespace GUI
{
    partial class GUI_DonHangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadhn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttongtt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.cbtenncc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbtennv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnmoi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntkdhn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgdhn = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdhn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(27, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(27, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhập:";
            // 
            // txtmadhn
            // 
            this.txtmadhn.Location = new System.Drawing.Point(179, 29);
            this.txtmadhn.Name = "txtmadhn";
            this.txtmadhn.Size = new System.Drawing.Size(272, 26);
            this.txtmadhn.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txttongtt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmancc);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.cbtenncc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbtennv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtngaynhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmadhn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 345);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng nhập";
            // 
            // txttongtt
            // 
            this.txttongtt.Enabled = false;
            this.txttongtt.Location = new System.Drawing.Point(179, 282);
            this.txttongtt.Name = "txttongtt";
            this.txttongtt.Size = new System.Drawing.Size(272, 26);
            this.txttongtt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(27, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tổng thanh toán:";
            // 
            // txtmancc
            // 
            this.txtmancc.Enabled = false;
            this.txtmancc.Location = new System.Drawing.Point(179, 196);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(272, 26);
            this.txtmancc.TabIndex = 4;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(179, 108);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(272, 26);
            this.txtmanv.TabIndex = 2;
            // 
            // cbtenncc
            // 
            this.cbtenncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtenncc.FormattingEnabled = true;
            this.cbtenncc.Location = new System.Drawing.Point(179, 150);
            this.cbtenncc.Name = "cbtenncc";
            this.cbtenncc.Size = new System.Drawing.Size(272, 28);
            this.cbtenncc.TabIndex = 3;
            this.cbtenncc.SelectedIndexChanged += new System.EventHandler(this.cbtenncc_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Location = new System.Drawing.Point(27, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tên nhà cung cấp:";
            // 
            // cbtennv
            // 
            this.cbtennv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtennv.FormattingEnabled = true;
            this.cbtennv.Location = new System.Drawing.Point(179, 66);
            this.cbtennv.Name = "cbtennv";
            this.cbtennv.Size = new System.Drawing.Size(272, 28);
            this.cbtennv.TabIndex = 1;
            this.cbtennv.SelectedIndexChanged += new System.EventHandler(this.cbtennv_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(27, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên nhân viên:";
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Enabled = false;
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaynhap.Location = new System.Drawing.Point(179, 242);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(272, 26);
            this.dtngaynhap.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox3.Controls.Add(this.btnmoi);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Location = new System.Drawing.Point(570, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 167);
            this.groupBox3.TabIndex = 9;
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
            this.btnmoi.Location = new System.Drawing.Point(51, 39);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(113, 42);
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
            this.btnsua.Location = new System.Drawing.Point(359, 39);
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
            this.btnthoat.Location = new System.Drawing.Point(284, 99);
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
            this.btnxoa.Location = new System.Drawing.Point(120, 99);
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
            this.btnthem.Location = new System.Drawing.Point(203, 39);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(125, 42);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.btntkdhn);
            this.groupBox2.Location = new System.Drawing.Point(570, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 149);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiêu chí tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(137, 45);
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
            // dgdhn
            // 
            this.dgdhn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdhn.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgdhn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdhn.Location = new System.Drawing.Point(48, 459);
            this.dgdhn.Name = "dgdhn";
            this.dgdhn.RowHeadersWidth = 62;
            this.dgdhn.RowTemplate.Height = 28;
            this.dgdhn.Size = new System.Drawing.Size(1055, 234);
            this.dgdhn.TabIndex = 10;
            this.dgdhn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdhn_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.nen2;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 794);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_DonHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1157, 783);
            this.Controls.Add(this.dgdhn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_DonHangNhap";
            this.Text = "Quản lý Đơn hàng nhập";
            this.Load += new System.EventHandler(this.GUI_DonHangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdhn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmadhn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntkdhn;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgdhn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ComboBox cbtenncc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbtennv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttongtt;
        private System.Windows.Forms.Label label7;
    }
}