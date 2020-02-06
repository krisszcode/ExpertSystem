using System;
using System.Collections.Generic;
using System.Text;
using static ExpertSystem.toolbox;

namespace ExpertSystem
{
    public class ESProvider
    {
        public FactRepository factRepo;
        public RuleRepository ruleRepo;
        public FactParser factParser;
        public RuleParser ruleParser;
        IEnumerator<Question> myenumrule;
        IEnumerator<Fact> myenumfact;

        Dictionary<string, bool> result = new Dictionary<string, bool>();

        Dictionary<string, bool> questionDict = new Dictionary<string, bool>();

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            factRepo = factParser.GetFactRepository();
            ruleRepo = ruleParser.GetRuleRepository();
            this.factParser = factParser;
            this.ruleParser = ruleParser;
            myenumrule = ruleRepo.GetEnumerator();
            myenumfact = factRepo.GetEnumerator();
        }

        public void collectAnswers()
        {
            bool answer;
            string id;
            
            while (myenumrule.MoveNext())
            {
                string question = myenumrule.Current.GetQuestion();
                id = myenumrule.Current.GetID();
                answer = getAnswerByQuestion(id);
                result.Add(id, answer);
            }
            foreach (var keyValuePair in result)
            {
                Console.WriteLine(keyValuePair.Key + " -" + keyValuePair.Value);
            }
            Console.ReadLine();
        }

        public Boolean getAnswerByQuestion(string questionId)
        {
            return myenumrule.Current.GetEvalutedAnswer(AnyInput(myenumrule.Current.GetQuestion()));
        }

        public string evaluate()
        {
            string computer = "";

            while (myenumfact.MoveNext())
            {
                foreach (KeyValuePair<string, bool> item in result)
                {
                    if (item.Value == myenumfact.Current.GetValueByID(item.Key))
                    {

                    }
                }
            }
            return computer;
        }

    }
}
