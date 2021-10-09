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
using qlhv.models;

namespace qlhv.form
{
    public partial class frmquanlytaikhoan : Form
    {
        public frmquanlytaikhoan()
        {
            InitializeComponent();
        }

        private void frmquanlytaikhoan_Load(object sender, EventArgs e)
        {
            
        }

        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                        Database=QLDA;
                                                        Trusted_connection=True;");
        connect cn = new connect();

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            cn.myconnect();
            string sql = "SELECT [TenTK],[MatKhau] FROM [qlhocvien].[dbo].[NguoiDung]";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
            /*
            conn.Open();
            string q = "SELECT [TenTK],[MatKhau] FROM [qlhocvien].[dbo].[NguoiDung]";
            SqlCommand cmd = new SqlCommand(q, conn);
            //dung list//dung dataset view
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "taikhoan");
            dgv.DataSource = ds.Tables["taikhoan"];
            conn.Close();
            */
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cn.myconnect();
            string sql = "SELECT [TenTK],[MatKhau] FROM [qlhocvien].[dbo].[NguoiDung] where TenTK like '%"+txtTen.Text+"'";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            cn.myconnect();
            string sql = "SELECT [TenTK],[MatKhau] FROM [qlhocvien].[dbo].[NguoiDung] where TenTK like '%" + txtTen.Text + "'";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        private void dgv_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} kết quả", dgv.Rows.Count);
        }

        private void dgv_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} kết quả", dgv.Rows.Count);

        }
    }
}
