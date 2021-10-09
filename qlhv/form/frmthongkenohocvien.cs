using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace qlhv.form
{
    public partial class frmthongkenohocvien : Form
    {
        public frmthongkenohocvien()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        private void frmthongkenohocvien_Load(object sender, EventArgs e)
        {
            cn.myconnect();
            string sql = "SELECT MaHV,TenHV,GioiTinh,NgaySinh,DiaChi,SDT,MaLop FROM [qlhv].[dbo].[HocVien] where DaDong = 0";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

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

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            export2Excel(dgv, @"C:\Users\Quan\Desktop\more\kì 1 năm 3\báo cáo cnpm\qlhv\", "filehocphino");
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên còn nợ.", dgv.Rows.Count);
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} học viên còn nợ.", dgv.Rows.Count);
        }
    }
}
