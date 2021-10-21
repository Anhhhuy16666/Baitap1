
namespace QLTS
{
    partial class Frmhuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rghuyen = new Telerik.WinControls.UI.RadGridView();
            this.rbthemhuyen = new Telerik.WinControls.UI.RadButton();
            this.rbsuahuyen = new Telerik.WinControls.UI.RadButton();
            this.rbxoahuyen = new Telerik.WinControls.UI.RadButton();
            this.rbluuhuyen = new Telerik.WinControls.UI.RadButton();
            this.rbhuyhuyen = new Telerik.WinControls.UI.RadButton();
            this.rbthoathuyen = new Telerik.WinControls.UI.RadButton();
            this.rbtimkiemhuyen = new Telerik.WinControls.UI.RadButton();
            this.rtmahuyen = new Telerik.WinControls.UI.RadTextBox();
            this.rttenhuyen = new Telerik.WinControls.UI.RadTextBox();
            this.rttimkiemhuyen = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.rtmatinhhuyen = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rghuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rghuyen.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbthemhuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbsuahuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbxoahuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbluuhuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbhuyhuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbthoathuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtimkiemhuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmahuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttenhuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttimkiemhuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmatinhhuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(30, 110);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(56, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Mã huyện";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(308, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(88, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Thông tin huyện";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(295, 110);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(58, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Tên huyện";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(551, 110);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(52, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Tìm kiếm";
            // 
            // rghuyen
            // 
            this.rghuyen.Location = new System.Drawing.Point(30, 187);
            // 
            // 
            // 
            this.rghuyen.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rghuyen.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rghuyen.Name = "rghuyen";
            this.rghuyen.Size = new System.Drawing.Size(743, 150);
            this.rghuyen.TabIndex = 2;
            this.rghuyen.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rghuyen_CellClick);
            // 
            // rbthemhuyen
            // 
            this.rbthemhuyen.Location = new System.Drawing.Point(30, 378);
            this.rbthemhuyen.Name = "rbthemhuyen";
            this.rbthemhuyen.Size = new System.Drawing.Size(110, 24);
            this.rbthemhuyen.TabIndex = 3;
            this.rbthemhuyen.Text = "Thêm";
            this.rbthemhuyen.Click += new System.EventHandler(this.rbthemhuyen_Click);
            // 
            // rbsuahuyen
            // 
            this.rbsuahuyen.Location = new System.Drawing.Point(155, 378);
            this.rbsuahuyen.Name = "rbsuahuyen";
            this.rbsuahuyen.Size = new System.Drawing.Size(110, 24);
            this.rbsuahuyen.TabIndex = 4;
            this.rbsuahuyen.Text = "Sửa";
            this.rbsuahuyen.Click += new System.EventHandler(this.rbsuahuyen_Click);
            // 
            // rbxoahuyen
            // 
            this.rbxoahuyen.Location = new System.Drawing.Point(280, 378);
            this.rbxoahuyen.Name = "rbxoahuyen";
            this.rbxoahuyen.Size = new System.Drawing.Size(110, 24);
            this.rbxoahuyen.TabIndex = 4;
            this.rbxoahuyen.Text = "Xoá";
            this.rbxoahuyen.Click += new System.EventHandler(this.rbxoahuyen_Click);
            // 
            // rbluuhuyen
            // 
            this.rbluuhuyen.Location = new System.Drawing.Point(406, 378);
            this.rbluuhuyen.Name = "rbluuhuyen";
            this.rbluuhuyen.Size = new System.Drawing.Size(110, 24);
            this.rbluuhuyen.TabIndex = 4;
            this.rbluuhuyen.Text = "Lưu";
            this.rbluuhuyen.Click += new System.EventHandler(this.rbluuhuyen_Click);
            // 
            // rbhuyhuyen
            // 
            this.rbhuyhuyen.Location = new System.Drawing.Point(534, 378);
            this.rbhuyhuyen.Name = "rbhuyhuyen";
            this.rbhuyhuyen.Size = new System.Drawing.Size(110, 24);
            this.rbhuyhuyen.TabIndex = 4;
            this.rbhuyhuyen.Text = "Huỷ";
            this.rbhuyhuyen.Click += new System.EventHandler(this.rbhuyhuyen_Click);
            // 
            // rbthoathuyen
            // 
            this.rbthoathuyen.Location = new System.Drawing.Point(663, 378);
            this.rbthoathuyen.Name = "rbthoathuyen";
            this.rbthoathuyen.Size = new System.Drawing.Size(110, 24);
            this.rbthoathuyen.TabIndex = 4;
            this.rbthoathuyen.Text = "Thoát";
            this.rbthoathuyen.Click += new System.EventHandler(this.rbthoathuyen_Click);
            // 
            // rbtimkiemhuyen
            // 
            this.rbtimkiemhuyen.Location = new System.Drawing.Point(636, 157);
            this.rbtimkiemhuyen.Name = "rbtimkiemhuyen";
            this.rbtimkiemhuyen.Size = new System.Drawing.Size(100, 24);
            this.rbtimkiemhuyen.TabIndex = 4;
            this.rbtimkiemhuyen.Text = "Tìm kiếm";
            // 
            // rtmahuyen
            // 
            this.rtmahuyen.Location = new System.Drawing.Point(112, 108);
            this.rtmahuyen.Name = "rtmahuyen";
            this.rtmahuyen.Size = new System.Drawing.Size(100, 20);
            this.rtmahuyen.TabIndex = 5;
            // 
            // rttenhuyen
            // 
            this.rttenhuyen.Location = new System.Drawing.Point(406, 108);
            this.rttenhuyen.Name = "rttenhuyen";
            this.rttenhuyen.Size = new System.Drawing.Size(100, 20);
            this.rttenhuyen.TabIndex = 6;
            // 
            // rttimkiemhuyen
            // 
            this.rttimkiemhuyen.Location = new System.Drawing.Point(636, 108);
            this.rttimkiemhuyen.Name = "rttimkiemhuyen";
            this.rttimkiemhuyen.Size = new System.Drawing.Size(100, 20);
            this.rttimkiemhuyen.TabIndex = 7;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(30, 145);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(45, 18);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Mã tỉnh";
            // 
            // rtmatinhhuyen
            // 
            this.rtmatinhhuyen.Location = new System.Drawing.Point(112, 143);
            this.rtmatinhhuyen.Name = "rtmatinhhuyen";
            this.rtmatinhhuyen.Size = new System.Drawing.Size(100, 20);
            this.rtmatinhhuyen.TabIndex = 9;
            // 
            // Frmhuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtmatinhhuyen);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.rttimkiemhuyen);
            this.Controls.Add(this.rttenhuyen);
            this.Controls.Add(this.rtmahuyen);
            this.Controls.Add(this.rbtimkiemhuyen);
            this.Controls.Add(this.rbthoathuyen);
            this.Controls.Add(this.rbhuyhuyen);
            this.Controls.Add(this.rbluuhuyen);
            this.Controls.Add(this.rbxoahuyen);
            this.Controls.Add(this.rbsuahuyen);
            this.Controls.Add(this.rbthemhuyen);
            this.Controls.Add(this.rghuyen);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "Frmhuyen";
            this.Text = "Huyện";
            this.Load += new System.EventHandler(this.Frmhuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rghuyen.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rghuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbthemhuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbsuahuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbxoahuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbluuhuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbhuyhuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbthoathuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtimkiemhuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmahuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttenhuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rttimkiemhuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmatinhhuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadGridView rghuyen;
        private Telerik.WinControls.UI.RadButton rbthemhuyen;
        private Telerik.WinControls.UI.RadButton rbsuahuyen;
        private Telerik.WinControls.UI.RadButton rbxoahuyen;
        private Telerik.WinControls.UI.RadButton rbluuhuyen;
        private Telerik.WinControls.UI.RadButton rbhuyhuyen;
        private Telerik.WinControls.UI.RadButton rbthoathuyen;
        private Telerik.WinControls.UI.RadButton rbtimkiemhuyen;
        private Telerik.WinControls.UI.RadTextBox rtmahuyen;
        private Telerik.WinControls.UI.RadTextBox rttenhuyen;
        private Telerik.WinControls.UI.RadTextBox rttimkiemhuyen;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox rtmatinhhuyen;
    }
}