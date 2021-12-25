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
    public partial class NhanVienForm : Form
    {
        public List<NhanVien> NhanViens;
        public List<DoanDuLich> doanDuLiches;
        public int currentNV = 0;
        public int currentChucVu = 0;
        public NhanVienForm()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            NhanViens = NhanVien.GetAll();
            doanDuLiches = DoanDuLich.GetAll();
            dataGridViewNhanVien.AutoGenerateColumns = false;
            dataGridViewNhanVien.DataSource = NhanViens;

            dataGridViewNhanVien.Columns["maNV"].DataPropertyName = "MaNV";
            dataGridViewNhanVien.Columns["tenNV"].DataPropertyName = "TenNV";

            comboBoxMaDoan.DataSource = doanDuLiches;
            comboBoxMaDoan.DisplayMember = "MaDoan";
            comboBoxMaDoan.ValueMember = "MaDoan";
            ClickLoadDb(currentNV);

        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ClickLoadDb(int index)
        {
            DataTable tbDoan = new DataTable();
            tbDoan.Columns.AddRange(new DataColumn[4] {
                        new DataColumn("Mã Đoàn", typeof(string)),
                        new DataColumn("Nhiệm Vụ",typeof(string)),
                        new DataColumn("Ngày bắt đầu",typeof(string)),
                        new DataColumn("Ngày kết thúc",typeof(string)),
            });

            foreach(var item in NhanViens[index].PhanBoNV_Doan)
            {
                tbDoan.Rows.Add(item.MaDoan, item.NhiemVu,item.DoanDuLich.NgayKhoiHanh,item.DoanDuLich.NgayKetThuc);
            }

            dataGridViewDoanThamGia.DataSource = tbDoan;

        }
        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentNV = dataGridViewNhanVien.CurrentCell.RowIndex;
            ClickLoadDb(currentNV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhanBoNV_Doan phanBoNV_Doan = new PhanBoNV_Doan();
            phanBoNV_Doan.MaNV = NhanViens[currentNV].MaNV;
            phanBoNV_Doan.MaDoan = (string)comboBoxMaDoan.SelectedValue;
            phanBoNV_Doan.NhiemVu = textBoxChucVu.Text;

            if(phanBoNV_Doan.add() == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDB();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dateTimeNBD = dateTimePickerNgayBD.Value;
            DateTime dataTimeNKT = dateTimePickerNgayKetThuc.Value;

            List<PhanBoNV_Doan> result = new List<PhanBoNV_Doan>();
            foreach(var item in NhanViens[currentNV].PhanBoNV_Doan) 
            {
                DateTime DateTimeNBDDoan = Convert.ToDateTime(item.DoanDuLich.NgayKhoiHanh);
                int resultCompare = DateTime.Compare(DateTimeNBDDoan, dateTimeNBD);
                int resultCompareDateEnd = DateTime.Compare(dataTimeNKT, DateTimeNBDDoan);

                if (resultCompare > 0 && resultCompareDateEnd> 0)
                {
                    result.Add(item);
                }
            }

            DataTable tbDateTime = new DataTable();
            tbDateTime.Columns.AddRange(new DataColumn[2] {
                        new DataColumn("Mã Đoàn", typeof(string)),
                        new DataColumn("Nhiệm Vụ",typeof(string)),
            });

            foreach (var item in result)
            {
                tbDateTime.Rows.Add(item.MaDoan, item.NhiemVu);
            }

            dataGridViewTimKiem.DataSource = tbDateTime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idMaNv = NhanViens[currentNV].MaNV;
            string idMaDoan = NhanViens[currentNV].PhanBoNV_Doan.ElementAt(currentChucVu).MaDoan;

            if(PhanBoNV_Doan.remove(idMaNv,idMaDoan) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDB();
            }
        }

        private void dataGridViewDoanThamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentChucVu = dataGridViewDoanThamGia.CurrentCell.RowIndex;
        }

       
    }
}
