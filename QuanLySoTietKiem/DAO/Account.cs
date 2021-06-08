using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public static class Account
    {
        public static string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
        public static bool Login(string Username, string Password)
        {
            string EncryptedPass = Encrypt(Password);
            int data = (int)ExecuteQuery.ExecuteScalar("searchAccount @tenDN , @matKhau", new object[] { Username, EncryptedPass });
            return data == 1;
        }
        public static int ChangePassword(string Username, string oldPass, string newPass)
        {
            string EncryptedOldPass = Encrypt(oldPass);
            string EncryptedNewPass = Encrypt(newPass);
            return ExecuteQuery.ExecuteNoneQuery("QLKS_ChangePassword @Username , @OldPassword , @NewPassword",
                new object[] { Username, EncryptedOldPass, EncryptedNewPass });
        }

        public static bool insertAccount(string Username, string Password, string DisplayName = null, int Type = 1)
        {
            string EncryptedPass = Encrypt(Password);
            if (DisplayName == null) DisplayName = Username;
            int data = ExecuteQuery.ExecuteNoneQuery("insertAccount @tenHienThi , @tenDN , @matKhau , @loai", new object[] { DisplayName, Username, EncryptedPass, Type });
            return data == 1;
        }

        public static DataTable GetStaffInfor(string Username)
        {
            return ExecuteQuery.ExecuteReader("QLKS_GetStaffInfo @Username", new object[] { Username });
        }
    }
}
