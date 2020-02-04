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

            private int index = -1;

              bool HasNext()
             {
                return index < ListOfQuestions.Count;
             }

            public IEnumerator<Question> Next()
            {
                return ListOfQuestions[index++];
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
