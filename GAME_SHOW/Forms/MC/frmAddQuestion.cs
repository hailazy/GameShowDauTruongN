using GAME_SHOW.Model;
using GAME_SHOW.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_SHOW.Forms.MC
{
    public partial class frmAddQuestion : Form
    {
        User userInfo;
        public frmAddQuestion(User user)
        {
            InitializeComponent();
            userInfo = user;
        }

        private void frmAddQuestion_Load(object sender, EventArgs e)
        {
            rdoAnswer1.Enabled = false;
            rdoAnswer2.Enabled = false;
            rdoAnswer3.Enabled = false;
            rdoAnswer4.Enabled = false;

            txtAnswer1.Enabled = false;
            txtAnswer2.Enabled = false;
            txtAnswer3.Enabled = false;
            txtAnswer4.Enabled = false;
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            txtAnswer1.Enabled = true;
        }

        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer1.Enabled = true;

            txtAnswer2.Enabled = true;
        }

        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer2.Enabled = true;

            txtAnswer3.Enabled = true;
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer3.Enabled = true;

            txtAnswer4.Enabled = true;
        }

        private void txtAnswer4_TextChanged(object sender, EventArgs e)
        {
            rdoAnswer4.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (
                txtQuestion.Text == ""
                || txtAnswer1.Text == ""
                || txtAnswer2.Text == ""
                || txtAnswer3.Text == ""
                || txtAnswer4.Text == ""
                || (rdoAnswer1.Checked == false && rdoAnswer2.Checked ==false && rdoAnswer3.Checked == false && rdoAnswer4.Checked == false)
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ nội dung trước khi lưu", "Thông Báo");
            }

            string content = txtQuestion.Text;
            string answerA = txtAnswer1.Text;
            string answerB = txtAnswer2.Text;
            string answerC = txtAnswer3.Text;
            string answerD = txtAnswer4.Text;
            int rightAnswer = 1;

            if (rdoAnswer2.Checked == true)
            {
                rightAnswer = 2;
            }
            else if (rdoAnswer3.Checked == true)
            {
                rightAnswer = 3;
            }
            else if (rdoAnswer4.Checked == true)
            {
                rightAnswer = 4;
            }

            try
            {
                bool result = APIService.AddQuestion(userInfo.id, content, answerA, answerB, answerC, answerD, rightAnswer);
                if (result == false)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Lưu thành công", "Thông Báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra vấn đề, vui lòng thử lại!", "Thông Báo");
            }
        }

        private void rdoAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            rdoAnswer2.Checked = false;
            rdoAnswer3.Checked = false;
            rdoAnswer4.Checked = false;
        }

        private void rdoAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            rdoAnswer1.Checked = false;
            rdoAnswer3.Checked = false;
            rdoAnswer4.Checked = false;
        }

        private void rdoAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            rdoAnswer1.Checked = false;
            rdoAnswer2.Checked = false;
            rdoAnswer4.Checked = false;
        }

        private void rdoAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            rdoAnswer1.Checked = false;
            rdoAnswer2.Checked = false;
            rdoAnswer3.Checked = false;
        }
    }
}
