using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static ExpertSystem.toolbox;

namespace ExpertSystem
{
    public class ESProvider
    {
        public FactRepository factRepo;
        public RuleRepository ruleRepo;
        public FactParser factParser;
        public RuleParser ruleParser;
        IEnumerator<Question> myenum;
        IEnumerator<Fact> myenumfact;

        Dictionary<string, bool> result = new Dictionary<string, bool>();

        Dictionary<string, bool> questionDict = new Dictionary<string, bool>();

        public ESProvider(FactParser factParser, RuleParser ruleParser)
        {
            factRepo = factParser.GetFactRepository();
            ruleRepo = ruleParser.GetRuleRepository();
            this.factParser = factParser;
            this.ruleParser = ruleParser;
            myenum = ruleRepo.GetEnumerator();
            myenumfact = factRepo.GetEnumerator();
        }

        public void collectAnswers()
        {
            result.Clear();
            myenumfact.Reset();
            myenum.Reset();
            bool answer;
            string id;
            
            while (myenum.MoveNext())
            {
                string question = myenum.Current.GetQuestion();
                id = myenum.Current.GetID();
                answer = getAnswerByQuestion(id);
                result.Add(id, answer);
            }
        }

        public Boolean getAnswerByQuestion(string questionId)
        {
            return myenum.Current.GetEvalutedAnswer(AnyInput(myenum.Current.GetQuestion()));
        }

        public string evaluate()
        {
            
            while (myenumfact.MoveNext())
            {
                
                var res = result.Except(myenumfact.Current.GetIDList());
                if (res.Count() == 0)
                {
                    return myenumfact.Current.GetDescription();
                   
                }

            }
            return "error";
            
        }
    }
}
