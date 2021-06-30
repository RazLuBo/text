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
    public partial class fchange : Form
    {
        DTO.LoaiSo loai;
        public fchange()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fchange_Load(object sender, EventArgs e)
        {
            LoadCb();
        }

        private void LoadCb()
        {
            cbLoaiSo.DataSource = DAO.LoaiSoDAO.Instance.GetListLoaiSo();
            cbLoaiSo.DisplayMember = "TenLS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView data = (DataRowView)cbLoaiSo.SelectedItem;
            loai = new DTO.LoaiSo(data.Row);
            tbTenKyHan.Text = loai.TenLS;
            tbLaiSuat.Text = (loai.LaiSuat * 100).ToString("0.00");

            if(loai.ThoiHan < 30)
            {
                tbKyHan.Text = loai.ThoiHan.ToString();
                cbKyHan.SelectedIndex = 0;
            }
            else if(loai.ThoiHan < 360)
            {
                tbKyHan.Text = ((int)(loai.ThoiHan / 30)).ToString();
                cbKyHan.SelectedIndex = 1;
            }
            else
            {
                tbKyHan.Text = ((int)(loai.ThoiHan / 360)).ToString();
                cbKyHan.SelectedIndex = 2;
            }
            tbTienGuiTT.Text = loai.TienGuiTT.ToString();
            tbTienMoTT.Text = loai.ToiThieu.ToString();
            //tbThoiGianTT.Text = loai.ThoiHanTT.ToString();
            if (loai.ThoiHanTT < 30)
            {
                tbThoiGianTT.Text = loai.ThoiHanTT.ToString();
                cbThoiGianTT.SelectedIndex = 0;
            }
            else if (loai.ThoiHanTT < 360)
            {
                tbThoiGianTT.Text = ((int)(loai.ThoiHanTT / 30)).ToString();
                cbThoiGianTT.SelectedIndex = 1;
            }
            else
            {
                tbThoiGianTT.Text = ((int)(loai.ThoiHanTT / 360)).ToString();
                cbThoiGianTT.SelectedIndex = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTO.LoaiSo so = new DTO.LoaiSo();
            if(tbTenKyHan.Text != "" && tbThoiGianTT.Text != "" && tbTienGuiTT.Text != ""
                && tbTienMoTT.Text != "" && tbLaiSuat.Text != "" && tbKyHan.Text != "")
            {
                double b;
                so.TenLS = tbTenKyHan.Text;
                //loai.ThoiHan = Convert.ToDouble(tbKyHan.Text);
                if (double.TryParse(tbKyHan.Text, out b))
                {
                    switch (cbKyHan.SelectedIndex)
                    {
                        case 0:
                            so.ThoiHan = b;
                            break;
                        case 1:
                            so.ThoiHan = b * 30;
                            break;
                        case 2:
                            so.ThoiHan = b * 360;
                            break;
                        default:
                            return;
                    }
                }
                else return;
                if (double.TryParse(tbLaiSuat.Text, out b))
                    so.LaiSuat = b / 100;
                else return;
                if (double.TryParse(tbTienGuiTT.Text, out b))
                    so.TienGuiTT = b;
                else return;
                if (double.TryParse(tbTienMoTT.Text, out b))
                    so.ToiThieu = b;
                else return;
                if (double.TryParse(tbThoiGianTT.Text, out b))
                {
                    switch (cbThoiGianTT.SelectedIndex)
                    {
                        case 0:
                            so.ThoiHanTT = b;
                            break;
                        case 1:
                            so.ThoiHanTT = b * 30;
                            break;
                        case 2:
                            so.ThoiHanTT = b * 360;
                            break;
                        default:
                            return;
                    }
                }
                   // so.ThoiHanTT = b;
                else return;
                so.MaLS = loai.MaLS;
                DAO.LoaiSoDAO.Instance.UpdateLS(so);
                LoadCb();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double thoihan, laisuat, tienguiTT, thoigianTT, tienmoTT;
            string ten = tbTenKyHan.Text;
            if(double.TryParse(tbTienGuiTT.Text, out tienguiTT)
                && double.TryParse(tbTienMoTT.Text, out tienmoTT)
                && double.TryParse(tbLaiSuat.Text, out laisuat)
                && double.TryParse(tbKyHan.Text, out thoihan)
                && double.TryParse(tbThoiGianTT.Text, out thoigianTT))
            {
                switch (cbThoiGianTT.SelectedIndex)
                {
                    case 0:
                        //so.ThoiHanTT = thoigianTT;
                        break;
                    case 1:
                        thoigianTT *= 30;
                        break;
                    case 2:
                        thoigianTT *= 360;
                        break;
                    default:
                        return;
                }

                switch (cbKyHan.SelectedIndex)
                {
                    case 0:
                        //thoihan = b;
                        break;
                    case 1:
                        thoihan *= 30;
                        break;
                    case 2:
                        thoihan *= 360;
                        break;
                    default:
                        return;
                }

                DTO.LoaiSo loai = new DTO.LoaiSo(0, thoihan, tienmoTT, laisuat / 100, ten, tienguiTT, thoigianTT);
                DAO.LoaiSoDAO.Instance.Insert(loai);
                MessageBox.Show("Thêm thành công");
                LoadCb();
            }
            else
            {
                return;
            }
        }
    }
}
