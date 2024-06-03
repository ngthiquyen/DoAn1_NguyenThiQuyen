namespace GUI
{
    partial class GUI_ThongKe
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
            this.dgthongke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtieuchi = new System.Windows.Forms.ComboBox();
            this.btthongke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgthongke)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgthongke
            // 
            this.dgthongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgthongke.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgthongke.Location = new System.Drawing.Point(24, 25);
            this.dgthongke.Name = "dgthongke";
            this.dgthongke.RowHeadersWidth = 62;
            this.dgthongke.RowTemplate.Height = 28;
            this.dgthongke.Size = new System.Drawing.Size(941, 199);
            this.dgthongke.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgthongke);
            this.groupBox1.Location = new System.Drawing.Point(44, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thống kê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.nen2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btthoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(895, 71);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(127, 64);
            this.btthoat.TabIndex = 4;
            this.btthoat.Text = "Trở về ";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // ToDate
            // 
            this.ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(457, 135);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(239, 35);
            this.ToDate.TabIndex = 1;
            // 
            // FromDate
            // 
            this.FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(116, 135);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(224, 35);
            this.FromDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tiêu chí:";
            // 
            // cbtieuchi
            // 
            this.cbtieuchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtieuchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtieuchi.FormattingEnabled = true;
            this.cbtieuchi.Items.AddRange(new object[] {
            "Mặt hàng bán chạy nhất",
            "Số lượng hàng tồn kho"});
            this.cbtieuchi.Location = new System.Drawing.Point(253, 207);
            this.cbtieuchi.Name = "cbtieuchi";
            this.cbtieuchi.Size = new System.Drawing.Size(343, 37);
            this.cbtieuchi.TabIndex = 2;
            this.cbtieuchi.SelectedIndexChanged += new System.EventHandler(this.cbtieuchi_SelectedIndexChanged);
            // 
            // btthongke
            // 
            this.btthongke.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btthongke.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btthongke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btthongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btthongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthongke.Location = new System.Drawing.Point(684, 192);
            this.btthongke.Name = "btthongke";
            this.btthongke.Size = new System.Drawing.Size(127, 64);
            this.btthongke.TabIndex = 3;
            this.btthongke.Text = "Thống kê";
            this.btthongke.UseVisualStyleBackColor = false;
            this.btthongke.Click += new System.EventHandler(this.btthongke_Click);
            // 
            // GUI_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 608);
            this.Controls.Add(this.btthongke);
            this.Controls.Add(this.cbtieuchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_ThongKe";
            this.Text = "Quản lý thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgthongke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgthongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtieuchi;
        private System.Windows.Forms.Button btthongke;
    }
}