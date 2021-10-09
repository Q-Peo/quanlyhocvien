using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;*/

namespace qlhv.form
{
    public partial class frmhocphi : Form
    {
        public frmhocphi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
        #region event
        void getdata()
        {
            conn.Open();
            string q = "SELECT [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop FROM [qlhv].[dbo].[HocVien] INNER JOIN [qlhv].[dbo].[Lop] on [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop]";
            SqlCommand cmd = new SqlCommand(q, conn);
            //dung list//dung dataset view
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "hocvien");
            dgv.DataSource = ds.Tables["hocvien"];
            conn.Close();
        }

        private void frmhocphi_Load(object sender, EventArgs e)
        {
            lbmahocvien.Text =  money.Text = lblTenhv.Text = lblns.Text = lblSdt.Text = lblConNo.Text = lblidlop.Text = string.Format("");
            txttkid.Enabled = txttimkiemten.Enabled = false;
            
            /*if (rdchuadong.Checked == true)
                rddadong.Checked = false;
            rddadong.Checked = true;*/
            getdata();
        }
        
        public void hienthitienhoc()
        {
            
            cn.myconnect();
            string sql = "SELECT TienHP FROM [qlhv].[dbo].[Lop] Where MaLop = '" + lblidlop.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//conn là cái SqlConnection của bạn ấy nhé
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                money.Text = dt.Rows[0]["TienHP"].ToString();
                //String.Format("{0:0,0 đ}", money.Text);
                double temp = Convert.ToDouble(money.Text);
                money.Text = Convert.ToString((temp.ToString("#,###") + " đ"));
            }
            cn.myclose();
        }

        public void hienthidadong()
        {

            cn.myconnect();
            string sql = "SELECT DaDong,NgaySinh FROM [qlhv].[dbo].[HocVien] Where MaHV = '" + lbmahocvien.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//conn là cái SqlConnection của bạn ấy nhé
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblns.Text = dt.Rows[0]["NgaySinh"].ToString();
                if (Convert.ToInt32(dt.Rows[0]["DaDong"].ToString()) == 1)
                {
                    lblConNo.Text = string.Format("Da dong tien hoc");
                }
                else lblConNo.Text = string.Format("Chua dong tien hoc");
            }
            cn.myclose();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv.DataSource;
            idx = dgv.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            lbmahocvien.Text = hang["MaHV"].ToString();
            lblTenhv.Text = hang["TenHV"].ToString();
            //lblns.Text = hang["NgaySinh"].ToString();
            lblSdt.Text = hang["SDT"].ToString();
            lblidlop.Text = hang["MaLop"].ToString();
           
            //lblns.Text = string.Format("{dd/MM/yyyy}");
            hienthitienhoc();
            hienthidadong();
        }
        connect cn = new connect();
        private void btnloc_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();

                    if (chkTen.Checked == true)
                    {
                        string sql = "SELECT [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and [TenHV] LIKE N'%" + txttimkiemten.Text + "%'";
                        cn.timkiemthongtintheoTenhvformhocphi(txttimkiemten.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                    if (chkid.Checked == true)
                    {
                        string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and MaHV = '" + txttkid.Text + "'";
                        cn.timkiemthongtintheoIdhvformhocphi(txttkid.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                    if (rddadong.Checked == true)
                    {
                        string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and DaDong = 1";
                        cn.timkiemthongtinhocphi1();
                        dgv.DataSource = cn.Taobang(sql);
                    }
                    if (rdchuadong.Checked == true)
                    {
                        string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and DaDong = 0";
                        cn.timkiemthongtinhocphi0();
                        dgv.DataSource = cn.Taobang(sql);
                    }
                
            }
            catch
            {
                MessageBox.Show("Loi!!");
            }
            cn.myclose();
        }

        private void chkid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkid.Checked == true)
                txttkid.Enabled = true;
            else txttkid.Enabled = false;
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
                txttimkiemten.Enabled = true;
            else txttimkiemten.Enabled = false;
        }

        private void btnuhy_Click(object sender, EventArgs e)
        {
            chkid.Checked = chkTen.Checked = rdchuadong.Checked = rddadong.Checked = false;
            txttimkiemten.Enabled = txttkid.Enabled = false;
            txttimkiemten.ResetText();
            txttkid.ResetText();
            getdata();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbsohocvien.Text = string.Format("Số học viên: {0}", dgv.Rows.Count);
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbsohocvien.Text = string.Format("Số học viên: {0}", dgv.Rows.Count);
        }

        /*#region xuat excel
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            export2Excel(dgv, @"C:\Users\Quan\Desktop\more\kì 1 năm 3\báo cáo cnpm\qlhv", "hocphi");
        }
        #endregion*/
#endregion
    }
}


