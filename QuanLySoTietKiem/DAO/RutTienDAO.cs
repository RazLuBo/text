using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class RutTienDAO
    {
        public static bool insertRutTien(string id, string idNV, string idKH, string idMaSo, DateTime ngayRut, double tienRut)
        {
            return ExecuteQuery.ExecuteNoneQuery("insertRutTien @maRT , @maNV , @maKH , @maSo , @ngayRut , @tienRut", new object[] { id, idNV, idKH, idMaSo, ngayRut, tienRut }) == 4;
        }
    }
}
