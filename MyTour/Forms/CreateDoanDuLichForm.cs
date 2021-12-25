using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTour.Forms;

namespace MyTour.Forms
{
    public partial class CreateDoanDuLichForm : Form
    {
        public static List<LoaiChiPhi> LoaiChiPhis;
        public static List<TourDuLich> tourDuLiches;
        public CreateDoanDuLichForm()
        {
            InitializeComponent();
            loadDB();
        }

        public void loadDB()
        {
            LoaiChiPhis = LoaiChiPhi.getAll();
            tourDuLiches = TourDuLich.GetAll();
            comboBoxMaLoaiChiPhi.DataSource = LoaiChiPhis;
            comboBoxMaLoaiChiPhi.DisplayMember = "TenLoaiChiPhi";
            comboBoxMaLoaiChiPhi.ValueMember = "MaLoaiChiPhi";

            comboBoxMaTour.DataSource = tourDuLiches;
            comboBoxMaTour.DisplayMember = "TenGoi";
            comboBoxMaTour.ValueMember = "MaTour";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoanDuLich newDoanDuLich = new DoanDuLich();
            NoiDungTour newNoiDungTour = new NoiDungTour();
            ChiPhi newChiPhi = new ChiPhi();

            newDoanDuLich.MaDoan = textBoxMaDoan.Text;
            newDoanDuLich.NgayKhoiHanh = dateTimePickerStart.Value;
            newDoanDuLich.NgayKetThuc = dateTimePickerEnd.Value;
            newDoanDuLich.MaTour = (string)comboBoxMaTour.SelectedValue;

            newNoiDungTour.MaDoan = textBoxMaDoan.Text;
            newNoiDungTour.HanhTrinh = textBoxHanhTrinh.Text;
            newNoiDungTour.KhachSan = textBoxKhachSan.Text;
            newNoiDungTour.DiaDiemThamQuan = textBoxDDTQ.Text;


            newChiPhi.MaDoan = textBoxMaDoan.Text;
            newChiPhi.MaChiPhi = textBoxMaChiPhi.Text;
            newChiPhi.MaLoaiChiPhi = (string)comboBoxMaLoaiChiPhi.SelectedValue;
            newChiPhi.SoTien = Convert.ToDouble(textBoxSoTien.Text);

            if(DoanDuLich.addDoanDuLich(newDoanDuLich) == 1 && DoanDuLich.addNoiDungDoan(newNoiDungTour) == 1 && DoanDuLich.addChiPhi(newChiPhi) == 1)
            {
                MessageBox.Show("Data Updated Successfully!");
            }

        }

        private void CreateDoanDuLichForm_Load(object sender, EventArgs e)
        {
           


        }

      
    }
}
