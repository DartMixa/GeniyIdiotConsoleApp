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
                Console.WriteLine("Введите 5 если хотите добавить вопрос");
                Console.WriteLine("Введите 6 если хотите удалить вопрос");
                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1": replay = false; break;
                    case "2": PrintResultsTable(); break;
                    case "3": user = Authorization(); break;
                    case "4": Game(user); break;
                    case "5": AddQuestion(); break;
                    case "6": RemoveQuestion(); break;
                }
            }
        }
        static void PrintResultsTable()
        {
			Console.WriteLine("{0, -20}{1, 20} \t {2}", "ФИО", "кол-во правильных ответов", "Диагноз");
            foreach (var item in usersResultStorage.GetResults())
            {
				Console.WriteLine("{0, -20}{1, 20} \t {2}", item[0], item[1], item[2]);
			}
		}
        static int GetAnswer()
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

                var userAnswer = GetAnswer();

                var rightAnswer = question.answer;

                if (userAnswer == rightAnswer)
                {
                    diagnose.countRightAnswers++;
                }
            }

            diagnose.diagnose = DiagnoseCalculator.GetDiagnose(diagnose.countRightAnswers, questions.CountQuestions);

            Console.WriteLine("Количество правильных ответов: " + diagnose.countRightAnswers);

            Console.WriteLine(user.Name + ", ваш диагноз: " + diagnose.diagnose);

            usersResultStorage.AddDiagnose(user, diagnose);
            usersResultStorage.Save();
        }
        static void AddQuestion()
        {
            Console.WriteLine("Введите текст вопроса");
            var textQuestion = Console.ReadLine();
            Console.WriteLine("Введите ответ (целое число)");
            var answer = GetAnswer();
            questions.Add(new(textQuestion, answer));
        }
        static void RemoveQuestion() 
        {
            int i = 0;
            foreach (var question in questions.Questions)
            {
                i++;
                Console.WriteLine(i + ": " + question.question);
            }
            Console.WriteLine("Напишите номер вопроса который хотите удалить");
            string userChoice = Console.ReadLine();
            if (int.TryParse(userChoice, out int number) && number >= 0 && number <= i)
            {
                questions.Questions.RemoveAt(number - 1);
                questions.Save();
            }
            else
            {
                Console.WriteLine($"Не удалось удалить вопрос с номером {userChoice}");
            }
        }
    }
}