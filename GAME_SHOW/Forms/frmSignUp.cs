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
using GAME_SHOW.Services;

namespace GAME_SHOW.Forms
{
    public partial class frmSignUp : Form
    {
        Thread thread;
        public frmSignUp()
        {
            InitializeComponent();
            txtPass.PasswordChar = (char)0x2022;
            txtRePass.PasswordChar = (char)0x2022;
        }

        private void rBtnMC_CheckedChanged(object sender, EventArgs e)
        {
            rBtnUser.Checked = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFromLogIn);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFromLogIn(object obj)
        {
            Application.Run(new frmLogIn());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            string rePass = txtRePass.Text;
            string fullName = txtFullName.Text;
            string role = rBtnMC.Checked == true ? "MC" : "PLAYER";
            try
            {
                if (email == "" || pass == "" || rePass == "" || fullName == "" || role == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo");
                }
                else
                {
                    bool result = APIService.SignUp(email, fullName, role, pass, rePass);
                    if (result == false)
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo");
                    }
                    else
                    {
                        DialogResult result1 = MessageBox.Show("Đăng ký thành công", "Thông Báo");
                        if (result1 == DialogResult.OK)
                        {
                            this.Close();
                            thread = new Thread(OpenFromLogIn);
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra vấn đề, vui lòng thử lại!", "Thông Báo");
            }
        }
    }
}
