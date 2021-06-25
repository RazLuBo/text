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
    public partial class faccount : Form
    {
        public faccount()
        {
            InitializeComponent();
        }

        private void TKbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TKbutton1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Tên đăng nhập" || tbUsername.Text == "")
            {
                StatusLabel.Text = "Tên đăng nhập không được để trống.";
                tbUsername.Focus();
                return;
            }
            if (tbPassword.Text == "Mật khẩu" || tbPassword.Text == "")
            {
                StatusLabel.Text = "Mật khẩu không được để trống.";
                tbPassword.Focus();
                return;
            }
            if(DAO.Account.Instance.insertAccount(tbUsername.Text, tbPassword.Text, cbType.SelectedIndex + 1))
                this.Close();
            else
            {
                StatusLabel.Text = "Tên đăng nhập bị trùng";
                return;
            }    
        }
    }
}
