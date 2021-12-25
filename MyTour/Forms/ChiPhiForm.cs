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
    public partial class ChiPhiForm : Form
    {
        string madoan = DoanDuLichForm.doanDuLiches[DoanDuLichForm.currentIndex].MaDoan.ToString();
        public static List<LoaiChiPhi> LoaiChiPhis;
        public ChiPhiForm()
        {
            InitializeComponent();
            LoadDB();

        }
        public void LoadDB()
        {
            LoaiChiPhis = LoaiChiPhi.getAll();
            comboBoxMaLoaiChiPhi.DataSource = LoaiChiPhis;
            comboBoxMaLoaiChiPhi.DisplayMember = "TenLoaiChiPhi";
            comboBoxMaLoaiChiPhi.ValueMember = "MaLoaiChiPhi";

            labelMaDoan.Text = madoan;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ChiPhi newChiPhi = new ChiPhi();
            newChiPhi.MaDoan = madoan;
            newChiPhi.MaChiPhi = textBoxMaChiPhi.Text;
            newChiPhi.MaLoaiChiPhi = (string)comboBoxMaLoaiChiPhi.SelectedValue;
            newChiPhi.SoTien = Convert.ToDouble(textBoxSoTien.Text);
            if(DoanDuLich.addChiPhi(newChiPhi) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Data updated Unsuccessfully!");
            }
        }
    }
}
