using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetouchBugTracking
{
    public partial class LoginPage : Form
    {
        DataModel dm = new DataModel();
        bool yesLogin = false;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_username.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                Staff model = dm.personalLogin(tb_username.Text, tb_password.Text);
                if (model.username != null)
                {
                    Helpers.isLogin = model;
                    yesLogin = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileri Hatalı", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Bırakılamaz");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
