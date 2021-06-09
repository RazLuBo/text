using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DTO
{
    public class SoTietKiem
    {
        string iD;
        string iDNhanVien;
        string iDKhachHang;
        string iDLS;
        string type;
        DateTime ngayMoSo;
        DateTime ngayHetHan;
        double tienGoi;

        public string ID { get => iD; set => iD = value; }
        public string IDNhanVien { get => iDNhanVien; set => iDNhanVien = value; }
        public string IDKhachHang { get => iDKhachHang; set => iDKhachHang = value; }
        public string IDLS { get => iDLS; set => iDLS = value; }
        public string Type { get => type; set => type = value; }
        public DateTime NgayMoSo { get => ngayMoSo; set => ngayMoSo = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public double TienGoi { get => tienGoi; set => tienGoi = value; }

        public SoTietKiem(DataRow row)
        {
            this.ID = row["MaSo"].ToString();
            this.IDNhanVien = row["MaNV"].ToString();
            this.IDKhachHang = row["MaKH"].ToString();
            this.IDLS = row["MaLS"].ToString();
            this.Type = row["LoaiSo"].ToString();
            this.NgayMoSo = (DateTime)row["NgayMoSo"];
            this.NgayHetHan = (DateTime)row["NgayHetHan"];
        }

        public SoTietKiem(string id, string idNv, string idKh, string idLs, string type, DateTime ngaymo, DateTime ngayhethan, double tiengoi)
        {
            this.ID = id;
            this.IDNhanVien = idNv;
            this.IDKhachHang = idKh;
            this.IDLS = idLs;
            this.Type = type;
            this.NgayMoSo = ngaymo;
            this.NgayHetHan = ngayhethan;
            this.TienGoi = tiengoi;
        }
    }
}
