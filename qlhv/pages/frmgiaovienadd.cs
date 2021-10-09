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
    public partial class frmgiaovienadd : Form
    {
        public frmgiaovienadd()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                string sql = "SELECT * where MaLop = '" + magv.Text + "'";
                cn.themthongtingv(magv.Text, tengv.Text, cbgioitinh.Text, dtns.Value, diachi.Text, txtsdt.Text);
                //cn.suathongtinhlop(txtId.Text, txttenlop.Text, txtss.Text, dtns.Value, txtgiohoc.Text, txtngayhoc.Text, txtphong.Text, cbmllop.Text, txthocphi.Text, cbmagv.Text);
                MessageBox.Show("them thanh cong");
                this.DialogResult = DialogResult.Yes;
                cn.myclose();
                this.Close();
            }
            catch
            {
                MessageBox.Show("them khong thanh cong!!");
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
