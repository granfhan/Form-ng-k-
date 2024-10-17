using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_ĐĂNG_KÝ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ten_TextChanged(object sender, EventArgs e)
        {

        }

        private bool emailvalid(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool passvalid(string matkhau)
        {
            string pattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";
            return matkhau.Length >= 8  && Regex.IsMatch(matkhau, pattern);
        }
        private void DK_Click(object sender, EventArgs e)
        {
            if (!emailvalid(email.Text))
            {
                hienthi.Text = "email không hợp lệ ";
            }
            else if (!passvalid(matkhau.Text  ))
            {
                hienthi.Text = "mật khẩu không hợp lệ";
            }
            else
            {
                hienthi.Text = "Đăng ký thành công";
            }
        }
    }
}
