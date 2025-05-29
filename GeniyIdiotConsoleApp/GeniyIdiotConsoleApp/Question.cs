using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class Question
    {
        public readonly string question;
        public readonly int answer;
        public Question(string question, int answer) 
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
