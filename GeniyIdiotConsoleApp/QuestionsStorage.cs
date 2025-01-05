using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    internal class QuestionsStorage : IEnumerable<Question>, IEnumerator<Question>
    {
        private List<Question> Questions { get; set; } = [];
        private List<Question> TemporaryQuestionList { get; set; } = [];
        public int CountQuestions { get; set; } = 0;

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

        public QuestionsStorage(List<Question> questions) 
        {
            CountQuestions = questions.Count;
            Questions = questions;
        }

        private void Randomize()
        {
            foreach (var question in Questions) 
            {
                TemporaryQuestionList.Add(question);
            }
        }
        public void Add(Question question) 
        {
            Questions.Add(question);
        }

        public IEnumerator<Question> GetEnumerator()
        {
            Randomize();
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Randomize();
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
            Randomize();
        }

        public void Dispose()
        {
            
        }
    }
}
