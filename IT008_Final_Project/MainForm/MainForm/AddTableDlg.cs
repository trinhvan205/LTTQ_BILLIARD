using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace MainForm
{
    public partial class AddTableDlg : Form
    {
        public AddTableDlg()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            textBox_idBan.Text = FMain.GetSqlData("SELECT IDBAN + 1 FROM BAN ORDER BY IDBAN DESC").Rows[0][0].ToString();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string commandText = $"INSERT INTO BAN VALUES({textBox_idBan.Text}, {textBox_GiaTienBan.Text}, 0)";
            try
            {
                FMain.SendSqlCommand(commandText);
            }
            catch (SqlException ex)
            {
                var errors = ex.Errors.Cast<SqlException>().ToList();
                foreach (var error in errors)
                {
                    string message = error.Number switch
                    {
                        2627 => "Mã bàn trùng lặp.",
                        207 => "Giá trị bạn vừa nhập không đúng định dạng.",
                        _ => $"Lỗi không xác định. Chi tiết lỗi như dưới:\n{error.Message}",
                    };
                    MessageBox.Show(message, "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
