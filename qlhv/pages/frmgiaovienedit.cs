using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlhv.pages
{
    public partial class frmgiaovienedit : Form
    {
        public frmgiaovienedit()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        connect cn = new connect();
        public string Magv { set; get; }
        public string Tengv { set; get; }
        public DateTime Dtns { set; get; }
        public string Diachi { set; get; }
        public string Gioitinh { set; get; }
        public string SDT { set; get; }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                string sql = "SELECT * where GiaoVien = '" + magv.Text + "'";
                cn.suathongtingv(magv.Text, tengv.Text, cbgioitinh.Text, dtns.Value, diachi.Text, txtsdt.Text);
                MessageBox.Show("sua thanh cong");
                this.DialogResult = DialogResult.Yes;
                cn.myclose();
                this.Close();
            }
            catch
            {
                MessageBox.Show("sua khong thanh cong!!");
            }
        }

        private void frmgiaovienedit_Load(object sender, EventArgs e)
        {
            magv.Text = Magv;
            tengv.Text = Tengv;
            cbgioitinh.Text = Gioitinh;
            dtns.Value = Dtns;
            diachi.Text = Diachi;
            txtsdt.Text = SDT;
        }
    }
}
