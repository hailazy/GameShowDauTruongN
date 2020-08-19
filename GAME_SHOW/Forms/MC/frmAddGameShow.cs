using GAME_SHOW.Model;
using GAME_SHOW.Services;
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

namespace GAME_SHOW.Forms.MC
{
    public partial class frmAddGameShow : Form
    {
        private GameShowService gameShowServices = new GameShowService();
        string gameShowId = "";
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

            var gameShowId = gameShowServices.Open(name.Text);
            if (String.IsNullOrWhiteSpace(gameShowId))
            {
                MessageBox.Show("Tạo phòng không thành công", "Thông Báo");
                return;
            }
            GlobalInfo.gameShowId = gameShowId;
            var thread = new Thread(OpenControlGame);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }

        private void OpenControlGame(object obj)
        {
            Application.Run(new frmControlGame());
        }
    }
}
