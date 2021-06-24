using DAL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCafe.Gul
{
    public partial class QuanLy : Form
    {
        int MA = 100;
        int MamON =1000;
      public int MaBan =1;
        int Check = -1;
        private DALBan DALBan;
        private DALNhomMon nhomMon;
        private DALThucDon ThucDon;
        private DTO.NhanVien nhanVien;
        private DALNhanvien DALNhanvien;
       
        public QuanLy()
        {
            InitializeComponent();
            LoadDatabase();
          

        }

     
    
        internal void AddNhom(NhomMon nhomMon)
        {
            this.nhomMon.Insert(nhomMon);
            LoadDatabase();
        }

      

        private void QuanLy_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        internal void Update(NhomMon nhomMon)
        {
            this.nhomMon.Update(nhomMon);
            LoadDatabase();

        }

        public void LoadDatabase()
        {
            this.DALNhanvien = new DALNhanvien();
            nhanVien = new DTO.NhanVien();
            nhanVien.MaNV1 = "5951071110";//khoi tao ma nhan vien 
            nhomMon = new DALNhomMon();
            dataGridView3.DataSource = nhomMon.SelectNhomMon(); // lay ra nhom mon
          
            comboBox1.Items.Clear(); // xoa dl trong comobox
            comboBox2.Items.Clear();//xoa dl trong comobox
            foreach (DataRow item in nhomMon.SelectNhomMon().Rows)
            {
                MA = (Convert.ToInt32(item["MaLoai"].ToString()));
                comboBox1.Items.Add(item["TENLoai"].ToString());
                comboBox2.Items.Add(item["TENLoai"].ToString());
                comboBox2.Tag = item["MaLoai"].ToString();
            }
            ThucDon = new DALThucDon();
            dataGridView1.DataSource = ThucDon.SelectThucDon();// ;lay bang thuc don 
            
            foreach (DataRow item in ThucDon.SelectThucDon().Rows)
            {
                MamON = (Convert.ToInt32(item["MaMon"].ToString()));// phan tu cuoi cung
            }
            DALBan = new DALBan(); 
            dataGridView2.DataSource = DALBan.SelectBan();//lay ra ban
            dataGridView2.Show();
            foreach (DataRow item in DALBan.SelectBan().Rows)
            {
                MaBan= (Convert.ToInt32(item["MaBan"].ToString()) +1); // lay ra ptu cuoi cung
            } 
            Check = -1;

                label10.Text ="Tổng Số Bàn :" + DALBan.SelectBan().Rows.Count + " Bàn";
          
            foreach (DataRow item in ThucDon.TongSoMon().Rows)
            {
                label11.Text = "Tổng Số Món :" + item["Soluong"].ToString()+" Món";
            }
            foreach (DataRow item in nhomMon.TongNhomMon().Rows)
            {
                label12.Text = "Tổng Số Nhóm Món :" + item["Soluong"].ToString()+" Nhóm ";
            }

            dataGridView4.DataSource = this.DALNhanvien.Select();
            foreach (DataRow item in this.DALNhanvien.Select().Rows)
            {
                nhanVien.MaNV1= item["MaNV"].ToString();
            }
             
            
            int n = Convert.ToInt32(nhanVien.MaNV1.Substring(6));
            n++;
            
            label17.Text = "595107"+n;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                NhomMon nhomMon1 = new NhomMon();
                nhomMon1.Maloai = Convert.ToInt32(dataGridView3.Rows[Check].Cells[0].Value.ToString());
                nhomMon1.Tenloai = dataGridView3.Rows[Check].Cells[1].Value.ToString();
                nhomMon1.MAU = dataGridView3.Rows[Check].Cells[2].Value.ToString();
                NhomMau nhomMau = new NhomMau(nhomMon1, this);
                nhomMau.Show();

            }

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Check = e.RowIndex;
        }

        

        private void TimKiemNhomMon(string n)
        {
            if (n.Length > 0)
            {
                nhomMon = new DALNhomMon();
                DataTable dataTable = nhomMon.TimKiem(n);
                dataGridView3.DataSource = dataTable;
                dataGridView3.Show();
                foreach (DataRow item in dataTable.Rows)
                {
                    comboBox2.SelectedItem = item["TENLoai"].ToString();
                }
               
            }
            else { LoadDatabase(); }
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Check = e.RowIndex;
            MamON = Convert.ToInt32(dataGridView1.Rows[Check].Cells[0].Value.ToString());
            textBox4.Text = dataGridView1.Rows[Check].Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.Rows[Check].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[Check].Cells[4].Value.ToString();
            string ma =dataGridView1.Rows[Check].Cells[2].Value.ToString();
            TimKiemNhomMon(ma);
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                string Ten = comboBox1.SelectedItem.ToString();
                ThucDon = new DALThucDon();
                DataTable dataTable = ThucDon.TimKiemThucDon(Ten);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Show();
            }
        }

     
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Check = e.RowIndex;
        }

       

   

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

      
      
      
      
        

        

       
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                if (MamON == 1)
                {
                    MamON = 10000;
                }
                try {
                    DTO.ThucDon thucDon = new ThucDon();
                    thucDon.MAMON = (MamON + 1);
                    thucDon.tenmon = textBox4.Text;
                    thucDon.NhomMon = new NhomMon();
                    thucDon.NhomMon.Maloai = Convert.ToInt32(dataGridView3.Rows[(comboBox2.SelectedIndex)].Cells[0].Value.ToString());
                    thucDon.DONGIA = Convert.ToInt32(textBox5.Text);
                    thucDon.DVT = textBox6.Text;
                    this.ThucDon.InsetThucDon(thucDon);
                } catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                

                LamMoi();
                }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (Check > -1)
            {

                DTO.ThucDon thucDon = new ThucDon();
                thucDon.MAMON = Convert.ToInt32(dataGridView1.Rows[Check].Cells[0].Value.ToString());
                this.ThucDon.Delete(thucDon);
                LamMoi();
                
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                int n = comboBox2.SelectedIndex;
                DTO.ThucDon thucDon = new ThucDon();
                thucDon.MAMON = MamON;
                thucDon.tenmon = textBox4.Text;
                thucDon.NhomMon = new NhomMon();
                LoadDatabase();
                thucDon.NhomMon.Maloai = Convert.ToInt32(dataGridView3.Rows[n].Cells[0].Value.ToString());
                thucDon.DONGIA = Convert.ToInt32(textBox5.Text);
                thucDon.DVT = textBox6.Text;
                DALThucDon t = new DALThucDon();
                t.Update(thucDon);
                LamMoi();
            }

        }

      
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string n = guna2TextBox1.Text;
            TimKiemNhomMon(n);
        }

   

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedIndex > 0)
                {
                    nhanVien.MaNV1 = label17.Text.Substring(6);
                    nhanVien.Ten1 = textBox7.Text;
                    nhanVien.SDT1 = textBox8.Text;
                    nhanVien.MaKhau1 = textBox9.Text;

                    nhanVien.Chucvu1 = comboBox3.SelectedItem.ToString();
                    if (radioButton1.Checked)
                    {
                        nhanVien.GioiTinh1 = "Nam";
                    }
                    if (radioButton2.Checked)
                    {
                        nhanVien.GioiTinh1 = "Nữ";
                    }

                    DALNhanvien.InsertInto(nhanVien);
                    LamMoi();
                }
            
            }
            catch { }
           

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string TimKiem = textbox1.Text;
            if (TimKiem.Length > 0)
            {
                ThucDon = new DALThucDon();
                DataTable dataTable = ThucDon.TimKiemThucDon1(TimKiem);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Show();

            }
            else LoadDatabase();
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            NhomMau nhomMau = new NhomMau((MA + 1), this);
            nhomMau.Show();
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                NhomMon nhomMon1 = new NhomMon();
                nhomMon1.Maloai = Convert.ToInt32(dataGridView3.Rows[Check].Cells[0].Value.ToString());
                nhomMon1.Tenloai = dataGridView3.Rows[Check].Cells[1].Value.ToString();
                nhomMon1.MAU = dataGridView3.Rows[Check].Cells[2].Value.ToString();
                nhomMon.Delete(nhomMon1); LoadDatabase();
            }
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                NhomMon nhomMon1 = new NhomMon();
                nhomMon1.Maloai = Convert.ToInt32(dataGridView3.Rows[Check].Cells[0].Value.ToString());
                nhomMon1.Tenloai = dataGridView3.Rows[Check].Cells[1].Value.ToString();
                nhomMon1.MAU = dataGridView3.Rows[Check].Cells[2].Value.ToString();
                NhomMau nhomMau = new NhomMau(nhomMon1, this);
                nhomMau.Show();

            }
        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            LoadDatabase();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            LoadDatabase();
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            LoadDatabase();
        }

        private void guna2Button13_Click_1(object sender, EventArgs e)
        {
            Ban ban = new Ban(this, 2);
            ban.Show();
        }

        private void guna2Button12_Click_1(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                DTO.Ban ban = new DTO.Ban();
                ban.MaBan = Convert.ToInt32(dataGridView2.Rows[Check].Cells[0].Value.ToString());
                ban.TenBan = dataGridView2.Rows[Check].Cells[1].Value.ToString();
                ban.TrangThai = dataGridView2.Rows[Check].Cells[2].Value.ToString();
                if (DALBan.DeleteBan(ban) == 0)
                {
                    MessageBox.Show("Bàn này không thể xóa vui lòng kiểm tra lại tình trạng bàn");
                }
                LoadDatabase();
            }
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                DTO.Ban ban = new DTO.Ban();
                ban.MaBan = Convert.ToInt32(dataGridView2.Rows[Check].Cells[0].Value.ToString());
                ban.TenBan = dataGridView2.Rows[Check].Cells[1].Value.ToString();
                ban.TrangThai = dataGridView2.Rows[Check].Cells[2].Value.ToString();
                Ban ban1 = new Ban(this, ban);
                ban1.Show();
            }
        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {
            Ban ban = new Ban(this);
            ban.Show();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                nhanVien.MaNV1 = label17.Text.Substring(6);
                nhanVien.Ten1 = textBox7.Text;
                nhanVien.SDT1 = textBox8.Text;
                nhanVien.MaKhau1 = textBox9.Text;
               nhanVien.Chucvu1 = comboBox3.SelectedItem.ToString();
                if (radioButton1.Checked)
                {
                    nhanVien.GioiTinh1 = "Nam";
                }
                if (radioButton2.Checked)
                {
                    nhanVien.GioiTinh1 = "Nu";
                }
             
                DALNhanvien.Update(nhanVien);
                LamMoi();
            }
           
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (Check > -1)
            {
                string MaNV = dataGridView4.Rows[Check].Cells[0].Value.ToString();
                DALNhanvien.Delete(MaNV);
                LamMoi();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Check = e.RowIndex;

          
            label17.Text = dataGridView4.Rows[Check].Cells[0].Value.ToString();
            textBox7.Text = dataGridView4.Rows[Check].Cells[1].Value.ToString();
            textBox8.Text = dataGridView4.Rows[Check].Cells[3].Value.ToString();
            textBox9.Text = dataGridView4.Rows[Check].Cells[5].Value.ToString();
            comboBox3.SelectedItem= dataGridView4.Rows[Check].Cells[4].Value.ToString();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
          
       
            LamMoi();
        }

        private void LamMoi()
        {
            LoadDatabase();
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox3.SelectedIndex = 0;
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            comboBox2.SelectedIndex = 0;
        }
    }
}
