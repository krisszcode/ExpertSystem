using System;
using System.Collections;
using System.Collections.Generic;

namespace ExpertSystem

{
    public class RuleRepository
    {
       
        public static List<Question> ListOfQuestions = new List<Question>();


        class QuestionEnumerator : IEnumerator<Question> //UML rajz iterator interface
        {
            int index = -1;

            public Question Current {
            get
                {
                    try
                    {
                        return ListOfQuestions[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
                    }

            object IEnumerator.Current {
                get
                {
                    try
                    {
                        return ListOfQuestions[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }


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
                index = -1;
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
        
        public List<Question> addide()
        {
            return ListOfQuestions;
        }
        
    }
}

