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
        private List<Question> list;
        private string gameShowId = "";
        public frmControlGame()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            list = questionService.GetQuestions(GlobalInfo.CurrentUser.id);
            var tinyQuestions = list.Select(q => new TinyQuestion(q)).ToList();
            questionList.DataSource = tinyQuestions;
            joinedUsers.DataSource = gameShowService.GetJoinedUsers(gameShowId);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Id = questionList.SelectedRows[0].Cells["Id"].Value.ToString();
        }

        private void frmControlGame_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameGameShow.Text))
            {
                MessageBox.Show("Vui lòng nhập tên trước khi bắt đầu", "Thông Báo");
                return;
            }

            var isSuccess = gameShowService.Start(nameGameShow.Text);

            if (!isSuccess)
            {
                MessageBox.Show("Không thể bắt đầu game show", "Thông Báo");
                return;
            }
            LoadData();
        }
    }
}
