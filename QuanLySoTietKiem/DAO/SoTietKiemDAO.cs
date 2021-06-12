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
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertSoTietKiem @maNV , @maKH , @maLS , @loaiSo , @ngayMoSo , @ngayHetHan , @tienGoi ", new object[] { idNV, idKH, idLS, loaiSo, ngayMo, ngayHetHan, tienGoi }) > 0;
        }
        public bool DeleteSTKbyIdCus(int id)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("DELETE SOTIETKIEM where MaKH =" + id) > 0;
        }
        public int GetIdNewSoTietKiem()
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar("select MAX(MaSo) from SOTIETKIEM");
        }
        public bool GetIdSTKbyIdCus(string id, string maSo)
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar(string.Format("select count(*) from SOTIETKIEM where MaKH = {0} and MaSo = {1}", id, maSo)) > 0;
        }
        public DataTable listSoTietKiem()
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from SOTIETKIEM");
        }
    }
}
