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
    public partial class LoaiHinhDuLichForm : Form
    {

        public List<LoaiHinhDuLich> dataLHDL;
        int currentTourIndex;
        public LoaiHinhDuLichForm()
        {
            InitializeComponent();
            loadLHDL();
        }

        public void loadLHDL()
        {
            dataLHDL = MyTour.LHDLs;
            dataGridViewLoaiTour.AutoGenerateColumns = false;
            dataGridViewLoaiTour.DataSource = dataLHDL;

            dataGridViewLoaiTour.Columns["maloaitour"].DataPropertyName = "MaLoaiHinh";
            dataGridViewLoaiTour.Columns["tenloaitour"].DataPropertyName = "TenLoaiHinh";

            textBoxMaLoai.Text = dataLHDL[0].MaLoaiHinh;
            textBoxTenLoai.Text = dataLHDL[0].TenLoaiHinh;
        }
       

        private void LoaiHinhDuLichForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewLoaiTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLoaiTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentTourIndex = dataGridViewLoaiTour.CurrentCell.RowIndex;

            textBoxMaLoai.Text = dataLHDL[currentTourIndex].MaLoaiHinh;
            textBoxTenLoai.Text = dataLHDL[currentTourIndex].TenLoaiHinh;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            LoaiHinhDuLich lhdl = new LoaiHinhDuLich();
            lhdl.MaLoaiHinh = textBoxMaLoai.Text;
            lhdl.TenLoaiHinh = textBoxTenLoai.Text;

            if(lhdl.addLHDL() == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                MyTour.LHDLs = LoaiHinhDuLich.GetAll();
                loadLHDL();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }
        }
    }
}
