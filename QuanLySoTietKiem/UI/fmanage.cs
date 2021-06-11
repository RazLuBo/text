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
        ftransaction transaction = new ftransaction();
        fopen open = new fopen();
        finformation information = new finformation();
        fcustomer customer = new fcustomer();
        fstaff staff = new fstaff();
        fchange change = new fchange();
        faccount account = new faccount();
        freport report = new freport();

        public fmanage()
        {
            InitializeComponent();
        }


        private void transaction_Click(object sender, EventArgs e)
        {
            transaction.Show();
        }


        private void fmanage_Load(object sender, EventArgs e)
        {
        
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btopen_Click(object sender, EventArgs e)
        {
            open.Show();
        }

        private void btinformation_Click(object sender, EventArgs e)
        {
            information.Show();
        }

        private void btcustomer_Click(object sender, EventArgs e)
        {
            customer.Show();
        }

        private void btstaff_Click(object sender, EventArgs e)
        {
            staff.Show();
        }

        private void btchange_Click(object sender, EventArgs e)
        {
            change.Show();
        }

        private void btaccount_Click(object sender, EventArgs e)
        {
            account.Show();
        }

        private void btreport_Click_1(object sender, EventArgs e)
        {
            report.Show();
        }
    }
}
