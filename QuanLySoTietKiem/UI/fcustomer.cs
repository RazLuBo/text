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
        public fcustomer()
        {
            InitializeComponent();
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = DAO.CustomerDAO.GetAllCustomerInfo();
        }

        private void KHSbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
