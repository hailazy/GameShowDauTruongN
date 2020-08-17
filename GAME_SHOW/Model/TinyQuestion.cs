using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Model
{
    public class TinyQuestion
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string RightAnswer { get; set; }

        public TinyQuestion(Question question)
        {
            Id = question.Id;
            Content = question.content;
            switch (question.rightAnswer)
            {
                case 1:
                    RightAnswer = "A";
                    break;
                case 2:
                    RightAnswer = "B";
                    break;
                case 3:
                    RightAnswer = "C";
                    break;
                case 4:
                    RightAnswer = "D";
                    break;
                default:
                    break;
            }
        }
    }
}
