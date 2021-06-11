using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class RutTienDAO
    {
        private static RutTienDAO instance;

        public static RutTienDAO Instance { get { if (instance == null) instance = new RutTienDAO(); return instance; } set => instance = value; }

        public bool insertRutTien(string idNV, string idKH, string idMaSo, DateTime ngayRut, double tienRut)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertRutTien @maNV , @maKH , @maSo , @ngayRut , @tienRut", new object[] { idNV, idKH, idMaSo, ngayRut, tienRut }) > 0;
        }
    }
}
