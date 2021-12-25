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
    public partial class GiaTourForm : Form
    {
        ICollection<GiaTour> giaTours;
        int currentIndex = MyTour.currentTourIndex;
        public GiaTourForm()
        {
            InitializeComponent();
            loadDb();
        }

        public void loadDb()
        {
            giaTours = MyTour.Toures[currentIndex].GiaTours;
            dataGridViewFGiaTour.AutoGenerateColumns = false;
            dataGridViewFGiaTour.DataSource = giaTours.ToList();

            dataGridViewFGiaTour.Columns["magiatourFgiatour"].DataPropertyName = "MaGia";
            dataGridViewFGiaTour.Columns["matourFgiatour"].DataPropertyName = "MaTour";
            dataGridViewFGiaTour.Columns["startTimeFgiatour"].DataPropertyName = "ThoiGianBatDau";
            dataGridViewFGiaTour.Columns["endTimeFgiatour"].DataPropertyName = "ThoiGianKetThuc";
            dataGridViewFGiaTour.Columns["thanhtienFgiatour"].DataPropertyName = "ThanhTien";   

        }

        private void GiaTour_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFGiaTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            currentIndex = dataGridViewFGiaTour.CurrentCell.RowIndex;
            textBoxMaGia.Text = giaTours.ToList()[currentIndex].MaGia;
            textBoxMaTour.Text = giaTours.ToList()[currentIndex].MaTour;
            textBoxThanhTien.Text = giaTours.ToList()[currentIndex].ThanhTien.ToString();
            System.Console.WriteLine(giaTours.ToList()[currentIndex].ThoiGianBatDau.ToString());
            string datet = giaTours.ToList()[currentIndex].ThoiGianBatDau.ToString();
            string dateEndDay = giaTours.ToList()[currentIndex].ThoiGianKetThuc.ToString();
            DateTime datatimeStartDay = DateTime.Parse(datet);
            dateTimePicker1.Value = datatimeStartDay;

            DateTime dateTimeEndDay = DateTime.Parse(dateEndDay);
            dateTimePicker2.Value = dateTimeEndDay;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaTour giaTour = new GiaTour();
            giaTour.MaGia = textBoxMaGia.Text;
            giaTour.MaTour = textBoxMaTour.Text;
            giaTour.ThanhTien = Convert.ToDouble(textBoxThanhTien.Text) ;

            giaTour.ThoiGianBatDau = dateTimePicker1.Value;
            giaTour.ThoiGianKetThuc = dateTimePicker2.Value;
            if (giaTour.addGiaTour() == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDb();
            }
            else
            {
                MessageBox.Show("Data Updated Unsuccessfully!");
            }
               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maGiaTour = textBoxMaGia.Text;
            if (GiaTour.remove(maGiaTour) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
                loadDb();
            }
        }
    }
}
