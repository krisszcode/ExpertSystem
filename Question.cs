using System;
namespace ExpertSystem
{
    public class Question
    {
        string ID { get; set; }
        string question { get; set; }
        Answer Answer;

        public Question(string id, string question, Answer answer)
        {
            ID = id;
            this.question = question;
            Answer = answer;
        }

        public string GetID()
        {
            return ID;
        }


        public string GetQuestion()
        {
            return question;
        }

        public Answer GetAnswer()
        {
            return Answer;
        }

        public bool GetEvalutedAnswer(string input)
        {
            return Answer.evaluateAnswerByInput(input);
        }

       
    }
}
