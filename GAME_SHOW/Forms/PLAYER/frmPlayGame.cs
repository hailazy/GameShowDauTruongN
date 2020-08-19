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
    public partial class frmPlayGame : Form
    {
        private GameShowService gameShowService = new GameShowService();
        private QuestionService questionService = new QuestionService();
        private string gameShowId = "";
        private int selectAnswer = 0;
        private int score = 0;
        private Question question = null;
        private bool isSubmit = false;
        public frmPlayGame(string _gameShowId)
        {
            gameShowId = _gameShowId;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (selectAnswer == 0)
            {
                MessageBox.Show("Bạn chưa nhập câu trả lời", "Thông Báo");
                return;
            }
            if (isSubmit)
            {
                MessageBox.Show("Bạn đã trả lời câu này rồi", "Thông Báo");
                return;
            }
            isSubmit = true;
            if (selectAnswer != question.rightAnswer)
            {
                MessageBox.Show($"Game show đã kết thúc,Số điểm của bạn là: {score}", "Thông Báo");
                this.Close();
                return;
            }

            if (selectAnswer == question.rightAnswer)
                score++;
            userScore.Text = score.ToString();
            gameShowService.UpdateScore(GlobalInfo.CurrentUser.id, gameShowId, score);
        }

        private void frmPlayGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Game show chưa bắt đầu xin bạn chờ trong giây lát", "Thông Báo");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var _question = questionService.GetCurrentQuestion(gameShowId);
            if (_question == null)
                return;
            var isOnline = gameShowService.IsOnline(gameShowId);

            if (!isOnline)
            {
                MessageBox.Show($"Game show đã kết thúc,Số điểm của bạn là: {score}", "Thông Báo");
                this.Close();
                return;
            }
            if (_question.Id != question?.Id)
            {
                question = _question;
                label2.Text = question.content;
                lblA.Text = question.answerA;
                lblB.Text = question.answerB;
                lblC.Text = question.answerC;
                lblD.Text = question.answerD;
                isSubmit = false;
            }
        }

        private void rdoAnswer3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void rdoAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            selectAnswer = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectAnswer = 2;
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            selectAnswer = 3;
        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            selectAnswer = 4;
        }
    }
}
