using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class Diagnose
    {
        public int countRightAnswers = 0;
        public string diagnose = "";
        public Diagnose() { }
        public Diagnose(int countRightAnswers, string diagnose)
        { 
            this.countRightAnswers = countRightAnswers;
            this.diagnose = diagnose;
        }
    }
}
