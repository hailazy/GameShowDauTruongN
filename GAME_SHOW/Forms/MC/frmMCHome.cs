using GAME_SHOW.Forms.MC;
using GAME_SHOW.Model;
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

namespace GAME_SHOW.Forms
{
    public partial class frmMCHome : Form
    {
        Thread thread;
        User userInfo;
        public frmMCHome(User user)
        {
            InitializeComponent();
            userInfo = user;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMCHome_Load(object sender, EventArgs e)
        {
            lblMCId.Text = userInfo.id;
            lblFullName.Text = userInfo.login;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenFromAddQuestion);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFromAddQuestion(object obj)
        {
            Application.Run(new frmAddQuestion(userInfo));
        }

        private void btnDsSV_Click(object sender, EventArgs e)
        {
            var listfrm = new frmQuestionsList();
            listfrm.ShowDialog();
        }

        private void btnMoCD_Click(object sender, EventArgs e)
        {
            var frm = new frmControlGame();
            frm.ShowDialog();
        }
    }
}
