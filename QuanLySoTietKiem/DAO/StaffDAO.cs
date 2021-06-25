using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance { 
            get {
                if (instance == null)
                    instance = new StaffDAO();
                return instance; 
            } 
            private set => instance = value; 
        }

        public bool InsertStaff(string hoten, string diachi, string sdt, string cmnd)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("insert into NHANVIEN(HoTen, DiaChi, SDT, CMNN_or_HoChieu, LamViec)values (N'{0}', N'{1}', '{2}', '{3}', 1)", hoten, diachi, sdt, cmnd)) > 0;
        }

        public DataTable ListNhanVien()
        {
            return ExecuteQuery.Instance.ExecuteReader("select MaNV [Mã nhân viên], HoTen [Họ tên], DiaChi [Địa chỉ], SDT [Số điện thoại], CMNN_or_HoChieu [CMND] from NHANVIEN where LamViec = 1");
        }

        public bool DeleteStaff(string id)
        {
            return false;
        }

        public bool UpdateStaffInfo(string id, string Hoten, string DiaChi, string SDT, string Cmnd)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(string.Format("update NHANVIEN set HoTen = '{0}', DiaChi = '{1}', SDT = '{2}', CMNN_or_HoChieu = '{3}' where MaNV = {4}", Hoten, DiaChi, SDT, Cmnd, id)) > 0;
        }

        public DataTable GetStaffInfor(string id)
        {
            return ExecuteQuery.Instance.ExecuteReader("GetStaffInfo @maNV", new object[] { id });
        }

        public bool removeStaff(DTO.Staff staff)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("removeStaff @maNV", new object[] { staff.ID }) > 0;
        }
    }
}
