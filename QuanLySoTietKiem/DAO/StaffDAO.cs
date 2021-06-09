using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    class StaffDAO
    {
        public static bool insertStaff(string id, string hoten, string diachi, string sdt, string cmnd)
        {
            return ExecuteQuery.ExecuteNoneQuery("insertStaff @maNV , @hoTen , @diaChi , @sDT , @cmnd", new object[] { id, hoten, diachi, sdt, cmnd }) == 1;
        }

        public static DataTable listNhanVien()
        {
            return ExecuteQuery.ExecuteReader("select * from NHANVIEN");
        }

        public static DataTable GetStaffInfor(string id)
        {
            return ExecuteQuery.ExecuteReader("GetStaffInfo @maNV", new object[] { id });
        }
    }
}
