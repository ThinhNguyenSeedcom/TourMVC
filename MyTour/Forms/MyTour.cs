
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTour.BIZ;
using MyTour.Forms;

namespace MyTour
{
	public partial class MyTour : Form
	{
		public static List<TourDuLich> Toures;
		public static List<LoaiHinhDuLich> LHDLs;
		public static int currentTourIndex = 0;
		public MyTour()
		{
			InitializeComponent();
			loadDb();
		}

		public void loadDb()
		{
			Toures = TourDuLich.GetAll();
			LHDLs = LoaiHinhDuLich.GetAll();

			dtgvData.AutoGenerateColumns = false;
			dtgvData.DataSource = Toures;


			dtgvData.Columns["tenTour"].DataPropertyName = "TenGoi";
			dtgvData.Columns["loaiTour"].DataPropertyName = "TenLoai";
			dtgvData.Columns["datDiemTour"].DataPropertyName = "DacDiem";

			txbTenTour.Text = Toures[currentTourIndex].TenGoi;
			txtDatDiemTour.Text = Toures[currentTourIndex].DacDiem;


			cbLoaiTour.DataSource = LHDLs;
			cbLoaiTour.DisplayMember = "TenLoaiHinh";
			cbLoaiTour.ValueMember = "MaLoaiHinh";

			ClickLoadDb(currentTourIndex);
		}

		private void button1_Click(object sender, EventArgs e)
		{


		}


		private void MyTour_Load(object sender, EventArgs e)
		{

		}

		public void ClickLoadDb(int index)
        {
			DataTable dt = new DataTable();
			dt.Columns.AddRange(new DataColumn[3] {
						new DataColumn("Ngày bắt đầu", typeof(string)),
						new DataColumn("Ngày kết thúc",typeof(string)),
						new DataColumn("Giá",typeof(string))
			});

			foreach (var item in Toures[index].GiaTours)
			{
				dt.Rows.Add(item.ThoiGianBatDau, item.ThoiGianKetThuc, item.ThanhTien);
			}

			this.dataGridViewTest.AllowUserToAddRows = false;
			this.dataGridViewTest.DataSource = dt;

			DataTable dd = new DataTable();
			dd.Columns.AddRange(new DataColumn[2] {
						new DataColumn("Thứ tự", typeof(string)),
						new DataColumn("Tên địa điểm",typeof(string)),
			});
			foreach (var item in Toures[index].ThamQuans)
			{
				System.Console.WriteLine("MaTour " + item.MaTour);
				System.Console.WriteLine("MaDiaDiem " + item.MaDiaDiem);
				System.Console.WriteLine("ThuTu " + item.ThuTu);
				System.Console.WriteLine("TenDiaDiem " + item.DiaDiem.TenDiaDiem);
				/*System.Console.WriteLine("TenGoi " + item.TourDuLich.TenGoi);*/
				dd.Rows.Add(item.ThuTu, item.DiaDiem.TenDiaDiem);
			}

			this.dataGridViewDiadiem.DataSource = dd;

		}
		private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			currentTourIndex = dtgvData.CurrentCell.RowIndex;
			txbTenTour.Text = Toures[currentTourIndex].TenGoi;
			cbLoaiTour.SelectedValue = Toures[currentTourIndex].MaLoaiHinh;
			txtDatDiemTour.Text = Toures[currentTourIndex].DacDiem;

			ClickLoadDb(currentTourIndex);
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void updateTour_Click(object sender, EventArgs e)
		{
			var newTour = Toures[currentTourIndex];
			newTour.TenGoi = txbTenTour.Text;
			newTour.DacDiem = txtDatDiemTour.Text;
			newTour.MaLoaiHinh = (string)cbLoaiTour.SelectedValue;
		   

			if (newTour.upDateTour() == 1)
			{
				MessageBox.Show("Data Updated Successfully!");
				loadDb();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			txbTenTour.Text = "";
			txtDatDiemTour.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var rand = new Random();
			TourDuLich tour = new TourDuLich();
			tour.MaTour = "MT" + rand.Next(50, 1001);
			tour.TenGoi = txbTenTour.Text;
			tour.DacDiem = txtDatDiemTour.Text;
			tour.MaLoaiHinh = (string)cbLoaiTour.SelectedValue;

			if (tour.addTour() == 1)
			{
				MessageBox.Show("Data Updated Successfully!");
			}
			else
			{
				MessageBox.Show("Data Updated Unsuccessfully!");
			}

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtDatDiemTour_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void myTab_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			LoaiHinhDuLichForm LoaiHinhDulich = new LoaiHinhDuLichForm();
			LoaiHinhDulich.ShowDialog();
		}


		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridViewPriceTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

       

        private void button3_Click(object sender, EventArgs e)
        {
			loadDb();
        }

        private void button5_Click(object sender, EventArgs e)
        {
			GiaTourForm giaTourForm = new GiaTourForm();
			giaTourForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
			DiaDiemForm diaDiemForm = new DiaDiemForm();
			diaDiemForm.ShowDialog();
        }

        
    }
}
