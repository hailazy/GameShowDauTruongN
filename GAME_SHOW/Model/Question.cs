using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Model
{
    class Question
    {
        public string content { get; set; }
        public string answerA { get; set; }
        public string answerB { get; set; }
        public string answerC { get; set; }
        public string answerD { get; set; }
        public int rightAnswer { get; set; }
        public string userId { get; set; }

        public Question(string userId, string content, string answerA, string answerB, string answerC, string answerD, int rightAnswer)
        {
            this.userId = userId;
            this.content = content;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.rightAnswer = rightAnswer;
        }
    }
}
