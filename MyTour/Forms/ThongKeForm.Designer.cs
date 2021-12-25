
namespace MyTour.Forms
{
    partial class ThongKeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelSoLuongKhacHang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTongChiPhiCuaDoan = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelSoLuongTour = new System.Windows.Forms.Label();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTongGiaTour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSoLuongDoanThamGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelChiPhi = new System.Windows.Forms.Label();
            this.dataGridViewTourDuLich = new System.Windows.Forms.DataGridView();
            this.maTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTourThongKeTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tongSoLuongDoanThamGia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1SoLuongTourThongKe = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSoLuongDiaDiemThamQuan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lableLoiNhuan = new System.Windows.Forms.Label();
            this.dateTimePickerStartDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDay = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê Đoàn Du Lịch";
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
            this.dataGridViewDDL.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewDDL.Name = "dataGridViewDDL";
            this.dataGridViewDDL.RowHeadersWidth = 51;
            this.dataGridViewDDL.Size = new System.Drawing.Size(598, 209);
            this.dataGridViewDDL.TabIndex = 1;
            this.dataGridViewDDL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDDL_CellClick);
            // 
            // maDoan
            // 
            this.maDoan.HeaderText = "Mã Đoàn";
            this.maDoan.MinimumWidth = 6;
            this.maDoan.Name = "maDoan";
            this.maDoan.Width = 125;
            // 
            // tenTour
            // 
            this.tenTour.HeaderText = "Tên Tour";
            this.tenTour.MinimumWidth = 6;
            this.tenTour.Name = "tenTour";
            this.tenTour.Width = 150;
            // 
            // ngayKhoiHanh
            // 
            this.ngayKhoiHanh.HeaderText = "Ngày Khởi Hành";
            this.ngayKhoiHanh.MinimumWidth = 6;
            this.ngayKhoiHanh.Name = "ngayKhoiHanh";
            this.ngayKhoiHanh.Width = 150;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.ngayKetThuc.MinimumWidth = 6;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Lượng Khách Hàng Trong Đoàn:";
            // 
            // labelSoLuongKhacHang
            // 
            this.labelSoLuongKhacHang.AutoSize = true;
            this.labelSoLuongKhacHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongKhacHang.Location = new System.Drawing.Point(948, 108);
            this.labelSoLuongKhacHang.Name = "labelSoLuongKhacHang";
            this.labelSoLuongKhacHang.Size = new System.Drawing.Size(0, 25);
            this.labelSoLuongKhacHang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng Chi Phí Của Đoàn:";
            // 
            // labelTongChiPhiCuaDoan
            // 
            this.labelTongChiPhiCuaDoan.AutoSize = true;
            this.labelTongChiPhiCuaDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongChiPhiCuaDoan.Location = new System.Drawing.Point(948, 150);
            this.labelTongChiPhiCuaDoan.Name = "labelTongChiPhiCuaDoan";
            this.labelTongChiPhiCuaDoan.Size = new System.Drawing.Size(0, 25);
            this.labelTongChiPhiCuaDoan.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(616, 193);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 25);
            this.label.TabIndex = 6;
            this.label.Text = "Giá Tour:";
            // 
            // labelSoLuongTour
            // 
            this.labelSoLuongTour.AutoSize = true;
            this.labelSoLuongTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongTour.Location = new System.Drawing.Point(948, 193);
            this.labelSoLuongTour.Name = "labelSoLuongTour";
            this.labelSoLuongTour.Size = new System.Drawing.Size(0, 25);
            this.labelSoLuongTour.TabIndex = 7;
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.AllowUserToAddRows = false;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.tenKH,
            this.sdt});
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(12, 368);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 51;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(598, 209);
            this.dataGridViewKhachHang.TabIndex = 8;
            this.dataGridViewKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhachHang_CellClick);
            this.dataGridViewKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maKH
            // 
            this.maKH.Frozen = true;
            this.maKH.HeaderText = "Mã Khách Hàng";
            this.maKH.MinimumWidth = 6;
            this.maKH.Name = "maKH";
            this.maKH.Width = 150;
            // 
            // tenKH
            // 
            this.tenKH.HeaderText = "Tên Khách Hàng";
            this.tenKH.MinimumWidth = 6;
            this.tenKH.Name = "tenKH";
            this.tenKH.Width = 250;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thống kê Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doanh Thu";
            // 
            // labelTongGiaTour
            // 
            this.labelTongGiaTour.AutoSize = true;
            this.labelTongGiaTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongGiaTour.Location = new System.Drawing.Point(948, 232);
            this.labelTongGiaTour.Name = "labelTongGiaTour";
            this.labelTongGiaTour.Size = new System.Drawing.Size(0, 25);
            this.labelTongGiaTour.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(620, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số Lượng Đoàn Tham Gia:";
            // 
            // labelSoLuongDoanThamGia
            // 
            this.labelSoLuongDoanThamGia.AutoSize = true;
            this.labelSoLuongDoanThamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongDoanThamGia.Location = new System.Drawing.Point(948, 368);
            this.labelSoLuongDoanThamGia.Name = "labelSoLuongDoanThamGia";
            this.labelSoLuongDoanThamGia.Size = new System.Drawing.Size(0, 25);
            this.labelSoLuongDoanThamGia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thanh Toán:";
            // 
            // labelChiPhi
            // 
            this.labelChiPhi.AutoSize = true;
            this.labelChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiPhi.Location = new System.Drawing.Point(948, 422);
            this.labelChiPhi.Name = "labelChiPhi";
            this.labelChiPhi.Size = new System.Drawing.Size(0, 25);
            this.labelChiPhi.TabIndex = 15;
            // 
            // dataGridViewTourDuLich
            // 
            this.dataGridViewTourDuLich.AllowUserToAddRows = false;
            this.dataGridViewTourDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourDuLich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTour,
            this.tenTourThongKeTour});
            this.dataGridViewTourDuLich.Location = new System.Drawing.Point(12, 620);
            this.dataGridViewTourDuLich.Name = "dataGridViewTourDuLich";
            this.dataGridViewTourDuLich.RowHeadersWidth = 51;
            this.dataGridViewTourDuLich.Size = new System.Drawing.Size(598, 209);
            this.dataGridViewTourDuLich.TabIndex = 16;
            this.dataGridViewTourDuLich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTourDuLich_CellClick);
            // 
            // maTour
            // 
            this.maTour.HeaderText = "Mã Tour";
            this.maTour.MinimumWidth = 6;
            this.maTour.Name = "maTour";
            this.maTour.Width = 125;
            // 
            // tenTourThongKeTour
            // 
            this.tenTourThongKeTour.HeaderText = "Tên Tour";
            this.tenTourThongKeTour.MinimumWidth = 6;
            this.tenTourThongKeTour.Name = "tenTourThongKeTour";
            this.tenTourThongKeTour.Width = 450;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Thống kê Tour Du Lịch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số Lượng Đoàn Tham Quan:";
            // 
            // tongSoLuongDoanThamGia
            // 
            this.tongSoLuongDoanThamGia.AutoSize = true;
            this.tongSoLuongDoanThamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongSoLuongDoanThamGia.Location = new System.Drawing.Point(948, 620);
            this.tongSoLuongDoanThamGia.Name = "tongSoLuongDoanThamGia";
            this.tongSoLuongDoanThamGia.Size = new System.Drawing.Size(0, 25);
            this.tongSoLuongDoanThamGia.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(620, 668);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số Lượng Tour:";
            // 
            // label1SoLuongTourThongKe
            // 
            this.label1SoLuongTourThongKe.AutoSize = true;
            this.label1SoLuongTourThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SoLuongTourThongKe.Location = new System.Drawing.Point(948, 668);
            this.label1SoLuongTourThongKe.Name = "label1SoLuongTourThongKe";
            this.label1SoLuongTourThongKe.Size = new System.Drawing.Size(0, 25);
            this.label1SoLuongTourThongKe.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(620, 717);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Số Lượng Địa Điểm Tham Quan:";
            // 
            // labelSoLuongDiaDiemThamQuan
            // 
            this.labelSoLuongDiaDiemThamQuan.AutoSize = true;
            this.labelSoLuongDiaDiemThamQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuongDiaDiemThamQuan.Location = new System.Drawing.Point(948, 717);
            this.labelSoLuongDiaDiemThamQuan.Name = "labelSoLuongDiaDiemThamQuan";
            this.labelSoLuongDiaDiemThamQuan.Size = new System.Drawing.Size(0, 25);
            this.labelSoLuongDiaDiemThamQuan.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(620, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Lợi Nhuận";
            // 
            // lableLoiNhuan
            // 
            this.lableLoiNhuan.AutoSize = true;
            this.lableLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableLoiNhuan.Location = new System.Drawing.Point(948, 277);
            this.lableLoiNhuan.Name = "lableLoiNhuan";
            this.lableLoiNhuan.Size = new System.Drawing.Size(0, 25);
            this.lableLoiNhuan.TabIndex = 25;
            // 
            // dateTimePickerStartDay
            // 
            this.dateTimePickerStartDay.Location = new System.Drawing.Point(616, 14);
            this.dateTimePickerStartDay.Name = "dateTimePickerStartDay";
            this.dateTimePickerStartDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDay.TabIndex = 26;
            // 
            // dateTimePickerEndDay
            // 
            this.dateTimePickerEndDay.Location = new System.Drawing.Point(616, 52);
            this.dateTimePickerEndDay.Name = "dateTimePickerEndDay";
            this.dateTimePickerEndDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDay.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(482, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ngày bắt đầu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(479, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ngày kết thúc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 58);
            this.button1.TabIndex = 30;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 880);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerEndDay);
            this.Controls.Add(this.dateTimePickerStartDay);
            this.Controls.Add(this.lableLoiNhuan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelSoLuongDiaDiemThamQuan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1SoLuongTourThongKe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tongSoLuongDoanThamGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewTourDuLich);
            this.Controls.Add(this.labelChiPhi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSoLuongDoanThamGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTongGiaTour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewKhachHang);
            this.Controls.Add(this.labelSoLuongTour);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelTongChiPhiCuaDoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSoLuongKhacHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDDL);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourDuLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSoLuongKhacHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTongChiPhiCuaDoan;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelSoLuongTour;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTongGiaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSoLuongDoanThamGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelChiPhi;
        private System.Windows.Forms.DataGridView dataGridViewTourDuLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTourThongKeTour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tongSoLuongDoanThamGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1SoLuongTourThongKe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSoLuongDiaDiemThamQuan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lableLoiNhuan;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}