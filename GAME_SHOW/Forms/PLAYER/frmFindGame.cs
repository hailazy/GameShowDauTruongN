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
            //gameShowService.Join()
        }
    }
}
