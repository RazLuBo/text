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
    public partial class finformation : Form
    {
        public finformation()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTSbutton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TTSbutton3_Click(object sender, EventArgs e)
        {

        }

        private void finformation_Load(object sender, EventArgs e)
        {
            LoadSoTietKiem();
        }

        private void LoadSoTietKiem()
        {
            dataGridView1.DataSource = DAO.SoTietKiemDAO.Instance.listSoTietKiem();
        }

        private void TTSbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
