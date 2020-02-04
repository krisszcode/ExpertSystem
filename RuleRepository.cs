using System;
using System.Collections;
using System.Collections.Generic;

namespace ExpertSystem

{
    public class RuleRepository
    {

        static Dictionary<Question,string> DictionaryOfQuestions = new Dictionary<Question,string>();


        public RuleRepository()
        {
            QuestionEnumerator enumerator = new QuestionEnumerator();
        }



        // inner class
        class QuestionEnumerator : IEnumerator<Question> //UML rajz iterator interface
        {
            int index = -1;

            public Question Current { get; private set; }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return index < DictionaryOfQuestions.Count;
            }

            public void Reset()
            {
                throw new InvalidOperationException();
            }
        }
        // inner class




        public void AddQuestion(Question question)
        {
            DictionaryOfQuestions.Add(question, question.GetID());
        }

        public IEnumerator<Question> GetEnumerator()
        {
            return new QuestionEnumerator();
        }

    }
}
