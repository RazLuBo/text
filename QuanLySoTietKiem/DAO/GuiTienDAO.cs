using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class GuiTienDAO
    {
        public static bool insertGoiTien(string id, string idNV, string idKH, string idMaSo, DateTime ngayGoi, double tienGoi)
        {
            return ExecuteQuery.ExecuteNoneQuery("insertGoiTien @maGT , @maNV , @maKH , @maSo , @ngayGoi , @tienGoi", new object[] { id, idNV, idKH, idMaSo, ngayGoi, tienGoi }) == 3;
        }
    }
}
