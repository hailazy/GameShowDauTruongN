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
    public partial class frmControlGame : Form
    {
        private QuestionService questionService = new QuestionService();
        private GameShowService gameShowService = new GameShowService();
        private string gameShowId = "";
        public frmControlGame(string _gameShowId)
        {
            gameShowId = _gameShowId;
            InitializeComponent();
        }

        private void LoadData()
        {
            questionList.DataSource = questionService.GetQuestions(GlobalInfo.CurrentUser.id).Select(q => new TinyQuestion(q)).ToList();
            joinedUsers.DataSource = gameShowService.GetJoinedUsers(gameShowId);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idQuestion = questionList?.SelectedRows[0]?.Cells["Id"].Value.ToString();
            var content = questionList?.SelectedRows[0]?.Cells["Content"].Value.ToString();
            questionContent.Text = content;
            var isSuccess = gameShowService.AddQuestion(gameShowId, idQuestion);
            if (!isSuccess)
            {
                MessageBox.Show("Không thể thêm câu hỏi", "Thông Báo");
                return;
            }
        }

        private void frmControlGame_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var isSuccess = gameShowService.Start(gameShowId);

            if (!isSuccess)
            {
                MessageBox.Show("Không thể bắt đầu game show", "Thông Báo");
                return;
            }
            LoadData();
            foreach (DataGridViewColumn item in questionList.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn item in joinedUsers.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmControlGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameShowService.Close(gameShowId);
        }
    }
}
