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
    public partial class frmAddGameShow : Form
    {
        private GameShowService gameShowServices = new GameShowService();
        public frmAddGameShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên ", "Thông Báo");
                return;
            }

            var id = gameShowServices.Open(name.Text);

            var frm = new frmControlGame(id);
            frm.Show();
            this.Close();
        }
    }
}
