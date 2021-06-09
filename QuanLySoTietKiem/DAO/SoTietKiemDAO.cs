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
        public static bool insertSoTietKiem(string id, string idNV, string idKH, string idLS, DateTime ngayMo, DateTime ngayHetHan, double tienGoi, string loaiSo = null)
        {
            return ExecuteQuery.ExecuteNoneQuery("insertSoTietKiem @maSo , @maNV , @maKH , @maLS , @loaiSo , @ngayMoSo , @ngayHetHan , @tienGoi ", new object[] { id, idNV, idKH, idLS, loaiSo, ngayMo, ngayHetHan, tienGoi }) == 3;
        }
        public static DataTable listSoTietKiem()
        {
            return ExecuteQuery.ExecuteReader("select * from SOTIETKIEM");
        }
    }
}
