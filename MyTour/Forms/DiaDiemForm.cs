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
    public partial class DiaDiemForm : Form
    {
        ICollection<ThamQuan> thamQuans;
        List<DiaDiem> DiaDiems;

        int currentIndex = 0;
        public DiaDiemForm()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            DiaDiems = DiaDiem.GetAll();
            thamQuans = MyTour.Toures[MyTour.currentTourIndex].ThamQuans;
            dataGridViewDiaDiem.AutoGenerateColumns = false;
            dataGridViewDiaDiem.DataSource = thamQuans.ToList();
            
            dataGridViewDiaDiem.Columns["maDiaDiem"].DataPropertyName = "MaDiaDiem";
            dataGridViewDiaDiem.Columns["tenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dataGridViewDiaDiem.Columns["thuThuDD"].DataPropertyName = "ThuTu";
            dataGridViewDsdd.AutoGenerateColumns = false;
            dataGridViewDsdd.DataSource = DiaDiems;
            

            dataGridViewDsdd.Columns["madd_DiaDiem"].DataPropertyName = "MaDiaDiem";
            dataGridViewDsdd.Columns["tendd_DiaDiem"].DataPropertyName = "TenDiaDiem";


        }

        private void DiaDiemForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDiaDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dataGridViewDiaDiem.CurrentCell.RowIndex;
            textBoxMaDiaDiem.Text = thamQuans.ToList()[currentIndex].MaDiaDiem;
            textBoxTenDiaDiemT.Text = thamQuans.ToList()[currentIndex].TenDiaDiem;
            textBoxThuTu.Text = thamQuans.ToList()[currentIndex].ThuTu.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiaDiem dd = new DiaDiem();
            ThamQuan thamQuan = new ThamQuan();

            thamQuan.MaTour = thamQuans.ToList()[currentIndex].MaTour;
            thamQuan.MaDiaDiem = textBoxMaDiaDiem.Text;
            thamQuan.ThuTu = int.Parse(textBoxThuTu.Text);

            

            if (thamQuan.addThamQuan() == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                MyTour my = new MyTour();
                my.loadDb();
                loadDB();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiaDiem dd = new DiaDiem();
            dd.MaDiaDiem = textBoxMaDD_DSDD.Text;
            dd.TenDiaDiem = textBoxTenDD_DSDD.Text;
            if (dd.addDD() == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDB();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }
        }

        private void dataGridViewDsdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDsdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentInd = dataGridViewDsdd.CurrentCell.RowIndex;
            textBoxMaDD_DSDD.Text = DiaDiems[currentInd].MaDiaDiem;
            textBoxTenDD_DSDD.Text = DiaDiems[currentInd].TenDiaDiem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maTour = thamQuans.ElementAt(currentIndex).MaTour;
            string maDiaDiem = thamQuans.ElementAt(currentIndex).MaDiaDiem;

            if(DiaDiem.remove(maTour,maDiaDiem) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDB();
            }
        }
    }
}
