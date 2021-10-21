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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void hoso_Click(object sender, EventArgs e)
        {
            FrmHoso frmts = new FrmHoso();
            frmts.MdiParent = this;
            frmts.WindowState = FormWindowState.Maximized;
            frmts.Show();
        }

        private void truong_Click(object sender, EventArgs e)
        {
            FrmTruong frmtruong = new FrmTruong();
            frmtruong.MdiParent = this;
            frmtruong.WindowState = FormWindowState.Maximized;
            frmtruong.Show();
        }

        private void thoatmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nganh_Click(object sender, EventArgs e)
        {
            FrmNganh frmnganh = new FrmNganh();
            frmnganh.MdiParent = this;
            frmnganh.WindowState = FormWindowState.Maximized;
            frmnganh.Show();
        }

        private void huyen_Click(object sender, EventArgs e)
        {
            Frmhuyen frmhuyen = new Frmhuyen();
            frmhuyen.MdiParent = this;
            frmhuyen.WindowState = FormWindowState.Maximized;
            frmhuyen.Show();
        }

        private void thanhpho_Click(object sender, EventArgs e)
        {
            FrmThanhpho frmthanhpho = new FrmThanhpho();
            frmthanhpho.MdiParent = this;
            frmthanhpho.WindowState = FormWindowState.Maximized;
            frmthanhpho.Show();
        }

        private void monthi_Click(object sender, EventArgs e)
        {
            FrmMonthi frmmonthi = new FrmMonthi();
            frmmonthi.MdiParent = this;
            frmmonthi.WindowState = FormWindowState.Maximized;
            frmmonthi.Show();
        }
    }
}
