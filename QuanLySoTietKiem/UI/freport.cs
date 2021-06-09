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

        private void freport_Load(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dataDay.DataSource = DAO.DoanhThuDAO.GetDoanhThuNgay(dateTime.Value);
                    break;
                case 1:
                    if (cbLoaiSo.SelectedIndex == -1)
                        dataMonth.DataSource = DAO.DoanhThuDAO.GetDoanhThuThang(
                            Convert.ToInt32(tbBCT_Thang.Text), Convert.ToInt32(tbBCT_Nam.Text));
                    else
                        dataMonth.DataSource = DAO.DoanhThuDAO.GetDoanhThuThangLoaiSo(
                            Convert.ToInt32(tbBCT_Thang.Text), Convert.ToInt32(tbBCT_Nam.Text), cbLoaiSo.SelectedIndex.ToString());
                    break;
            }
        }
    }
}
