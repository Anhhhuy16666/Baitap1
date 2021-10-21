
namespace QLTS
{
    partial class Frmlogin
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rttendangnhap = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rtmatkhau = new Telerik.WinControls.UI.RadTextBox();
            this.rbdangnhap = new Telerik.WinControls.UI.RadButton();
            this.rbthoat = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rttendangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbdangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbthoat)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rtmatkhau);
            this.radGroupBox1.Controls.Add(this.rttendangnhap);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Thông tin đăng nhập";
            this.radGroupBox1.Location = new System.Drawing.Point(21, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(308, 123);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Thông tin đăng nhập";
            // 
            // rttendangnhap
            // 
            this.rttendangnhap.Location = new System.Drawing.Point(105, 40);
            this.rttendangnhap.Name = "rttendangnhap";
            this.rttendangnhap.Size = new System.Drawing.Size(184, 20);
            this.rttendangnhap.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(26, 82);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(53, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Mật khẩu";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(26, 42);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tên tài khoản";
            // 
            // rtmatkhau
            // 
            this.rtmatkhau.Location = new System.Drawing.Point(105, 82);
            this.rtmatkhau.Name = "rtmatkhau";
            this.rtmatkhau.PasswordChar = '*';
            this.rtmatkhau.Size = new System.Drawing.Size(184, 20);
            this.rtmatkhau.TabIndex = 3;
            // 
            // rbdangnhap
            // 
            this.rbdangnhap.Location = new System.Drawing.Point(21, 154);
            this.rbdangnhap.Name = "rbdangnhap";
            this.rbdangnhap.Size = new System.Drawing.Size(110, 24);
            this.rbdangnhap.TabIndex = 1;
            this.rbdangnhap.Text = "Đăng nhập";
            this.rbdangnhap.Click += new System.EventHandler(this.rbdangnhap_Click);
            // 
            // rbthoat
            // 
            this.rbthoat.Location = new System.Drawing.Point(219, 154);
            this.rbthoat.Name = "rbthoat";
            this.rbthoat.Size = new System.Drawing.Size(110, 24);
            this.rbthoat.TabIndex = 2;
            this.rbthoat.Text = "Thoát";
            this.rbthoat.Click += new System.EventHandler(this.rbthoat_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 191);
            this.Controls.Add(this.rbthoat);
            this.Controls.Add(this.rbdangnhap);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "Frmlogin";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmlogin_FormClosing);
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rttendangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtmatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbdangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbthoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox rttendangnhap;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox rtmatkhau;
        private Telerik.WinControls.UI.RadButton rbdangnhap;
        private Telerik.WinControls.UI.RadButton rbthoat;
    }
}

