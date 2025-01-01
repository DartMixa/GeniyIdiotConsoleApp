using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static List<Tuple<string, int>> GetQuestionsAndAnswers()
        {
            List<Tuple<string, int>> list = new List<Tuple<string, int>>
            {
                new("Сколько будет два плюс два умноженное на два?", 6),
                new("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };
            return list;
        }

        static string[] GetDiagnoses()
        {
            string[] diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";
            return diagnoses;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, как вас зовут?");
            string? userName = Console.ReadLine();
            while (true)
            {
                int countQuestions = 5;
                List<Tuple<string, int>> questions = GetQuestionsAndAnswers();

                int countRightAnswers = 0;

                Random random = new Random();



                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));

                    int randomQuestionIndex = random.Next(0, questions.Count);
                    Console.WriteLine(questions[randomQuestionIndex].Item1);

                    int userAnswer = Convert.ToInt32(Console.ReadLine());

                    int rightAnswer = questions[randomQuestionIndex].Item2;

                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                    questions.Remove(questions[randomQuestionIndex]);
                }

                Console.WriteLine("Количество правильных ответов: " + countRightAnswers);


                Console.WriteLine(userName + ", ваш диагноз:" + GetDiagnoses()[countRightAnswers]);

                Console.WriteLine("Хотите пройти тест ещё раз?");
                if (Console.ReadLine().ToLower() == "нет") 
                {
                    break;
                }
            }
        }
    }
}