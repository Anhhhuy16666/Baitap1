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
    public partial class Frmhuyen : Form
    {
        public int state;
        public Frmhuyen()
        {
            InitializeComponent();
        }

        private void rghuyen_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            rtmahuyen.Text = rghuyen.SelectedRows[0].Cells[0].Value.ToString();
            rtmatinhhuyen.Text = rghuyen.SelectedRows[0].Cells[2].Value.ToString();
            rttenhuyen.Text = rghuyen.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void rbthemhuyen_Click(object sender, EventArgs e)
        {
            state = 2;
            rtmahuyen.ReadOnly = false;
            rttenhuyen.ReadOnly = false;
            rtmatinhhuyen.ReadOnly = false;
        }

        private void rbsuahuyen_Click(object sender, EventArgs e)
        {
            state = 1;
            rtmahuyen.ReadOnly = false;
            rttenhuyen.ReadOnly = false;
            rtmatinhhuyen.ReadOnly = false;
        }

        private void rbxoahuyen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá huyện này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                QLEntities huyen = new QLEntities();
                huyen.HUYEN_Delete(rtmahuyen.Text);
                rghuyen.DataSource = huyen.HUYEN_SelectAll();
            }
        }

        private void rbluuhuyen_Click(object sender, EventArgs e)
        {
            QLEntities huyen = new QLEntities();
            if (state == 1)
            {
                huyen.HUYEN_Update(rtmahuyen.Text, rttenhuyen.Text, rtmatinhhuyen.Text);
      
                rghuyen.DataSource = huyen.HUYEN_SelectAll();
            }
            if (state == 2)
            {
                huyen.HUYEN_Insert(rtmahuyen.Text,rttenhuyen.Text,rtmatinhhuyen.Text);
                rghuyen.DataSource = huyen.HUYEN_SelectAll();
            }
        }

        private void rbhuyhuyen_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                rtmahuyen.Text = " ";
                rttenhuyen.Text = " ";
                rtmatinhhuyen.Text = " ";

            }
            if (state == 2)
            {
                rtmahuyen.Text = " ";
                rttenhuyen.Text = " ";
                rtmatinhhuyen.Text = " ";

            }
        }
        private void rbthoathuyen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmhuyen_Load(object sender, EventArgs e)
        {
            state = 0;
            QLEntities huyen = new QLEntities();
            rghuyen.DataSource = huyen.HUYEN_SelectAll();
        }
    }
}
