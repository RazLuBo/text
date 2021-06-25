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
            int idCus = -1;
            if (!DAO.CustomerDAO.Instance.CheckCustomer(tbMaKH.Text))
            {
                DAO.CustomerDAO.Instance.insertCustomer(tbTenKH.Text, tbDiaChi.Text, tbSdt.Text, tbCmnd.Text, 0);
                idCus = DAO.CustomerDAO.Instance.GetIdNewCustomer();
            }
            else
                idCus = Convert.ToInt32(tbMaKH.Text);

            if (!DAO.DoanhThuDAO.Instance.CheckDoanhThu(idLS, dtMoSo.Value))
            {
                DAO.DoanhThuDAO.Instance.insertDoanhThu(cbLoaiSo.SelectedItem.ToString(), dtMoSo.Value);
                idLS = DAO.DoanhThuDAO.Instance.GetIdNewLS().ToString();
            }

            DataRowView rowView = (DataRowView)cbListNV.SelectedItem;

            DTO.Staff staff = new DTO.Staff(rowView.Row);

            if (DAO.SoTietKiemDAO.Instance.insertSoTietKiem(staff.ID, idCus.ToString(), idLS, dtMoSo.Value, dtHetHan.Value, Convert.ToDouble(tbTienGoi.Text), cbLoaiSo.SelectedItem.ToString()))
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

        private void tbMaKH_Leave(object sender, EventArgs e)
        {
            if(tbMaKH.Text != "")
            {
                if(DAO.CustomerDAO.Instance.GetCustomerInfo(tbMaKH.Text) != null)
                {
                    DTO.Customer customer = new DTO.Customer(DAO.CustomerDAO.Instance.GetCustomerInfo(tbMaKH.Text).Rows[0]);
                    tbTenKH.Text = customer.HoTen;
                    tbSdt.Text = customer.SDT;
                    tbDiaChi.Text = customer.DiaChi;
                    tbCmnd.Text = customer.Cmnd;
                    cbListNV.Focus();
                }
            }
        }

        private void tbMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbMaNV_Leave(object sender, EventArgs e)
        {
            if(cbListNV.SelectedText != "")
            {
                DTO.Staff staff = new DTO.Staff(DAO.StaffDAO.Instance.GetStaffInfor(cbListNV.SelectedText).Rows[0]);
                cbTenNV.SelectedText = staff.HoTen;
            }
        }

        private void tbMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void fopen_Load(object sender, EventArgs e)
        {
            cbListNV.DataSource = DAO.StaffDAO.Instance.ListNhanVien();
            cbListNV.DisplayMember = "MaNV";
            cbTenNV.DataSource = DAO.StaffDAO.Instance.ListNhanVien();
            cbTenNV.DisplayMember = "HoTen";
        }

        private void cbListNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTenNV.DataSource != null)
                if(cbListNV.SelectedIndex != -1)
                    cbTenNV.SelectedIndex = cbListNV.SelectedIndex;
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbListNV.DataSource != null)
                if (cbTenNV.SelectedIndex != -1)
                    cbListNV.SelectedIndex = cbTenNV.SelectedIndex;
        }
    }
}
