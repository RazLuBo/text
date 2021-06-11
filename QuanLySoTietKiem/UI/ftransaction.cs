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
    public partial class ftransaction : Form
    {
        public ftransaction()
        {
            InitializeComponent();
            tbDay_R.Text = DateTime.Today.ToString("dd/MM/yyyy");
            tbDay_G.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }


        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuiTien_Click(object sender, EventArgs e)
        {
            if (!CheckInput(tbMaKH_G.Text, tbMaSo_G.Text, tbTienGui.Text))
                return;
            if (DAO.GuiTienDAO.Instance.insertGoiTien(tbMaNV_G.Text, tbMaKH_G.Text, tbMaSo_G.Text, DateTime.Today, Convert.ToDouble(tbTienGui.Text)))
            {
                StatusLabel_G.Text = "";
                this.Close();
            }
            else
            {
                StatusLabel_G.Text = "Error";
            }
        }

        private bool CheckInput(string MaKH, string MaSo, string Tien)
        {
            
            if (!DAO.SoTietKiemDAO.Instance.GetIdSTKbyIdCus(MaKH, MaSo))
            {
                MessageBox.Show("Khách hàng chưa mở sổ tiết kiệm này");
                return false;
            }
            else
            {
                float i;
                if (float.TryParse(Tien, out i))
                    return true;
                else
                {
                    MessageBox.Show("Nhập số tiền cần gửi/rút");
                    return false;
                }
            }
        }

        private void btRutTien_Click(object sender, EventArgs e)
        {
            if (!CheckInput(tbMaKH_R.Text, tbMaSo_R.Text, tbTienRut.Text))
                return;
            if (DAO.RutTienDAO.Instance.insertRutTien(tbMaNV_R.Text, tbMaKH_R.Text, tbMaSo_R.Text, DateTime.Today, Convert.ToDouble(tbTienRut.Text)))
            {
                StatusLabel_R.Text = "";
                this.Close();
            }
            else
            {
                StatusLabel_R.Text = "Error";
            }
        }

        private void btNhapLai_G_Click(object sender, EventArgs e)
        {
            tbMaKH_G.Text = tbMaNV_G.Text = tbMaSo_G.Text = tbTenKH_G.Text = tbTenNV_G.Text = tbTienGui.Text = "";
        }
    }
}
