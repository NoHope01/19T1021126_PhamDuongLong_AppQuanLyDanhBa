using QLDB.Services;
using QLDB.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsNhomLienLac();
            NapDsTheoNhom();
            NapThongTin();

        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return bdsNhom.Current as NhomViewModel;
            }
        }
        public NguoiViewModel selectedNguoi
        {
            get
            {
                return bdsNguoi.Current as NguoiViewModel;
            }
        }
        void NapDsNhomLienLac()
        {

            var ls = NhomService.GetDanhSachNhom();
            bdsNhom.DataSource = ls;

            gridNhom.DataSource = bdsNhom;



        }
        void NapThongTin()
        {
            if (selectedNguoi != null)
            {
               

                txtTenGoi.Text = selectedNguoi.TenGoi;
                txtEmail.Text = selectedNguoi.Email;
                txtSoDienThoai.Text = selectedNguoi.PhoneNumber;
                txtDiaChi.Text = selectedNguoi.Address;

            }
           
        }

        void NapDsTheoNhom()
        {
            if (selectedNhom != null)
            {
                var ls = NguoiService.GetDanhSachLienLacTheoID(selectedNhom);
                bdsNguoi.DataSource = ls;
                gridnguoi.DataSource = bdsNguoi;
            }



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedNhom != null)
            {
                NapDsTheoNhom();
                NapThongTin(); 


            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapThongTin();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tst1_Click(object sender, EventArgs e)
        {
            var f = new frmThemNhom();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsTheoNhom();
            }
        }
    }
}
