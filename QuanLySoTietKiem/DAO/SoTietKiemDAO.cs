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

        public bool insertSoTietKiem(string idNV, string idKH, double idLS, DateTime ngayMo, double tienGoi)
        {
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("INSERT INTO [dbo].[SOTIETKIEM]([MaLS],[MaKH],[MaNV],[NgayMo],[TienGui])VALUES({0},{1},{2},'{3}',{4})", idLS, idKH, idNV, ngayMo, tienGoi)) > 0;
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
            return ExecuteQuery.Instance.ExecuteReader("select MaSo [Mã sổ], MaNV [Mã nhân viên], MaKH [Mã khách hàng], LOAISO.TenLS [Loại sổ], NgayMo [Ngày mở], TienGui [Tiền gửi] from SOTIETKIEM, LOAISO where SOTIETKIEM.MaLS = LOAISO.MaLS");
        }

        //public DataTable getSTKbyID(String id)
        //{
        //    return 
        //}
    }
}
