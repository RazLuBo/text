using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class GuiTienDAO
    {
        private static GuiTienDAO instance;

        public static GuiTienDAO Instance { get { if (instance == null) instance = new GuiTienDAO(); return instance; } set => instance = value; }

        public bool insertGoiTien(string idNV, string idKH, string idMaSo, DateTime ngayGoi, double tienGoi)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery("insertGoiTien @maNV , @maKH , @maSo , @ngayGoi , @tienGoi", new object[] { idNV, idKH, idMaSo, ngayGoi, tienGoi }) == 3;
        }
    }
}
