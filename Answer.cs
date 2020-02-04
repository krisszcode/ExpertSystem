using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    public class Answer
    {

        Value value;
        public bool evaluateAnswerByInput(String input)
        {
            if (input.ToUpper() == "TRUE")
            {
                return true;
            }
            else if (input.ToUpper() == "FALSE")
            {
                return false;
            }
            else
            {
                throw new Exception("Ne szolits meg");
            }
        }

        public void addValue(Value value)
        {
            this.value = value;
        }
    }
}
