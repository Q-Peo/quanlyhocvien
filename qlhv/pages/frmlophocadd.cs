using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using qlhv.form;

namespace qlhv.pages
{
    public partial class frmlophocadd : Form
    {
        public frmlophocadd()
        {
            InitializeComponent();
        }
        //string id = frmlop.idlop;
        connect cn = new connect();
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                        cn.myconnect();
                        string sql = "SELECT * where MaLop = '" + txtId.Text + "'";
                        cn.themthongtinlop(txtId.Text, txttenlop.Text, txtss.Text, dtns.Value, txtgiohoc.Text, txtngayhoc.Text, txtphong.Text, cbmllop.Text, txthocphi.Text, cbmagv.Text);
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
        private void frmlophocedit_Load(object sender, EventArgs e)
        {
            

            // TODO: This line of code loads data into the 'qlhvDataSet1.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qlhvDataSet1.GiaoVien);
            // TODO: This line of code loads data into the 'qlhvDataSet.LoaiLop' table. You can move, or remove it, as needed.
            this.loaiLopTableAdapter.Fill(this.qlhvDataSet.LoaiLop);

        }
        
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loaiLopTableAdapter.FillBy(this.qlhvDataSet.LoaiLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loaiLopTableAdapter.FillBy1(this.qlhvDataSet.LoaiLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loaiLopTableAdapter.FillBy2(this.qlhvDataSet.LoaiLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
