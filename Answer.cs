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
            if (input.ToUpper() == "YES")
            {
                return true;
            }
            else if (input.ToUpper() == "NO")
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
