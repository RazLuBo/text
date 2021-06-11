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
    public partial class fcustomer : Form
    {
        BindingSource listCustomer = new BindingSource();
        public fcustomer()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GTbutton3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void KHbutton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fcustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listCustomer;
            LoadCustomer();
            AddBindingData();
        }

        private void AddBindingData()
        {
            tbCmnd.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "CMNN_or_HoChieu", true, DataSourceUpdateMode.Never));
            tbDiaChi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            tbSdt.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            tbTenKH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            tbMaKH.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            tbSodu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoDu", true, DataSourceUpdateMode.Never));
        }

        private void LoadCustomer()
        {
            listCustomer.DataSource = DAO.CustomerDAO.Instance.GetAllCustomerInfo();
        }

        private void KHSbutton1_Click(object sender, EventArgs e)
        {

        }

        private void KHSbutton3_Click(object sender, EventArgs e)
        {
            int idCus;
            if(int.TryParse(tbMaKH.Text, out idCus))
            {
                DAO.SoTietKiemDAO.Instance.DeleteCustomer(idCus);
                if (DAO.CustomerDAO.Instance.DeleteCustomer(idCus))
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa khách hàng");
                }
            }
        }

        private void tbSodu_TextChanged(object sender, EventArgs e)
        {
            float Sodu;
            if(float.TryParse(tbSodu.Text, out Sodu))
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                tbSodu.Text = Sodu.ToString("c", culture);
            }
        }
    }
}
