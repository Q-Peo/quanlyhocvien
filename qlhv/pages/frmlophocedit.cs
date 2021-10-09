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
    public partial class frmlophocedit : Form
    {
        public frmlophocedit()
        {
            InitializeComponent();
        }

        connect cn = new connect();
        public string Id { set; get; }
        public string mall { set; get; }
        public DateTime Dtns { set; get; }
        public string giohoc { set; get; }
        public string tenlop { set; get; }
        public string siso { set; get; }
        public string phong { set; get; }
        public string tienhoc { set; get; }
        public string magv { set; get; }
        public string ngayhoc { set; get; }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                    string sql = "SELECT * where MaLop = '" + txtId.Text + "'";
                    //cn.themthongtinlop(txtId.Text, txttenlop.Text, txtss.Text, dtns.Value, txtgiohoc.Text, txtngayhoc.Text, txtphong.Text, cbmllop.Text, txthocphi.Text, cbmagv.Text);
                    cn.suathongtinhlop(txtId.Text, txttenlop.Text, txtss.Text, dtns.Value, txtgiohoc.Text, txtngayhoc.Text, txtphong.Text, cbmllop.Text, txthocphi.Text, cbmagv.Text);
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

        private void frmlophoceditsua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlhvDataSet6.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qlhvDataSet6.GiaoVien);
            txtId.Text = Id;
            cbmllop.Text = mall;
            txtss.Text = siso;
            txttenlop.Text = tenlop;
            dtns.Value = Dtns;
            txtgiohoc.Text = giohoc;
            txthocphi.Text = tienhoc;
            txtphong.Text = phong;
            txtngayhoc.Text = ngayhoc;
            cbmagv.Text = magv;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
