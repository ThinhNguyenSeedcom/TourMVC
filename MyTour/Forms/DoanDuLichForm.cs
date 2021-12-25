using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTour.Forms
{
    public partial class DoanDuLichForm : Form
    {
        public static List<DoanDuLich> doanDuLiches;
        public static int currentIndex = 0;
        public static int currentIndexKhachHang = 0;
        public static int currentIndexChiPhi = 0;

        public DoanDuLichForm()
        {
            InitializeComponent();
            loadDB();
        }
        public void loadDB()
        {
            doanDuLiches = DoanDuLich.GetAll();
            dataGridViewDDL.AutoGenerateColumns = false;
            dataGridViewDDL.DataSource = doanDuLiches;
            dataGridViewDDL.Columns["maDoan"].DataPropertyName = "MaDoan";
            dataGridViewDDL.Columns["tenTour"].DataPropertyName = "tenTour";
            dataGridViewDDL.Columns["ngayKhoiHanh"].DataPropertyName = "NgayKhoiHanh";
            dataGridViewDDL.Columns["ngayKetThuc"].DataPropertyName = "NgayKetThuc";

            dataGridViewNDD.AutoGenerateColumns = false;
            dataGridViewNDD.DataSource = doanDuLiches;
            dataGridViewNDD.Columns["maDoanNDD"].DataPropertyName = "MaDoan";
            dataGridViewNDD.Columns["hanhTrinh"].DataPropertyName = "HanhTrinh";
            dataGridViewNDD.Columns["khachSan"].DataPropertyName = "KhachSan";
            dataGridViewNDD.Columns["ddThamQuan"].DataPropertyName = "DiaDiemThamQuan";

            System.Console.WriteLine("ma " + doanDuLiches[0].HanhTrinh);
            ClickDB(currentIndex);





        }

        public void ClickDB(int index)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] {
                        new DataColumn("Mã Chi Phí", typeof(string)),
                        new DataColumn("Mã Đoàn",typeof(string)),
                        new DataColumn("Số Tiền",typeof(string)),
                        new DataColumn("Tên Loại Chi Phí",typeof(string))
            });

            foreach (var item in doanDuLiches[index].ChiPhis)
            {
                dt.Rows.Add(item.MaChiPhi, item.MaDoan, item.SoTien, item.TenLoaiChiPhi);
            }

            dataGridViewChiPhi.DataSource = dt;

            DataTable khachHang = new DataTable();
            khachHang.Columns.AddRange(new DataColumn[7] {
                new DataColumn("Mã Khách Hàng", typeof(string)),
                new DataColumn("Họ Tên", typeof(string)),
                new DataColumn("Số Chứng Minh Nhân Dân", typeof(string)),
                new DataColumn("Địa Chỉ", typeof(string)),
                new DataColumn("Giới Tính", typeof(string)),
                new DataColumn("Số Điện Thoại", typeof(string)),
                new DataColumn("Quốc Tịch", typeof(string)),
            });

            foreach (var item in doanDuLiches[index].KhachHangs)
            {
                khachHang.Rows.Add(item.MaKH, item.HoTen, item.SoCMND, item.DiaChi, item.GioiTinh, item.SDT, item.QuocTich);
            }

            dataGridViewKhachHang.DataSource = khachHang;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridViewDDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dataGridViewDDL.CurrentCell.RowIndex;
            ClickDB(currentIndex);
    
        }

        private void dataGridViewDDL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            KhachHangForm khachHang = new KhachHangForm();
            khachHang.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadDB();
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndexKhachHang = dataGridViewKhachHang.CurrentCell.RowIndex;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateDoanDuLichForm createDoanDuLichForm = new CreateDoanDuLichForm();
            createDoanDuLichForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChiPhiForm chiPhi = new ChiPhiForm();
            chiPhi.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChiPhi chiPhi = doanDuLiches[currentIndex].ChiPhis.ElementAt(currentIndexChiPhi);
            System.Console.WriteLine("tesst" + chiPhi.MaChiPhi);
            if (ChiPhi.delectChiPhi(chiPhi.MaChiPhi) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDB();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }
        }

        private void dataGridViewChiPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndexChiPhi = dataGridViewChiPhi.CurrentCell.RowIndex;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = doanDuLiches[currentIndex].KhachHangs.ElementAt(currentIndexKhachHang);
            if (KhachHang.deleteKH(khachHang.MaKH, doanDuLiches[currentIndex].MaDoan) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDB();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }
        }

      
    }
}
