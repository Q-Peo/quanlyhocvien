using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace qlhv
{
    public class connect
    {
        public SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-LQGSM6R\PEO;Initial Catalog=qlhv;Integrated Security=True");
        public void myconnect() { cnn.Open(); }
        public void myclose() { cnn.Close(); }
        public DataTable Taobang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql,cnn);
            ds.Fill(dt);
            return (dt);
        }
        #region capnhatthongtin
        public void suathongtin(string id, string ten, string gt, DateTime ns, string diachi, string sdt, string mlnd)
        {
            string sql = "UPDATE [qlhv].[dbo].[NguoiDung] SET[MaND] = '" + id + "',[TenND] = N'" + ten + "',[GioiTinh] = N'" + gt + "',[NgaySinh] = '" + ns.ToShortDateString().ToString() + "',[DiaChi] = N'" + diachi + "',[SDT] = '" + sdt + "',[MaLoaiND]='"+ mlnd + "' where[MaGV] = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void themthongtin(string id, string ten, string gt, DateTime ns, string diachi, string sdt, string mlnd)
        {
            string sql = "INSERT INTO [qlhv].[dbo].[NguoiDung] ([MaND],[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND]) VALUES ('" + id + "', N'" + ten + "', N'" + gt + "', '" + ns.ToShortDateString().ToString() + "',N'" + diachi + "','" + sdt + "','" + mlnd + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void xoathongtin(string id)
        {
            string sql = "delete from [qlhv].[dbo].[NguoiDung] where MaND = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoId(string id)
        {
            string sql = "Select * from [qlhv].[dbo].[NguoiDung] where MaND = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoTen(string ten)
        {
            string sql = "Select * from [qlhv].[dbo].[NguoiDung] where [TenND] LIKE N'%" + ten+"%'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoGioiTinh(string gt)
        {
            string sql = "Select * from [qlhv].[dbo].[NguoiDung] where [GioiTinh] LIKE N'" + gt+"'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        #endregion
        #region doimatkhau
        public void doimatkhau(string id, string tk,string mk)
        {
            //ns.ToString("dd/MM/yyyy");
            string sql = "UPDATE [dbo].[NguoiDung] SET [TenTK] = '" + tk + "',[MatKhau] = N'" + mk + "' where [MaND] = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        
        #endregion
        #region quan ly giao vien
        public void suathongtingv(string id, string ten, string gt, DateTime ns, string diachi, string sdt)
        {
            string sql = "UPDATE [qlhv].[dbo].[GiaoVien] SET [MaGV] = '" + id + "',[TenGV] = N'" + ten + "',[GioiTinh] = N'" + gt + "',[NgaySinh] = '" + ns.ToShortDateString().ToString() + "',[DiaChi] = N'" + diachi + "',[SDT] = '" + sdt + "' where [MaGV] = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void themthongtingv(string id, string ten, string gt, DateTime ns, string diachi, string sdt)
        {
            string sql = "INSERT INTO [qlhv].[dbo].[GiaoVien] ([MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT]) VALUES ('" + id + "', N'" + ten + "', N'" + gt + "', '" + ns.ToShortDateString().ToString() + "',N'" + diachi + "','" + sdt + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void xoathongtingv(string id)
        {
            string sql = "delete from [qlhv].[dbo].[GiaoVien] where MaGV = '" + id+"'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoIdgv(string id)
        {
            string sql = "SELECT [MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT] FROM [qlhv].[dbo].[GiaoVien] where MaGV = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoTengv(string ten)
        {
            string sql = "SELECT [MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT] FROM [qlhv].[dbo].[GiaoVien] where [TenGV] LIKE N'%" + ten + "%'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoGioiTinhgv(string gt)
        {
            string sql = "SELECT [MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT] FROM [qlhv].[dbo].[GiaoVien] where [GioiTinh] LIKE N'" + gt + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        #endregion
        #region quan ly hocvien
        public void suathongtinhv(string id, string ten, string gt, DateTime ns, string diachi, string sdt, string mll, string ml)
        {
            string sql = "UPDATE [qlhv].[dbo].[HocVien] SET [MaHV] = '" + id + "',[TenHV] = N'" + ten + "',[GioiTinh] = N'" + gt + "',[NgaySinh] = '" + ns.ToShortDateString().ToString() + "',[DiaChi] = N'" + diachi + "',[SDT] = '" + sdt + "',[MaLoaiLop] = '"+mll+"', [MaLop]='"+ml+ "' where [MaHV] = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void themthongtinhv(string id, string ten, string gt, DateTime ns, string diachi, string sdt, string mll, string ml)
        {
            string sql = "INSERT INTO [dbo].[HocVien]([MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop]) VALUES ('" + id + "', N'" + ten + "', N'" + gt + "', '" + ns.ToShortDateString().ToString() + "',N'" + diachi + "','" + sdt + "','"+mll+"','"+ml+"')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void xoathongtinhv(string id, string ten, string gt, DateTime ns, string diachi, string sdt, string mll, string ml)
        {
            string sql = "delete from [qlhv].[dbo].[HocVien] where MaHV = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoIdhv(string id)
        {
            string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where MaHV = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoTenhv(string ten)
        {
            string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where TenHV LIKE N'%" + ten + "%'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoGioiTinhhv(string gt)
        {
            string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where GioiTinh LIKE N'" + gt + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void xoathongtinhvformqlhv(string id)
        {
            string sql = "delete from [qlhv].[dbo].[HocVien] where MaHV = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoIdhvformhocphi(string id)
        {
            string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and MaHV = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoTenhvformhocphi(string ten)
        {
            string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and TenHV LIKE N'%" + ten + "%'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtinhocphi1()
        {
            string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and [qlhv].[dbo].[HocVien].DaDong = 1";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtinhocphi0()
        {
            string sql = "select [qlhv].[dbo].[HocVien].MaHV,[qlhv].[dbo].[HocVien].TenHV,[qlhv].[dbo].[HocVien].NgaySinh,[qlhv].[dbo].[HocVien].SDT,[qlhv].[dbo].[HocVien].MaLop,[qlhv].[dbo].[Lop].TienHP,[qlhv].[dbo].[HocVien].DaDong FROM [qlhv].[dbo].[HocVien],[qlhv].[dbo].[Lop] where [qlhv].[dbo].[HocVien].[MaLop] = [qlhv].[dbo].[Lop].[MaLop] and [qlhv].[dbo].[HocVien].DaDong = 0";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        #endregion
        #region quanly lop
        public void suathongtinhlop(string id, string ten, string ss, DateTime nbd, string giohoc, string ngayhoc, string phong, string mllp, string tien, string magv)
        {
            string sql = "UPDATE [qlhv].[dbo].[Lop] SET [MaLop] = '" + id + "',[TenLop] = N'" + ten + "',[SiSo] = '" + ss + "',[NgayBatDau] = '" + nbd.ToShortDateString().ToString() + "',[GioHoc] = N'" + giohoc + "',[NgayHoc] = N'" + ngayhoc + "',[Phong] = '" + phong + "', [MaLoaiLop]='" + mllp + "',[TienHP]='" + tien+"',[MaGV] = '" + magv +"' where [MaLop] = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void themthongtinlop(string id, string ten, string ss, DateTime nbd, string giohoc, string ngayhoc, string phong, string mllp, string tien, string magv)
        {
            string sql = "INSERT INTO [qlhv].[dbo].[Lop] ([MaLop],[TenLop],[SiSo],[NgayBatDau],[GioHoc],[NgayHoc],[Phong],[MaLoaiLop],[TienHP],[MaGV]) VALUES ('" + id + "', N'" + ten + "', '" + ss + "', '" + nbd.ToShortDateString().ToString() + "',N'" + giohoc + "',N'"+ ngayhoc + "','" + phong + "','" + mllp + "','" + tien + "', '" + magv + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void xoathongtinlop(string id, string ten, string ss, string nbd, string giohoc, string ngayhoc, string phong, string mllp, string tien, string magv)
        {
            string sql = "delete from [qlhv].[dbo].[Lop] where MaLop = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoSiso(string id, string ten, string ss, string nbd, string giohoc, string ngayhoc, string phong, string mllp, string tien, string magv)
        {
            string sql = "SELECT * FROM [qlhv].[dbo].[Lop] where SiSo = '" + ss + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoIdLop(string id, string ten, string ss, string nbd, string giohoc, string ngayhoc, string phong, string mllp, string tien, string magv)
        {
            string sql = "SELECT * FROM [qlhv].[dbo].[Lop] where MaLop = '"+id+"'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void timkiemthongtintheoIdLopformdiem(string id, string ten)
        {
            string sql = "SELECT [MaLop],[TenLop] FROM [qlhv].[dbo].[Lop] where MaLop = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
