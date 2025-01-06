using System;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static UsersResultStorage usersResultStorage = new();
        static QuestionsStorage questions;
        static void Main(string[] args)
        {
            usersResultStorage.Load();
            questions = QuestionsStorage.Load();

            var user = Authorization();

            var replay = true;
            while (replay)
            {
                Console.WriteLine("Введите 1 если хотите выйти из игры");
                Console.WriteLine("Введите 2 если хотите просмотреть таблицу результатов");
                Console.WriteLine("Введите 3 если хотите сменить аккаунт");
                Console.WriteLine("Введите 4 если хотите играть");
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1": replay = false; break;
                    case "2": usersResultStorage.PrintTable(); break;
                    case "3": user = Authorization(); break;
                    case "4": Game(user); break;
                }
            }
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
        static User Authorization() 
        {
            Console.WriteLine("Здравствуйте, как вас зовут?");
            return new User(Console.ReadLine());
        }
        static void Game(User user)
        {
            Diagnose diagnose = new Diagnose();

            int i = 0;
            foreach (var question in questions)
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

            usersResultStorage.AddDiagnose(user, diagnose);
            usersResultStorage.Save();
        }
    }
}