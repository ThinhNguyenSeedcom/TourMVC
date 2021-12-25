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
   
    public partial class ThamQuanForm : Form
    {
        public static ICollection<ThamQuan> thamQuans;
        int currentIndex = 0;
        public ThamQuanForm()
        {
            InitializeComponent();
            loadDb();
        }

        public void loadDb()
        {
            thamQuans = MyTour.Toures[currentIndex].ThamQuans;
            dataGridViewThamQuan.AutoGenerateColumns = false;
            dataGridViewThamQuan.DataSource = thamQuans.ToList();
            dataGridViewThamQuan.Columns["maTour"].DataPropertyName = "MaTour";
            dataGridViewThamQuan.Columns["maDiaDiem"].DataPropertyName = "MaDiaDiem";
            dataGridViewThamQuan.Columns["tenTour"].DataPropertyName = "TenTour";
            dataGridViewThamQuan.Columns["tenDiaDiem"].DataPropertyName = "TenDiaDiem";
            dataGridViewThamQuan.Columns["thuTu"].DataPropertyName = "ThuTu";
        }

        private void DiaDiemForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiaDiemForm diaDiemForm = new DiaDiemForm();
            diaDiemForm.ShowDialog();
        }
    }
}
