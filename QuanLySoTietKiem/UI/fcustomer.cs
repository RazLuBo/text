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
    public partial class fcustomer : Form
    {
        BindingSource listCustomer = new BindingSource();
        public fcustomer()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = listCustomer;
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
            LoadCustomer();
            BindingData();
        }

        private void BindingData()
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
            dataGridView1.DataSource = DAO.CustomerDAO.Instance.GetAllCustomerInfo();
        }

        private void KHSbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
