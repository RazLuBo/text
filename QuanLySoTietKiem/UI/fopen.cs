using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySoTietKiem
{
    public partial class fopen : Form
    {
        public fopen()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMoSo_Click(object sender, EventArgs e)
        {
            string idLS = cbLoaiSo.SelectedIndex.ToString();
            if (DAO.SoTietKiemDAO.insertSoTietKiem(tbMaSo.Text, tbMaNV.Text, tbMaKH.Text, idLS, dtMoSo.Value, dtHetHan.Value, Convert.ToDouble(tbTienGoi.Text), cbLoaiSo.SelectedItem.ToString()))
            {
                this.Close();
            }
            else
            {
                StatusLabel.Text = "Error";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MSbutton2_Click(object sender, EventArgs e)
        {

        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLoaiSo.SelectedIndex + 1)
            {
                case 1:
                    tbLaiSuat.Text = "5.5";
                    dtHetHan.Value = dtMoSo.Value.AddMonths(3);
                    dtHetHan.Enabled = false;
                    break;
                case 2:
                    tbLaiSuat.Text = "6.0";
                    dtHetHan.Value = dtMoSo.Value.AddMonths(6);
                    dtHetHan.Enabled = false;
                    break;
                case 3:
                    tbLaiSuat.Text = "0.5";
                    dtHetHan.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
