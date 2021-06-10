using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class freport : Form
    {
        BindingSource listReportDay = new BindingSource();
        BindingSource listReportMonth = new BindingSource();
        public freport()
        {
            InitializeComponent();
            dataDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMonth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BCTbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDoanhThuNgay()
        {
            dataDay.DataSource = DAO.DoanhThuDAO.Instance.GetDoanhThuNgay(dtDay.Value);
        }

        private void LoadDoanhThuThang()
        {
            dataMonth.DataSource = DAO.DoanhThuDAO.Instance.GetDoanhThuThang(dtMonth.Value);
        }

        private void LoadDoanhThuThangLoaiSo()
        {
            dataMonth.DataSource = DAO.DoanhThuDAO.Instance.GetDoanhThuThangLoaiSo(dtMonth.Value, cbLoaiSo.SelectedIndex.ToString());
        }

        private void freport_Load(object sender, EventArgs e)
        {
            dataDay.DataSource = listReportDay;
            dataMonth.DataSource = listReportMonth;
            LoadDoanhThuNgay();
            LoadDoanhThuThang();
        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSo.SelectedIndex != -1)
                LoadDoanhThuThangLoaiSo();
            else
                LoadDoanhThuThang();
        }
    }
}
