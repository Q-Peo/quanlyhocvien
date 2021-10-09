using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlhv.form
{
    public partial class frmdiemhv : Form
    {
        public frmdiemhv()
        {
            InitializeComponent();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        connect cn = new connect();
        public void hienthi()
        {
            cn.myconnect();
            string sql = "SELECT MaLop,TenLop FROM [qlhv].[dbo].[Lop]";
            dgvlop.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        private void frmdiemhv_Load(object sender, EventArgs e)
        {
            hienthi();
            lblMaLop.Text = lblTenLop.Text = lblMaHV.Text = lblTenHV.Text = diemtb.Text =  diemdoc.Text = diemnghe.Text = diemnoi.Text = diemviet.Text = string.Format("");
        }

        private void dgvlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvlop.DataSource;
            idx = dgvlop.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            lblMaLop.Text = hang["MaLop"].ToString();
            lblTenLop.Text = hang["TenLop"].ToString();
            //txtMaLop.Text = hang["MaLop"].ToString();
            hienthidanhsach();
        }

        public void hienthidanhsach()
        {
            cn.myconnect();
            string sql = "SELECT MaHV,TenHV,GioiTinh FROM [qlhv].[dbo].[HocVien] Where MaLop = '"+lblMaLop.Text+"'";
            dgvhv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        public void hienthidiem()
        {
            cn.myconnect();
            string sql = "SELECT DiemNghe,DiemNoi,DiemDoc,DiemViet,DTB FROM [qlhv].[dbo].[DiemThi],[qlhv].[dbo].[HocVien] Where HocVien.MaHV = DiemThi.MaHV and DiemThi.MaHV = '"+lblMaHV.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//conn là cái SqlConnection của bạn ấy nhé
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                diemnghe.Text = dt.Rows[0]["DiemNghe"].ToString();
                diemnoi.Text = dt.Rows[0]["DiemNoi"].ToString();
                diemdoc.Text = dt.Rows[0]["DiemDoc"].ToString();
                diemviet.Text = dt.Rows[0]["DiemViet"].ToString();
                diemtb.Text = dt.Rows[0]["DTB"].ToString();
            }
            cn.myclose();
        }

        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
        private void dgvhv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvhv.DataSource;
            idx = dgvhv.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            lblMaHV.Text = hang["MaHV"].ToString();
            lblTenHV.Text = hang["TenHV"].ToString();
            hienthidiem();

        }

        private void dgvhv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: <num> học viên", dgvhv.Rows.Count);
        }

        private void dgvhv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: <num> học viên", dgvhv.Rows.Count);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                if (txtMaLop.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Chua nhap ma lop!!");
                }
                else
                {
                    string sql = "SELECT [MaLop],[TenLop] FROM [qlhv].[dbo].[Lop] where MaLop = '" + txtMaLop.Text + "'";
                    cn.timkiemthongtintheoIdhvformhocphi(txtMaLop.Text);
                    dgvlop.DataSource = cn.Taobang(sql);
                }
            }
            catch
            {
                MessageBox.Show("Loi!!");
            }
            cn.myclose();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaLop.ResetText();
            hienthi();
        }
    }
}
