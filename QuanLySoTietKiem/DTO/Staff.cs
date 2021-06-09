using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class Staff
    {
        public String iD;
        public String hoTen;
        public String diaChi;
        public String sDT;
        public String cmnd;

        public string ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public Staff(DataRow row)
        {
            this.ID = row["MaKH"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Cmnd = row["CMNN_or_HoChieu"].ToString();
        }
    }
}
