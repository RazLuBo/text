using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;

        public static DoanhThuDAO Instance { get { if (instance == null) instance = new DoanhThuDAO(); return instance; } set => instance = value; }

        public bool insertDoanhThu(string loai, DateTime day)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("insert into DOANHTHU (LoaiSo, TongThu, TongChi, ChenhLechThuChi, SoMo, SoDong, ChenhLechSoMD, Ngay)values (N'{0}', 0, 0, 0, 0, 0, 0, '{1}')", loai, day)) > 0;
        }

        public int GetIdNewLS()
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar("SELECT MAX(MaLS) FROM [dbo].[DOANHTHU]");
        }

        public bool CheckDoanhThu(string loaiso, DateTime date)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return (int)ExecuteQuery.Instance.ExecuteScalar("select count (*) from DOANHTHU where LoaiSo = @loaiso and Ngay = @ngay", new object[] { loaiso, date }) == 1;
        }

        public DataTable GetDoanhThuNgay(DateTime day)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from DOANHTHU where DAY(Ngay) = @ngay and MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { day.Day, day.Month, day.Year});
        }

        public DataTable GetDoanhThuThang(DateTime dt)
        {
            return ExecuteQuery.Instance.ExecuteReader(string.Format("select MaLS [Mã loại sổ], LoaiSo [Loại sổ], TongThu [Tổng thu], TongChi [Tổng chi], ChenhLechThuChi [Chênh lệch thu chi], SoMo [Sổ mở], SoDong [Sổ đóng], ChenhLechSoMD [Chênh lệch sổ] from DOANHTHU where MONTH(Ngay) = {0} and YEAR(Ngay) = {1}", dt.Month, dt.Year));
        }

        public DataTable GetDoanhThuThangLoaiSo(DateTime dt, string idLS)
        {
            return ExecuteQuery.Instance.ExecuteReader(string.Format("select * from DOANHTHU where MONTH(Ngay) = {0} and YEAR(Ngay) = {1} and MaLS = {2}", dt.Month, dt.Year, idLS));
        }
    }
}
