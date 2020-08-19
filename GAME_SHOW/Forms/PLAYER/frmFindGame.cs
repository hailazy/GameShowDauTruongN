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

namespace GAME_SHOW.Forms.PLAYER
{
    public partial class frmFindGame : Form
    {
        private GameShowService gameShowService = new GameShowService();
        public frmFindGame()
        {
            InitializeComponent();
        }

        private void frmFindGame_Load(object sender, EventArgs e)
        {
            roomList.DataSource = gameShowService.Find();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gameShowId = roomList?.SelectedRows[0]?.Cells["Id"].Value.ToString();
            var isSuccess = gameShowService.Join(GlobalInfo.CurrentUser.id, gameShowId);
            if (isSuccess)
            {
                var frm = new frmPlayGame(gameShowId);
                frm.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            roomList.DataSource = gameShowService.Find();
        }
    }
}
