
namespace MyTour.Forms
{
    partial class DoanDuLichForm
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
            this.dataGridViewDDL = new System.Windows.Forms.DataGridView();
            this.maDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNDD = new System.Windows.Forms.DataGridView();
            this.maDoanNDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanhTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddThamQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewChiPhi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đoàn Du Lịch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewDDL
            // 
            this.dataGridViewDDL.AllowUserToAddRows = false;
            this.dataGridViewDDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDDL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoan,
            this.tenTour,
            this.ngayKhoiHanh,
            this.ngayKetThuc});
            this.dataGridViewDDL.Location = new System.Drawing.Point(23, 91);
            this.dataGridViewDDL.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDDL.Name = "dataGridViewDDL";
            this.dataGridViewDDL.RowHeadersWidth = 51;
            this.dataGridViewDDL.Size = new System.Drawing.Size(824, 231);
            this.dataGridViewDDL.TabIndex = 1;
            this.dataGridViewDDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDDL_CellClick);
            this.dataGridViewDDL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDDL_CellContentClick);
            // 
            // maDoan
            // 
            this.maDoan.HeaderText = "Mã Đoàn";
            this.maDoan.MinimumWidth = 6;
            this.maDoan.Name = "maDoan";
            this.maDoan.Width = 70;
            // 
            // tenTour
            // 
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.Width = 225;
            // 
            // ngayKhoiHanh
            // 
            this.ngayKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.ngayKhoiHanh.MinimumWidth = 6;
            this.ngayKhoiHanh.Name = "ngayKhoiHanh";
            this.ngayKhoiHanh.Width = 125;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.ngayKetThuc.MinimumWidth = 6;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Width = 125;
            // 
            // dataGridViewNDD
            // 
            this.dataGridViewNDD.AllowUserToAddRows = false;
            this.dataGridViewNDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoanNDD,
            this.hanhTrinh,
            this.khachSan,
            this.ddThamQuan});
            this.dataGridViewNDD.Location = new System.Drawing.Point(868, 91);
            this.dataGridViewNDD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNDD.Name = "dataGridViewNDD";
            this.dataGridViewNDD.RowHeadersWidth = 51;
            this.dataGridViewNDD.Size = new System.Drawing.Size(673, 231);
            this.dataGridViewNDD.TabIndex = 2;
            // 
            // maDoanNDD
            // 
            this.maDoanNDD.HeaderText = "Mã Đoàn";
            this.maDoanNDD.MinimumWidth = 6;
            this.maDoanNDD.Name = "maDoanNDD";
            this.maDoanNDD.Width = 70;
            // 
            // hanhTrinh
            // 
            this.hanhTrinh.HeaderText = "Hành Trình";
            this.hanhTrinh.MinimumWidth = 6;
            this.hanhTrinh.Name = "hanhTrinh";
            this.hanhTrinh.Width = 125;
            // 
            // khachSan
            // 
            this.khachSan.HeaderText = "Khách Sạn";
            this.khachSan.MinimumWidth = 6;
            this.khachSan.Name = "khachSan";
            this.khachSan.Width = 125;
            // 
            // ddThamQuan
            // 
            this.ddThamQuan.HeaderText = "Địa Điểm Tham Quan";
            this.ddThamQuan.MinimumWidth = 6;
            this.ddThamQuan.Name = "ddThamQuan";
            this.ddThamQuan.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(863, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội Dung Đoàn";
            // 
            // dataGridViewChiPhi
            // 
            this.dataGridViewChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiPhi.Location = new System.Drawing.Point(23, 379);
            this.dataGridViewChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewChiPhi.Name = "dataGridViewChiPhi";
            this.dataGridViewChiPhi.RowHeadersWidth = 51;
            this.dataGridViewChiPhi.Size = new System.Drawing.Size(824, 181);
            this.dataGridViewChiPhi.TabIndex = 4;
            this.dataGridViewChiPhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiPhi_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 596);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khách hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(23, 629);
            this.dataGridViewKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 51;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(1302, 201);
            this.dataGridViewKhachHang.TabIndex = 7;
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(1353, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm Khách Hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(1353, 776);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(657, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thêm Đoàn Du Lịch";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(868, 379);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 54);
            this.button4.TabIndex = 11;
            this.button4.Text = "Thêm Chi Phí";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(868, 441);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 54);
            this.button5.TabIndex = 12;
            this.button5.Text = "Xóa Chi Phí";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(1353, 691);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 54);
            this.button6.TabIndex = 13;
            this.button6.Text = "Xóa Khách Hàng";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DoanDuLichForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 883);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewKhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChiPhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewNDD);
            this.Controls.Add(this.dataGridViewDDL);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoanDuLichForm";
            this.Text = "DoanDuLich";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDDL;
        private System.Windows.Forms.DataGridView dataGridViewNDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewChiPhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoanNDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddThamQuan;
    }
}