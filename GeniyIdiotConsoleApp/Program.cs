using System;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var replay = true;
            while (replay)
            {
                Console.WriteLine("Здравствуйте, как вас зовут?");
                var user = new User(Console.ReadLine());

                Diagnose diagnose = new Diagnose();

                var questions = GetQuestions();

                int i = 0;
                foreach(var question in questions)
                {
                    i++;
                    Console.WriteLine("Вопрос №" + i);

                    Console.WriteLine(question.question);

                    var userAnswer = FoolproofAnswer();

                    var rightAnswer = question.answer;

                    if (userAnswer == rightAnswer)
                    {
                        diagnose.countRightAnswers++;
                    }
                }

                diagnose.diagnose = GetDiagnose(diagnose.countRightAnswers, questions.CountQuestions);

                Console.WriteLine("Количество правильных ответов: " + diagnose.countRightAnswers);
                
                Console.WriteLine(user.Name + ", ваш диагноз: " + diagnose.diagnose);

                var sw = new StreamWriter(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/results.txt", true);
                sw.WriteLine(user.Name + ";;;" + diagnose.countRightAnswers + ";;;" + diagnose.diagnose);
                sw.Close();

                Console.WriteLine("Хотите пройти тест ещё раз введите: 1");
                Console.WriteLine("Хотите просмотреть таблицу результатов введите: 2");
                var userChoice = Console.ReadLine();
                if (userChoice == "2") 
                {
                    var sr = new StreamReader(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/results.txt");
                    Console.WriteLine("{0, -20}{1, 20} \t {2}", "ФИО", "кол-во правильных ответ", "Диагноз");
                    while (true)
                    {
                        var str = sr.ReadLine();
                        if (str != null)
                        {
                            Console.WriteLine("{0, -20}{1, 20} \t {2}", str.Split(";;;"));
                        }
                        else
                        {
                            break;
                        }
                    }
                    sr.Close();
                    Console.WriteLine("Хотите пройти тест ещё раз введите: 1");
                    userChoice = Console.ReadLine();
                }
                if (userChoice != "1")
                {
                    replay = false;
                }
            }
        }
        static QuestionsStorage GetQuestions()
        {
            var list = new QuestionsStorage(
                [new("Сколько будет два плюс два умноженное на два?", 6),
                new("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)]);
            return list;
        }

        static string GetDiagnose(int countRightAnswers, int countQuestions)
        {
            var nom = Convert.ToInt32(Math.Round((decimal)countRightAnswers / (decimal)countQuestions * 6m));
            var diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";
            return diagnoses[countRightAnswers];
        }

        static int FoolproofAnswer() 
        {
            while (true) 
            {
                if (int.TryParse(Console.ReadLine(), out var answer))
                {
                    return answer;
                }
                else 
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                }
            }
        }
    }
}