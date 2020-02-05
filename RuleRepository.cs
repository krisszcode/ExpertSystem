using System;
using System.Collections;
using System.Collections.Generic;

namespace ExpertSystem

{
    public class RuleRepository
    {

         static List<Question> ListOfQuestions = new List<Question>();


        class QuestionEnumerator : IEnumerator<Question> //UML rajz iterator interface
        {
            int index = -1;



            object IEnumerator.Current
            {
                get
                {
                    return ListOfQuestions[index];
                }
            }

            Question IEnumerator<Question>.Current => throw new NotImplementedException();

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                index++;
                return index < ListOfQuestions.Count;
            }

            public void Reset()
            {
                throw new InvalidOperationException();
            }
        }

        public void AddQuestion(Question question)
        {
            ListOfQuestions.Add(question);
        }

        public IEnumerator<Question> GetEnumerator()
        {
            return new QuestionEnumerator();
        }

    }
}
