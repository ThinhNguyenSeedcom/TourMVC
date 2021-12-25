using MyTour.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyTour
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTour myTour = new MyTour() { TopLevel = false, TopMost = true };
            myTour.FormBorderStyle = FormBorderStyle.None;
            panelChild.Controls.Clear();
            panelChild.Controls.Add(myTour);
            myTour.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DoanDuLichForm doanDuLichForm = new DoanDuLichForm() { TopLevel = false, TopMost = true };
            doanDuLichForm.FormBorderStyle = FormBorderStyle.None;
            panelChild.Controls.Clear();
            panelChild.Controls.Add(doanDuLichForm);
            doanDuLichForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongKeForm thongKeForm = new ThongKeForm() { TopLevel = false, TopMost = true };
            thongKeForm.FormBorderStyle = FormBorderStyle.None;
            panelChild.Controls.Clear();
            panelChild.Controls.Add(thongKeForm);
            thongKeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NhanVienForm nhanVienForm = new NhanVienForm() { TopLevel = false, TopMost = true };
            nhanVienForm.FormBorderStyle = FormBorderStyle.None;
            panelChild.Controls.Clear();
            panelChild.Controls.Add(nhanVienForm);
            nhanVienForm.Show();

        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
