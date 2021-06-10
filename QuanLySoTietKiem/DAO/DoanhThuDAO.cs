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
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertDoanhThu @loaiSo , @ngay", new object[] { loai, day }) == 1;
        }

        public int GetIdNewLS()
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar("SELECT MAX(MaLS) FROM [dbo].[DOANHTHU]");
        }

        public bool CheckDoanhThu(string id)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return (int)ExecuteQuery.Instance.ExecuteScalar("select count (*) from DOANHTHU where MaLS = @maLS", new object[] { id }) == 1;
        }

        public DataTable GetDoanhThuNgay(DateTime day)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from DOANHTHU where DAY(Ngay) = @ngay and MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { day.Day, day.Month, day.Year});
        }

        public DataTable GetDoanhThuThang(DateTime dt)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from DOANHTHU where MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { dt.Month, dt.Year });
        }

        public DataTable GetDoanhThuThangLoaiSo(DateTime dt, string idLS)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from DOANHTHU where MONTH(Ngay) = @thang and YEAR(Ngay) = @nam and MaLS = @idLS", new object[] { dt.Month, dt.Year, idLS });
        }
    }
}
