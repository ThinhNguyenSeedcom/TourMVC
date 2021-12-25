
namespace MyTour.Forms
{
    partial class DiaDiemForm
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
            this.dataGridViewDiaDiem = new System.Windows.Forms.DataGridView();
            this.maDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuThuDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaDiaDiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxThuTu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewDsdd = new System.Windows.Forms.DataGridView();
            this.madd_DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendd_DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaDD_DSDD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTenDD_DSDD = new System.Windows.Forms.TextBox();
            this.textBoxTenDiaDiemT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa Điểm Của Tour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewDiaDiem
            // 
            this.dataGridViewDiaDiem.AllowUserToAddRows = false;
            this.dataGridViewDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiaDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDiaDiem,
            this.tenDiaDiem,
            this.thuThuDD});
            this.dataGridViewDiaDiem.Location = new System.Drawing.Point(21, 52);
            this.dataGridViewDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDiaDiem.Name = "dataGridViewDiaDiem";
            this.dataGridViewDiaDiem.RowHeadersWidth = 51;
            this.dataGridViewDiaDiem.Size = new System.Drawing.Size(593, 211);
            this.dataGridViewDiaDiem.TabIndex = 1;
            this.dataGridViewDiaDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiaDiem_CellClick);
            // 
            // maDiaDiem
            // 
            this.maDiaDiem.HeaderText = "Mã Địa Điểm ";
            this.maDiaDiem.MinimumWidth = 6;
            this.maDiaDiem.Name = "maDiaDiem";
            this.maDiaDiem.Width = 125;
            // 
            // tenDiaDiem
            // 
            this.tenDiaDiem.HeaderText = "Tên Địa Điểm";
            this.tenDiaDiem.MinimumWidth = 6;
            this.tenDiaDiem.Name = "tenDiaDiem";
            this.tenDiaDiem.Width = 200;
            // 
            // thuThuDD
            // 
            this.thuThuDD.HeaderText = "Thứ Tự";
            this.thuThuDD.MinimumWidth = 6;
            this.thuThuDD.Name = "thuThuDD";
            this.thuThuDD.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Địa Điểm";
            // 
            // textBoxMaDiaDiem
            // 
            this.textBoxMaDiaDiem.Location = new System.Drawing.Point(751, 52);
            this.textBoxMaDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaDiaDiem.Name = "textBoxMaDiaDiem";
            this.textBoxMaDiaDiem.Size = new System.Drawing.Size(284, 22);
            this.textBoxMaDiaDiem.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(751, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm Địa Điểm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thứ Tự";
            // 
            // textBoxThuTu
            // 
            this.textBoxThuTu.HideSelection = false;
            this.textBoxThuTu.Location = new System.Drawing.Point(751, 167);
            this.textBoxThuTu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxThuTu.Name = "textBoxThuTu";
            this.textBoxThuTu.Size = new System.Drawing.Size(283, 22);
            this.textBoxThuTu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(20, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Danh sách địa điểm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridViewDsdd
            // 
            this.dataGridViewDsdd.AllowUserToAddRows = false;
            this.dataGridViewDsdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDsdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madd_DiaDiem,
            this.tendd_DiaDiem});
            this.dataGridViewDsdd.Location = new System.Drawing.Point(25, 341);
            this.dataGridViewDsdd.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDsdd.Name = "dataGridViewDsdd";
            this.dataGridViewDsdd.RowHeadersWidth = 51;
            this.dataGridViewDsdd.Size = new System.Drawing.Size(589, 228);
            this.dataGridViewDsdd.TabIndex = 10;
            this.dataGridViewDsdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsdd_CellClick);
            this.dataGridViewDsdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDsdd_CellContentClick);
            // 
            // madd_DiaDiem
            // 
            this.madd_DiaDiem.HeaderText = "Mã Địa Điểm";
            this.madd_DiaDiem.MinimumWidth = 6;
            this.madd_DiaDiem.Name = "madd_DiaDiem";
            this.madd_DiaDiem.Width = 125;
            // 
            // tendd_DiaDiem
            // 
            this.tendd_DiaDiem.HeaderText = "Tên Địa Điểm ";
            this.tendd_DiaDiem.MinimumWidth = 6;
            this.tendd_DiaDiem.Name = "tendd_DiaDiem";
            this.tendd_DiaDiem.Width = 295;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(640, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 64);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm địa điểm mới vào dsdd";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã địa điểm";
            // 
            // textBoxMaDD_DSDD
            // 
            this.textBoxMaDD_DSDD.Location = new System.Drawing.Point(640, 373);
            this.textBoxMaDD_DSDD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaDD_DSDD.Name = "textBoxMaDD_DSDD";
            this.textBoxMaDD_DSDD.Size = new System.Drawing.Size(394, 22);
            this.textBoxMaDD_DSDD.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 417);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tên Địa Điểm";
            // 
            // textBoxTenDD_DSDD
            // 
            this.textBoxTenDD_DSDD.Location = new System.Drawing.Point(640, 450);
            this.textBoxTenDD_DSDD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenDD_DSDD.Name = "textBoxTenDD_DSDD";
            this.textBoxTenDD_DSDD.Size = new System.Drawing.Size(394, 22);
            this.textBoxTenDD_DSDD.TabIndex = 15;
            // 
            // textBoxTenDiaDiemT
            // 
            this.textBoxTenDiaDiemT.Location = new System.Drawing.Point(751, 109);
            this.textBoxTenDiaDiemT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenDiaDiemT.Name = "textBoxTenDiaDiemT";
            this.textBoxTenDiaDiemT.Size = new System.Drawing.Size(284, 22);
            this.textBoxTenDiaDiemT.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên Đia Điểm";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(915, 208);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 55);
            this.button3.TabIndex = 18;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DiaDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 612);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTenDiaDiemT);
            this.Controls.Add(this.textBoxTenDD_DSDD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMaDD_DSDD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewDsdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxThuTu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMaDiaDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDiaDiem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiaDiemForm";
            this.Text = "DiaDiemForm";
            this.Load += new System.EventHandler(this.DiaDiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDsdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDiaDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaDiaDiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxThuTu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewDsdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaDD_DSDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTenDD_DSDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuThuDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn madd_DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendd_DiaDiem;
        private System.Windows.Forms.TextBox textBoxTenDiaDiemT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}