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
    public partial class frmQuestionsList : Form
    {
        private QuestionService questionService = new QuestionService();
        private List<Question> list;
        public frmQuestionsList()
        {
            
            InitializeComponent();
        }

        private void frmQuestionsList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() 
        {
            list =  questionService.GetQuestions(GlobalInfo.CurrentUser.id);
            var tinyQuestions = list.Select(q => new TinyQuestion(q)).ToList();
            DataQuestions.DataSource = tinyQuestions;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Id = DataQuestions.SelectedRows[0].Cells["Id"].Value.ToString();
            try
            {
                questionService.Delete(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa câu hỏi", "Thông Báo");
            }
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Id = Int32.Parse(DataQuestions.SelectedRows[0].Cells["Id"].Value.ToString());
            var question = list.FirstOrDefault(l => l.Id == Id);

            var frm = new frmAddQuestion(question);
            frm.FormClosed += new FormClosedEventHandler(FormClose);
            frm.ShowDialog();
        }
    }
}
