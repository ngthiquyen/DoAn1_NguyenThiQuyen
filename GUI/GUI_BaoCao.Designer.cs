namespace GUI
{
    partial class GUI_BaoCao
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
            this.dgbaocao = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.btbaocao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtban = new System.Windows.Forms.TextBox();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.txtlai = new System.Windows.Forms.TextBox();
            this.txtslban = new System.Windows.Forms.TextBox();
            this.txtslnhap = new System.Windows.Forms.TextBox();
            this.bttrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbaocao
            // 
            this.dgbaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbaocao.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgbaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbaocao.Location = new System.Drawing.Point(54, 192);
            this.dgbaocao.Name = "dgbaocao";
            this.dgbaocao.RowHeadersWidth = 62;
            this.dgbaocao.RowTemplate.Height = 28;
            this.dgbaocao.Size = new System.Drawing.Size(914, 222);
            this.dgbaocao.TabIndex = 1;
            this.dgbaocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbaocao_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.nen2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày:";
            // 
            // FromDate
            // 
            this.FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(86, 126);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(224, 35);
            this.FromDate.TabIndex = 0;
            // 
            // ToDate
            // 
            this.ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(427, 126);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(239, 35);
            this.ToDate.TabIndex = 1;
            // 
            // btbaocao
            // 
            this.btbaocao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btbaocao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btbaocao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btbaocao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btbaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbaocao.Location = new System.Drawing.Point(705, 112);
            this.btbaocao.Name = "btbaocao";
            this.btbaocao.Size = new System.Drawing.Size(135, 66);
            this.btbaocao.TabIndex = 2;
            this.btbaocao.Text = "Báo cáo";
            this.btbaocao.UseVisualStyleBackColor = false;
            this.btbaocao.Click += new System.EventHandler(this.btbaocao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(733, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng lãi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng hóa đơn bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số lượng hóa đơn nhập:";
            // 
            // txtban
            // 
            this.txtban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtban.Location = new System.Drawing.Point(191, 441);
            this.txtban.Name = "txtban";
            this.txtban.Size = new System.Drawing.Size(165, 35);
            this.txtban.TabIndex = 13;
            // 
            // txtnhap
            // 
            this.txtnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhap.Location = new System.Drawing.Point(530, 444);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(165, 35);
            this.txtnhap.TabIndex = 14;
            // 
            // txtlai
            // 
            this.txtlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlai.Location = new System.Drawing.Point(846, 447);
            this.txtlai.Name = "txtlai";
            this.txtlai.Size = new System.Drawing.Size(165, 35);
            this.txtlai.TabIndex = 15;
            // 
            // txtslban
            // 
            this.txtslban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtslban.Location = new System.Drawing.Point(335, 508);
            this.txtslban.Name = "txtslban";
            this.txtslban.Size = new System.Drawing.Size(165, 35);
            this.txtslban.TabIndex = 16;
            // 
            // txtslnhap
            // 
            this.txtslnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtslnhap.Location = new System.Drawing.Point(822, 505);
            this.txtslnhap.Name = "txtslnhap";
            this.txtslnhap.Size = new System.Drawing.Size(165, 35);
            this.txtslnhap.TabIndex = 17;
            // 
            // bttrove
            // 
            this.bttrove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bttrove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttrove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttrove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttrove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttrove.Location = new System.Drawing.Point(888, 112);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(135, 66);
            this.bttrove.TabIndex = 3;
            this.bttrove.Text = "Trở về";
            this.bttrove.UseVisualStyleBackColor = false;
            this.bttrove.Click += new System.EventHandler(this.bttrove_Click);
            // 
            // GUI_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 641);
            this.Controls.Add(this.bttrove);
            this.Controls.Add(this.txtslnhap);
            this.Controls.Add(this.txtslban);
            this.Controls.Add(this.txtlai);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.txtban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbaocao);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgbaocao);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_BaoCao";
            this.Text = "Báo cáo doanh thu ";
            ((System.ComponentModel.ISupportInitialize)(this.dgbaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgbaocao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Button btbaocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtban;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.TextBox txtlai;
        private System.Windows.Forms.TextBox txtslban;
        private System.Windows.Forms.TextBox txtslnhap;
        private System.Windows.Forms.Button bttrove;
    }
}