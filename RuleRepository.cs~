using System;
using System.Collections;
using System.Collections.Generic;

namespace ExpertSystem

{
    public class RuleRepository
    {

        private List<Question> ListOfQuestions = new List<Question>();
        

         class QuestionEnumerator : Enumerator //UML rajz iterator interface
        {
            private int index = -1;

             bool HasNext()
             {
                return index < ListOfQuestions.Count;
             }






        }

        public void AddQuestion(Question question)
        {
            ListOfQuestions.Add(question);
        }

        public IEnumerator<Question> GetEnumerator()
        {
            return null;
        }

    }
}
