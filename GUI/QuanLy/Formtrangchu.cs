using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.QuanLy
{
    public partial class Formtrangchu : Form
    {
        

        public Formtrangchu(QuanLyCafe.Gul.TrangChu trangChu)
        {
            InitializeComponent();
            LoadData();
            Thongke();
            label2.Text += " " + trangChu.nhanVien.Ten1;



        }

        private void LoadData()
        {
            DALNhanvien dALNhanvien = new DALNhanvien();       
           label6.Text=""+ dALNhanvien.Select().Rows.Count;
            DALBan dALBan = new DALBan();
            label13.Text = "" + dALBan.SelectBan().Rows.Count;
            label15.Text = "" + dALBan.TongSoBan().Rows.Count;


            DALHoaDon dAL = new DALHoaDon();
         
            //Chuyển kiểu biểu đồ hình tròn
           // chart1.Series[0].ChartType = SeriesChartType.Pie;
       
        }

        public void Thongke()
        {
            int a = 0, b = 0;
           
            DateTime time1 = DateTime.Now;
            DateTime time2 = DateTime.Now;
            time1 = time1.AddMonths(-1);
            DALHoaDon dALHoaDon = new DALHoaDon();
       
                foreach (DataRow item in dALHoaDon.TimKiemHoaDon1(time1, time2).Rows)
                {

                ; try
                {
                    a = Convert.ToInt32(item["TONGTIEN"].ToString());
                    b = Convert.ToInt32(item["Giamgia"].ToString());
                }
                catch { }
                 
                }

                label7.Text = (a - b).ToString("N") + " VND ";


        }

        private void guna2CustomGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
