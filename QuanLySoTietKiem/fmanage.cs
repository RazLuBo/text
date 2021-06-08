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
    public partial class fmanage : Form
    {
        public fmanage()
        {
            InitializeComponent();
        }

     

        

        private void button1_Click(object sender, EventArgs e)
        {
            ftransaction f = new ftransaction();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void fmanage_Load(object sender, EventArgs e)
        {
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fopen f = new fopen();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            finformation f = new finformation();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fcustomer f = new fcustomer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fstaff f = new fstaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fchange f = new fchange();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            faccount f = new faccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            freport f = new freport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
