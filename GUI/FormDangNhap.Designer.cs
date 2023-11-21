namespace GUI
{
    partial class FormDangNhap
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.lbl_tennguoidung = new System.Windows.Forms.Label();
            this.txt_matkhau = new ThietKeControls.MatKhauTextBox();
            this.txt_taikhoan = new ThietKeControls.TaiKhoanTextBox();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(265, 136);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(99, 41);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(137, 136);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(100, 41);
            this.btn_dangnhap.TabIndex = 10;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(39, 78);
            this.lbl_matkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(66, 17);
            this.lbl_matkhau.TabIndex = 7;
            this.lbl_matkhau.Text = "Mật khẩu";
            // 
            // lbl_tennguoidung
            // 
            this.lbl_tennguoidung.AutoSize = true;
            this.lbl_tennguoidung.Location = new System.Drawing.Point(39, 31);
            this.lbl_tennguoidung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tennguoidung.Name = "lbl_tennguoidung";
            this.lbl_tennguoidung.Size = new System.Drawing.Size(71, 17);
            this.lbl_tennguoidung.TabIndex = 6;
            this.lbl_tennguoidung.Text = "Tài khoản";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(137, 75);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '●';
            this.txt_matkhau.Size = new System.Drawing.Size(228, 30);
            this.txt_matkhau.TabIndex = 13;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(137, 28);
            this.txt_taikhoan.Multiline = true;
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(227, 30);
            this.txt_taikhoan.TabIndex = 12;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 201);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.lbl_tennguoidung);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Label lbl_tennguoidung;
        private ThietKeControls.TaiKhoanTextBox txt_taikhoan;
        private ThietKeControls.MatKhauTextBox txt_matkhau;
    }
}