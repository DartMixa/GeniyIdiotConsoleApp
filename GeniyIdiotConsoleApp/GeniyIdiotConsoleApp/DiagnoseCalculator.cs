using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class DiagnoseCalculator
    {
        public static string GetDiagnose(int countRightAnswers, int countQuestions)
        {
            var nom = Convert.ToInt32(Math.Round((decimal)countRightAnswers / (decimal)countQuestions * 5m));
            Console.WriteLine(nom + "" + countRightAnswers + "" + countQuestions);
            var diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";
            return diagnoses[nom];
        }
    }
}
