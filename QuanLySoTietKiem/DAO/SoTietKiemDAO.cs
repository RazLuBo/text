using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class SoTietKiemDAO
    {
        private static SoTietKiemDAO instance;

        public static SoTietKiemDAO Instance { get { if (instance == null) instance = new SoTietKiemDAO();  return instance; } set => instance = value; }

        public bool insertSoTietKiem(string idNV, string idKH, string idLS, DateTime ngayMo, DateTime ngayHetHan, double tienGoi, string loaiSo = null)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertSoTietKiem @maNV , @maKH , @maLS , @loaiSo , @ngayMoSo , @ngayHetHan , @tienGoi ", new object[] { idNV, idKH, idLS, loaiSo, ngayMo, ngayHetHan, tienGoi }) == 3;
        }
        public DataTable listSoTietKiem()
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from SOTIETKIEM");
        }
    }
}
