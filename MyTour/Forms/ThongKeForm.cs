
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
    public partial class ThongKeForm : Form
    {
        public static List<DoanDuLich> doanDuLiches;
        public static int currentIndex = 0;

        public static List<KhachHang> khachHangs;
        public static int currentIndexKH = 0;

        public static List<TourDuLich> Toures;
        public static int currentTourIndex = 0;
        public ThongKeForm()
        {
            InitializeComponent();
            loadDB();

        }
        public void loadDB()
        {
            doanDuLiches = DoanDuLich.GetAll();
            khachHangs = KhachHang.GetAll();
            Toures = TourDuLich.GetAll();



            DateTime dateTimeNBD = dateTimePickerStartDay.Value;
            DateTime dataTimeNKT = dateTimePickerEndDay.Value;

            doanDuLiches = getListDDLToDate(doanDuLiches, dateTimeNBD, dataTimeNKT);
            khachHangs = getListKhachHangToDate(khachHangs, dateTimeNBD, dataTimeNKT);
            Toures = getListTourToDate(Toures, dateTimeNBD, dataTimeNKT);

            dataGridViewDDL.AutoGenerateColumns = false;
            dataGridViewDDL.DataSource = doanDuLiches;
            dataGridViewDDL.Columns["maDoan"].DataPropertyName = "MaDoan";
            dataGridViewDDL.Columns["tenTour"].DataPropertyName = "tenTour";
            dataGridViewDDL.Columns["ngayKhoiHanh"].DataPropertyName = "NgayKhoiHanh";
            dataGridViewDDL.Columns["ngayKetThuc"].DataPropertyName = "NgayKetThuc";

            

            dataGridViewKhachHang.AutoGenerateColumns = false;
            dataGridViewKhachHang.DataSource = khachHangs;

            dataGridViewKhachHang.Columns["maKH"].DataPropertyName = "MaKH";
            dataGridViewKhachHang.Columns["tenKH"].DataPropertyName = "HoTen";
            dataGridViewKhachHang.Columns["sdt"].DataPropertyName = "SDT";

            dataGridViewTourDuLich.AutoGenerateColumns = false;
            dataGridViewTourDuLich.DataSource = Toures;

            dataGridViewTourDuLich.Columns["maTour"].DataPropertyName = "MaTour";
            dataGridViewTourDuLich.Columns["tenTourThongKeTour"].DataPropertyName = "TenGoi";

        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {

        }
        public int TongChiPhiCuaDoan (  int currentIndex)
        {
            int result = 0;
            foreach(var item in doanDuLiches[currentIndex].ChiPhis)
            {
                result +=  (int)item.SoTien;
            }

            return result;
        }

        public int TongGiaTour (int currentIndex)
        {
            int result = 0;
            foreach (var item in doanDuLiches[currentIndex].TourDuLich.GiaTours)
            {
                result += (int)item.ThanhTien;
            }
            return result;

        }

        public int getGiaTour (int currentIndex)
        {
            int result = 0;
            DateTime DateTimeDDL = Convert.ToDateTime(doanDuLiches[currentIndex].NgayKhoiHanh);
            foreach (var item in doanDuLiches[currentIndex].TourDuLich.GiaTours)
            {
                DateTime DateTimeTOUR = Convert.ToDateTime(item.ThoiGianBatDau);
                if(DateTime.Compare(DateTimeDDL, DateTimeTOUR) > 0)
                {
                    System.Console.WriteLine("true" + item.ThanhTien);
                    return (int)item.ThanhTien;
                }
            }

            return result;
        }

        public List<DoanDuLich> getListDDLToDate(List<DoanDuLich> doanDuLiches,DateTime startDay, DateTime endDay)
        {
            List<DoanDuLich> newDoanDuLich = new List<DoanDuLich>();
            foreach (var item in doanDuLiches)
            {
                DateTime DateTimeNBDDoan = Convert.ToDateTime(item.NgayKhoiHanh);
                int resultCompare = DateTime.Compare(DateTimeNBDDoan, startDay);
                int resultCompareDateEnd = DateTime.Compare(endDay, DateTimeNBDDoan);
                if (resultCompare > 0 && resultCompareDateEnd > 0)
                {
                    newDoanDuLich.Add(item);
                }
            }

            return newDoanDuLich;

        }

        public List<KhachHang> getListKhachHangToDate(List<KhachHang> khachHangs, DateTime startDay, DateTime endDay)
        {
            List<KhachHang> newkhachHang = new List<KhachHang>();
            foreach (var item in khachHangs)
            {
                foreach(var itemDoan in item.DoanDuLiches)
                {
                    DateTime DateTimeNBDDoan = Convert.ToDateTime(itemDoan.NgayKhoiHanh);
                    int resultCompare = DateTime.Compare(DateTimeNBDDoan, startDay);
                    int resultCompareDateEnd = DateTime.Compare(endDay, DateTimeNBDDoan);
                    if (resultCompare > 0 && resultCompareDateEnd > 0)
                    {
                        newkhachHang.Add(item);
                    }
                }
                
                /*int resultCompare = DateTime.Compare(DateTimeNBDDoan, startDay);
                int resultCompareDateEnd = DateTime.Compare(endDay, DateTimeNBDDoan);*/
                
            }

            return newkhachHang;

        }

        public List<TourDuLich> getListTourToDate(List<TourDuLich> tourDuLiches, DateTime startDay, DateTime endDay)
        {
            List<TourDuLich> newTourduLich = new List<TourDuLich>();
            foreach (var item in Toures)
            {
                foreach (var itemGiaTour in item.GiaTours)
                {
                    DateTime DateTimeNBDDoan = Convert.ToDateTime(itemGiaTour.ThoiGianBatDau);
                    int resultCompare = DateTime.Compare(DateTimeNBDDoan, startDay);
                    int resultCompareDateEnd = DateTime.Compare(endDay, DateTimeNBDDoan);
                    if (resultCompare > 0 && resultCompareDateEnd > 0)
                    {
                        newTourduLich.Add(item);
                    }
                }

                /*int resultCompare = DateTime.Compare(DateTimeNBDDoan, startDay);
                int resultCompareDateEnd = DateTime.Compare(endDay, DateTimeNBDDoan);*/

            }

            return newTourduLich;

        }

        private void dataGridViewDDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = dataGridViewDDL.CurrentCell.RowIndex;
            labelSoLuongKhacHang.Text = doanDuLiches[currentIndex].KhachHangs.Count().ToString();

            labelTongChiPhiCuaDoan.Text = TongChiPhiCuaDoan(currentIndex).ToString();
            //gia tour
            labelSoLuongTour.Text = getGiaTour(currentIndex).ToString();
            //doanh thu
            labelTongGiaTour.Text = (doanDuLiches[currentIndex].KhachHangs.Count() * getGiaTour(currentIndex)).ToString();

            lableLoiNhuan.Text = (Int32.Parse(labelTongGiaTour.Text) - Int32.Parse(labelTongChiPhiCuaDoan.Text)).ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int TongChiPhiKhachHang (int currentKh)
        {
            int result = 0;

            foreach(var item in khachHangs[currentIndexKH].DoanDuLiches)
            {
                foreach (var itemCP in item.ChiPhis)
                {
                    result += (int)itemCP.SoTien;
                }
            }

            return result;
        }

        public int getGiaTourKH (int currentIndex)
        {
            int result = 0;
            DateTime DateTimeDDL;
            DateTime DateTimeTOUR;
            foreach (var item in khachHangs[currentIndexKH].DoanDuLiches)
            {
                DateTimeDDL = Convert.ToDateTime(item.NgayKhoiHanh);
                foreach(var itemChiPhi in item.TourDuLich.GiaTours)
                {
                    DateTimeTOUR = Convert.ToDateTime(itemChiPhi.ThoiGianBatDau);
                    if (DateTime.Compare(DateTimeDDL, DateTimeTOUR) > 0)
                    {
                        result += (int)itemChiPhi.ThanhTien;
                    }
                }
            }
            return result;

        }
        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndexKH = dataGridViewKhachHang.CurrentCell.RowIndex;
            labelSoLuongDoanThamGia.Text = khachHangs[currentIndexKH].DoanDuLiches.Count().ToString();
            labelChiPhi.Text = getGiaTourKH(currentIndexKH).ToString();
        }

        private void dataGridViewTourDuLich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentTourIndex = dataGridViewTourDuLich.CurrentCell.RowIndex;
            tongSoLuongDoanThamGia.Text = Toures[currentTourIndex].DoanDuLiches.Count().ToString();
            label1SoLuongTourThongKe.Text = Toures[currentTourIndex].GiaTours.Count().ToString();
            labelSoLuongDiaDiemThamQuan.Text = Toures[currentTourIndex].ThamQuans.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDB();
        }
    }
}
