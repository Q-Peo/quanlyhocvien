using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace qlhv.form
{
    public partial class frmbchvtheothang : Form
    {
        public frmbchvtheothang()
        {
            InitializeComponent();
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
            conn.ConnectionString = Properties.Settings.Default.qlhvConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "chungchitheothang";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@NgayCap", dtngay.Value.Date));
            //khai bao dataset chua du lieu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //thietlapbapcao
            rpvbaocaohv.ProcessingMode = ProcessingMode.Local;
            rpvbaocaohv.LocalReport.ReportPath = "rptbchv.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "chungchihocvien";
                rds.Value = ds.Tables[0];
                //gan len mau bao cao
                rpvbaocaohv.LocalReport.DataSources.Clear();
                rpvbaocaohv.LocalReport.DataSources.Add(rds);
                rpvbaocaohv.RefreshReport();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmbchvtheothang_Load(object sender, EventArgs e)
        {
            this.rpvbaocaohv.RefreshReport();
        }
    }
}
