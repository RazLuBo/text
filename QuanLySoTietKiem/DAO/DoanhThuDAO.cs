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
        public static bool insertDoanhThu(string id, string loai, DateTime day)
        {
            return ExecuteQuery.ExecuteNoneQuery("insertDoanhThu @maLS , @loaiSo , @ngay", new object[] { id, loai, day }) == 1;
        }

        public static bool CheckDoanhThu(string id)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return (int)ExecuteQuery.ExecuteScalar("select count (*) from DOANHTHU where MaLS = @maLS", new object[] { id }) == 1;
        }

        public static DataTable GetDoanhThuNgay(DateTime day)
        {
            return ExecuteQuery.ExecuteReader("select * from DOANHTHU where DAY(Ngay) = @ngay and MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { day.Day, day.Month, day.Year});
        }

        public static DataTable GetDoanhThuThang(int thang, int nam)
        {
            return ExecuteQuery.ExecuteReader("select * from DOANHTHU where MONTH(Ngay) = @thang and YEAR(Ngay) = @nam", new object[] { thang, nam });
        }

        public static DataTable GetDoanhThuThangLoaiSo(int thang, int nam, string idLS)
        {
            return ExecuteQuery.ExecuteReader("select * from DOANHTHU where MONTH(Ngay) = @thang and YEAR(Ngay) = @nam and MaLS = @idLS", new object[] { thang, nam, idLS });
        }
    }
}
