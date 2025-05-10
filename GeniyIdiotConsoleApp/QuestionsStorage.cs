using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class QuestionsStorage : IEnumerable<Question>, IEnumerator<Question>
    {
        public List<Question> Questions { get; set; } = [];
        private List<Question> TemporaryQuestionList { get; set; } = [];
        public int CountQuestions => Questions.Count;

        private readonly Random random = new();
        public Question Next
        {
            get
            {
                var randomQuestionIndex = random.Next(0, TemporaryQuestionList.Count);
                Question result = TemporaryQuestionList[randomQuestionIndex];
                TemporaryQuestionList.Remove(result);
                return result;
            }
        }

        public Question Current => Next;

        object IEnumerator.Current => Next;

        static public QuestionsStorage Load() 
        {
            try
            {
                List<Question> questions = [];

                var txt = FileSystem.ReadFile("questions.txt").Split("\n");

                foreach (var item in txt)
                {
                    if (item != "") 
                    {
                        var questionAnswer = item.Split(";;;");
                        questions.Add(new Question(questionAnswer[0], Convert.ToInt32(questionAnswer[1]))); 
                    }
                }

                return new QuestionsStorage(questions);
            }
            catch (System.IO.FileNotFoundException)
			{
                QuestionsStorage qe = GetQuestions();
                qe.Save();
                return qe;
            }
        }

        public void Save()
        {
            var txt = "";
            foreach (var question in Questions)
            {
                txt += string.Format("{0};;;{1}\n", question.question, Convert.ToString(question.answer));
            }
            FileSystem.WriteFile("questions.txt", txt);
        }

        public QuestionsStorage(List<Question> questions) 
        {
            Questions = questions;
        }

        public void CreateTempList()
        {
            foreach (var question in Questions) 
            {
                TemporaryQuestionList.Add(question);
            }
        }

        public void Add(Question question) 
        {
            Questions.Add(question);
            Save();
        }

        public IEnumerator<Question> GetEnumerator()
        {
            CreateTempList();
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            CreateTempList();
            return this;
        }

        public bool MoveNext()
        {
            if (TemporaryQuestionList.Count > 0) 
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            CreateTempList();
        }

        public void Dispose()
        {
            
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
    }
}
