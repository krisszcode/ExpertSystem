using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    public class ESProvider
    {
        public FactRepository factRepo;
        public RuleRepository ruleRepo;

        Dictionary<string, bool> questionDict = new Dictionary<string, bool>();

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            factRepo = factParser.GetFactRepository();
            ruleRepo = ruleParser.GetRuleRepository();
        }

        public void collectAnswers()
        {
            
        }

        public Boolean getAnswerByQuestion(string questionId)
        {
            return false; // until you finished it
        }

        public string evaluate()
        {
            return "string"; // until you finished it
        }

    }
}
