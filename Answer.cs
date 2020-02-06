using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    public class Answer
    {

        //public Value value;
        List<Value> values = new List<Value>();
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
            values.Add(value);
            //this.value = value;
        }
        public override string ToString()
        {
            string vissza = values[0].ToString();
            vissza += values[1].ToString();
            return vissza;
        }
    }
}
