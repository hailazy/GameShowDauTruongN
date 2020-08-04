using GAME_SHOW.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_SHOW.Forms.PLAYER
{
    public partial class frmPlayerHome : Form
    {
        User userInfo;
        public frmPlayerHome(User user)
        {
            InitializeComponent();
            userInfo = user;
        }

        private void frmPlayerHome_Load(object sender, EventArgs e)
        {
            lblMCId.Text = userInfo.id;
            lblFullName.Text = userInfo.login;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
