using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class CustomerDAO
    {
        public static bool insertCustomer(string id, string hoten, string diachi, string sdt, string cmnd, double sodu)
        {
            return ExecuteQuery.ExecuteNoneQuery("insertCustomer @maKH , @hoTen , @diaChi , @sDT , @cmnd , @soDu", new object[] { id, hoten, diachi, sdt, cmnd, sodu }) == 1;
        }

        public static DataTable GetCustomerInfo(int id)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return ExecuteQuery.ExecuteReader("searchCustomer @maKH", new object[] { id });
        }

        public static DataTable GetAllCustomerInfo()
        {
            return ExecuteQuery.ExecuteReader("select * from KHACHHANG");
        }
    }
}
