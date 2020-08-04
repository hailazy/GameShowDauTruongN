using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAME_SHOW.Forms.PLAYER;
using GAME_SHOW.Model;
using GAME_SHOW.Services;

namespace GAME_SHOW.Forms
{
    public partial class frmLogIn : Form
    {
        Thread thread;
        User user;
        public frmLogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = (char)0x2022;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            try
            {
                user = APIService.Login(email, pass);
                if (user == null)
                {
                    MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo");
                    txtEmail.Clear();
                    txtPassword.Clear();
                }
                else if (user.role == "MC")
                {
                    this.Close();
                    thread = new Thread(OpenFromMC);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    this.Close();
                    thread = new Thread(OpenFromPlayer);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng", "Thông Báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFromSiguUp);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFromSiguUp(object obj)
        {
            Application.Run(new frmSignUp());
        }

        private void OpenFromMC(object obj)
        {
            Application.Run(new frmMCHome(user));
        }

        private void OpenFromPlayer(object obj)
        {
            Application.Run(new frmPlayerHome(user));
        }
    }
}
