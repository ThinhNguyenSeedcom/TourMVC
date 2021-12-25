using MyTour.DAL;
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
    public partial class KhachHangForm : Form
    {
        public static List<KhachHang> khachHangs;
        public static int currentIndex = 0;
        string madoan = DoanDuLichForm.doanDuLiches[DoanDuLichForm.currentIndex].MaDoan.ToString();
        public KhachHangForm()
        {
            InitializeComponent();
            loadDb();
        }

        public void loadDb()
        {

            khachHangs = KhachHangDAL.GetAll();
            dataGridViewKhachHang.AutoGenerateColumns = false;
            dataGridViewKhachHang.DataSource = khachHangs;

            dataGridViewKhachHang.Columns["maKH"].DataPropertyName = "MaKH";
            dataGridViewKhachHang.Columns["tenKH"].DataPropertyName = "HoTen";

            labelTenDoan.Text = madoan;
        }
        private void KhachHangForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = textBoxMKH.Text;
            khachHang.HoTen = textBoxTenKH.Text;
            khachHang.GioiTinh = textBoxGioiTinh.Text;
            khachHang.SoCMND = textBoxCMND.Text;
            khachHang.DiaChi = textBoxDiaChi.Text;
            khachHang.SDT = textBoxSoDT.Text;
            khachHang.QuocTich = textBoxQuocTich.Text;

            DoanDuLich ddl = DoanDuLichForm.doanDuLiches[DoanDuLichForm.currentIndex];
           /* khachHang.DoanDuLiches = new List<DoanDuLich>();

            khachHang.DoanDuLiches.Add(ddl);*/


            if (khachHang.addKhachHangIntoDb(khachHang, ddl) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDb();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }

        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dataGridViewKhachHang.CurrentCell.RowIndex;
            textBoxMKH.Text = khachHangs[currentIndex].MaKH;
            textBoxTenKH.Text = khachHangs[currentIndex].HoTen;
            textBoxCMND.Text = khachHangs[currentIndex].SoCMND;
            textBoxDiaChi.Text = khachHangs[currentIndex].DiaChi;
            textBoxGioiTinh.Text = khachHangs[currentIndex].GioiTinh;
            textBoxSoDT.Text = khachHangs[currentIndex].SDT;
            textBoxQuocTich.Text = khachHangs[currentIndex].QuocTich;
        }

        private void dataGridViewKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = textBoxMKH.Text;
            khachHang.HoTen = textBoxTenKH.Text;
            khachHang.GioiTinh = textBoxGioiTinh.Text;
            khachHang.SoCMND = textBoxCMND.Text;
            khachHang.DiaChi = textBoxDiaChi.Text;
            khachHang.SDT = textBoxSoDT.Text;
            khachHang.QuocTich = textBoxQuocTich.Text;

            if(KhachHang.addKhachHang(khachHang) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDb();
            }

        }
    }
}
