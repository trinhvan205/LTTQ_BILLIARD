namespace MainForm
{
    partial class SignUpDlg
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
            dateTimePicker_NgaySinh = new DateTimePicker();
            label_CCCDNV = new Label();
            textBox_CCCDNV = new TextBox();
            label_NgaySinhNV = new Label();
            label_TenNV = new Label();
            textBox_TenNhanVien = new TextBox();
            buttonExit = new Button();
            textBox_TenDangNhap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_MatKhau = new TextBox();
            textBox_NhapLaiMatKhau = new TextBox();
            label3 = new Label();
            button_DangKy = new Button();
            checkBox_ShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // dateTimePicker_NgaySinh
            // 
            dateTimePicker_NgaySinh.Format = DateTimePickerFormat.Short;
            dateTimePicker_NgaySinh.Location = new Point(152, 85);
            dateTimePicker_NgaySinh.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker_NgaySinh.MaxDate = new DateTime(2023, 1, 27, 0, 0, 0, 0);
            dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            dateTimePicker_NgaySinh.Size = new Size(126, 23);
            dateTimePicker_NgaySinh.TabIndex = 27;
            dateTimePicker_NgaySinh.Value = new DateTime(2023, 1, 27, 0, 0, 0, 0);
            // 
            // label_CCCDNV
            // 
            label_CCCDNV.AutoSize = true;
            label_CCCDNV.Location = new Point(38, 134);
            label_CCCDNV.Name = "label_CCCDNV";
            label_CCCDNV.Size = new Size(96, 15);
            label_CCCDNV.TabIndex = 26;
            label_CCCDNV.Text = "Số CCCD/CMND";
            // 
            // textBox_CCCDNV
            // 
            textBox_CCCDNV.Location = new Point(152, 133);
            textBox_CCCDNV.Name = "textBox_CCCDNV";
            textBox_CCCDNV.Size = new Size(279, 23);
            textBox_CCCDNV.TabIndex = 25;
            textBox_CCCDNV.WordWrap = false;
            // 
            // label_NgaySinhNV
            // 
            label_NgaySinhNV.AutoSize = true;
            label_NgaySinhNV.Location = new Point(38, 88);
            label_NgaySinhNV.Name = "label_NgaySinhNV";
            label_NgaySinhNV.Size = new Size(63, 15);
            label_NgaySinhNV.TabIndex = 24;
            label_NgaySinhNV.Text = "Ngày sinh:";
            // 
            // label_TenNV
            // 
            label_TenNV.AutoSize = true;
            label_TenNV.Location = new Point(38, 43);
            label_TenNV.Name = "label_TenNV";
            label_TenNV.Size = new Size(46, 15);
            label_TenNV.TabIndex = 23;
            label_TenNV.Text = "Họ tên ";
            // 
            // textBox_TenNhanVien
            // 
            textBox_TenNhanVien.Location = new Point(152, 41);
            textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            textBox_TenNhanVien.Size = new Size(234, 23);
            textBox_TenNhanVien.TabIndex = 22;
            textBox_TenNhanVien.WordWrap = false;
            textBox_TenNhanVien.KeyDown += ControlToFocus_KeyDown;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExit.DialogResult = DialogResult.Cancel;
            buttonExit.Location = new Point(428, 319);
            buttonExit.Margin = new Padding(2, 2, 2, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(90, 23);
            buttonExit.TabIndex = 30;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // textBox_TenDangNhap
            // 
            textBox_TenDangNhap.Location = new Point(152, 182);
            textBox_TenDangNhap.Margin = new Padding(2, 2, 2, 2);
            textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            textBox_TenDangNhap.Size = new Size(213, 23);
            textBox_TenDangNhap.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 184);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 32;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 229);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 34;
            label2.Text = "Mật khẩu";
            // 
            // textBox_MatKhau
            // 
            textBox_MatKhau.Location = new Point(152, 227);
            textBox_MatKhau.Margin = new Padding(2, 2, 2, 2);
            textBox_MatKhau.Name = "textBox_MatKhau";
            textBox_MatKhau.Size = new Size(213, 23);
            textBox_MatKhau.TabIndex = 35;
            textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_NhapLaiMatKhau
            // 
            textBox_NhapLaiMatKhau.Location = new Point(152, 269);
            textBox_NhapLaiMatKhau.Margin = new Padding(2, 2, 2, 2);
            textBox_NhapLaiMatKhau.Name = "textBox_NhapLaiMatKhau";
            textBox_NhapLaiMatKhau.Size = new Size(213, 23);
            textBox_NhapLaiMatKhau.TabIndex = 36;
            textBox_NhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 273);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 37;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // button_DangKy
            // 
            button_DangKy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_DangKy.Location = new Point(318, 319);
            button_DangKy.Margin = new Padding(2, 2, 2, 2);
            button_DangKy.Name = "button_DangKy";
            button_DangKy.Size = new Size(78, 23);
            button_DangKy.TabIndex = 38;
            button_DangKy.Text = "Đăng ký";
            button_DangKy.UseVisualStyleBackColor = true;
            button_DangKy.Click += Button_DangKy_Click;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Location = new Point(398, 229);
            checkBox_ShowPassword.Margin = new Padding(2, 2, 2, 2);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(104, 19);
            checkBox_ShowPassword.TabIndex = 39;
            checkBox_ShowPassword.Text = "Hiện mật khẩu";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += CheckBox_ShowPassword_CheckedChanged;
            // 
            // SignUpDlg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 349);
            ControlBox = false;
            Controls.Add(checkBox_ShowPassword);
            Controls.Add(button_DangKy);
            Controls.Add(label3);
            Controls.Add(textBox_NhapLaiMatKhau);
            Controls.Add(textBox_MatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_TenDangNhap);
            Controls.Add(buttonExit);
            Controls.Add(dateTimePicker_NgaySinh);
            Controls.Add(label_CCCDNV);
            Controls.Add(textBox_CCCDNV);
            Controls.Add(label_NgaySinhNV);
            Controls.Add(label_TenNV);
            Controls.Add(textBox_TenNhanVien);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "SignUpDlg";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng ký";
            Load += SignUpDlg_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker_NgaySinh;
        private Label label_CCCDNV;
        private TextBox textBox_CCCDNV;
        private Label label_NgaySinhNV;
        private Label label_TenNV;
        private TextBox textBox_TenNhanVien;
        private Button buttonExit;
        private TextBox textBox_TenDangNhap;
        private Label label1;
        private Label label2;
        private TextBox textBox_MatKhau;
        private TextBox textBox_NhapLaiMatKhau;
        private Label label3;
        private Button button_DangKy;
        private CheckBox checkBox_ShowPassword;
    }
}