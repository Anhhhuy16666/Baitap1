using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTS
{
    public partial class FrmHoso : Form
    {
        public int stato;
        public FrmHoso()
        {
            InitializeComponent();
        }

        private void rgthisinh_Click(object sender, EventArgs e)
        {

        }

        private void rgthisinh_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            rtmahots.Text = rgthisinh.SelectedRows[0].Cells[0].Value.ToString();
            rthotents.Text = rgthisinh.SelectedRows[0].Cells[1].Value.ToString();
            rddngaysinhts.Text = rgthisinh.SelectedRows[0].Cells[2].Value.ToString();
            rtsbdts.Text = rgthisinh.SelectedRows[0].Cells[4].Value.ToString();
            rtsdtts.Text = rgthisinh.SelectedRows[0].Cells[5].Value.ToString();
            rthuyents.Text = rgthisinh.SelectedRows[0].Cells[6].Value.ToString();
            rttinhts.Text = rgthisinh.SelectedRows[0].Cells[7].Value.ToString();
            rttruongts.Text = rgthisinh.SelectedRows[0].Cells[8].Value.ToString();
            rtnganhts.Text = rgthisinh.SelectedRows[0].Cells[9].Value.ToString();
            rtkvutts.Text = rgthisinh.SelectedRows[0].Cells[10].Value.ToString();
            rtdtutts.Text = rgthisinh.SelectedRows[0].Cells[11].Value.ToString();
            if (Boolean.Parse(rgthisinh.SelectedRows[0].Cells[3].Value.ToString()) == true)
            {
                rbbnam.IsChecked = true;
                rbbnu.IsChecked = false;
            }
            else
            {
                rbbnam.IsChecked = false;
                rbbnu.IsChecked = true;
            }
        }

        private void FrmHoso_Load(object sender, EventArgs e)
        {
            stato = 0;
            QLEntities ts = new QLEntities();
            rgthisinh.DataSource = ts.THISINH_SelectAll();
        }

        private void rbxoats_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá hồ sơ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLEntities hsts = new QLEntities();
                hsts.THISINH_Delete(rtmahots.Text);
                rgthisinh.DataSource = hsts.THISINH_SelectAll();
            }
        }

        private void rbsuats_Click(object sender, EventArgs e)
        {
            stato = 1;
            rtmahots.ReadOnly = false;
            rthotents.ReadOnly = false;
            rddngaysinhts.ReadOnly = false;
            rtsbdts.ReadOnly = false;
            rtsdtts.ReadOnly = false;
            rthuyents.ReadOnly = false;
            rbbnam.ReadOnly = false;
            rbbnu.ReadOnly = false;
            rttinhts.ReadOnly = false;
            rttruongts.ReadOnly = false;
            rtnganhts.ReadOnly = false;
            rtkvutts.ReadOnly = false;
            rtdtutts.ReadOnly = false;
        }

        private void rbthemts_Click(object sender, EventArgs e)
        {
            stato = 2;
            rtmahots.ReadOnly = false;
            rthotents.ReadOnly = false;
            rddngaysinhts.ReadOnly = false;
            rtsbdts.ReadOnly = false;
            rtsdtts.ReadOnly = false;
            rthuyents.ReadOnly = false;
            rbbnam.ReadOnly = false;
            rbbnu.ReadOnly = false;
            rttinhts.ReadOnly = false;
            rttruongts.ReadOnly = false;
            rtnganhts.ReadOnly = false;
            rtkvutts.ReadOnly = false;
            rtdtutts.ReadOnly = false;
        }

        private void rbthoatts_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbhuyts_Click(object sender, EventArgs e)
        {
            if (stato == 1)
            {
                rtmahots.Text = " ";
                rthotents.Text = " ";
                rtsbdts.Text = " ";
                rtsdtts.Text = " ";
                rthuyents.Text = " ";
                rttinhts.Text = " ";
                rttruongts.Text = " ";
                rtnganhts.Text = " ";
                rtkvutts.Text = " ";
                rtdtutts.Text = " ";
                rbbnam.IsChecked = false;
                rbbnu.IsChecked = false;
            }
            if (stato == 2)
            {
                rtmahots.Text = " ";
                rthotents.Text = " ";
                rtsbdts.Text = " ";
                rtsdtts.Text = " ";
                rthuyents.Text = " ";
                rttinhts.Text = " ";
                rttruongts.Text = " ";
                rtnganhts.Text = " ";
                rtkvutts.Text = " ";
                rtdtutts.Text = " ";
                rbbnam.IsChecked = false;
                rbbnu.IsChecked = false;
            }
        }

        private void rbluuts_Click(object sender, EventArgs e)
        {
            QLEntities hsts = new QLEntities();
            if (stato == 1)
            {
                if (rbbnam.IsChecked == true)
                    hsts.THISINH_Update(rtmahots.Text, rthotents.Text, DateTime.Parse(rddngaysinhts.Text),true, rtsbdts.Text, rtsdtts.Text,rthuyents.Text,rttinhts.Text,rttruongts.Text,rtnganhts.Text,rtkvutts.Text,rtdtutts.Text);
                else
                    hsts.THISINH_Update(rtmahots.Text, rthotents.Text, DateTime.Parse(rddngaysinhts.Text), false, rtsbdts.Text, rtsdtts.Text, rthuyents.Text, rttinhts.Text, rttruongts.Text, rtnganhts.Text, rtkvutts.Text, rtdtutts.Text);
                rgthisinh.DataSource = hsts.THISINH_SelectAll();
            }
            if (stato == 2)
            {
                if (rbbnam.IsChecked == true)
                    hsts.THISINh_Insert(rtmahots.Text, rthotents.Text, DateTime.Parse(rddngaysinhts.Text), true, rtsbdts.Text, rtsdtts.Text, rthuyents.Text, rttinhts.Text, rttruongts.Text, rtnganhts.Text, rtkvutts.Text, rtdtutts.Text);
                else
                    hsts.THISINh_Insert(rtmahots.Text, rthotents.Text, DateTime.Parse(rddngaysinhts.Text), false, rtsbdts.Text, rtsdtts.Text, rthuyents.Text, rttinhts.Text, rttruongts.Text, rtnganhts.Text, rtkvutts.Text, rtdtutts.Text);
                rgthisinh.DataSource = hsts.THISINH_SelectAll();
            }
        }
    }
}
