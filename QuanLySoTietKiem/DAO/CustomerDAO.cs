﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance { get { if (instance == null) instance = new CustomerDAO(); return instance; } set => instance = value; }

        public bool insertCustomer(string hoten, string diachi, string sdt, string cmnd, double sodu)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertCustomer @hoTen , @diaChi , @sDT , @cmnd , @soDu", new object[] { hoten, diachi, sdt, cmnd, sodu }) > 0;
        }

        public bool UpdateCustomer(string HoTen, string DiaChi, string SDT, string Cmnd, int MaKH)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(string.Format("update KHACHHANG set HoTen = '{0}', DiaChi = '{1}', SDT = '{2}', CMNN_or_HoChieu = '{3}' where MaKH = {4}", HoTen, DiaChi, SDT, Cmnd, MaKH)) > 0;
        }

        public int GetIdNewCustomer()
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar("SELECT MAX(MaKH) FROM [dbo].[KHACHHANG]");
        }

        public bool DeleteCustomer(int id)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("DELETE KHACHHANG where MaKH =" + id) > 0;
        }

        public DataTable GetCustomerInfo(string id)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return ExecuteQuery.Instance.ExecuteReader("searchCustomer @maKH", new object[] { id });
        }

        public bool CheckCustomer(string id)
        {
            ///return Name, birthday, PhoneNumber, Sex, IdentityNumber, Passport, Addr, Note, ArrivalDate
            return (int)ExecuteQuery.Instance.ExecuteScalar("select count (*) from KHACHHANG where MaKH = @maKH", new object[] { id }) > 0;
        }

        public DataTable GetAllCustomerInfo()
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from KHACHHANG");
        }
    }
}
