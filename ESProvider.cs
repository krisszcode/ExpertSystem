using System;
using System.Collections.Generic;
using System.Linq;
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
            result.Clear();
            myenumfact.Reset();
            myenumrule.Reset();
            bool answer;
            string id;

            while (myenumrule.MoveNext())
            {
                string question = myenumrule.Current.GetQuestion();
                id = myenumrule.Current.GetID();
                answer = getAnswerByQuestion(id);
                result.Add(id, answer);
            }

        }
        public Boolean getAnswerByQuestion(string questionId)
        {
            return myenumrule.Current.GetEvalutedAnswer(AnyInput(myenumrule.Current.GetQuestion()));
        }

        public string evaluate()
        {
            Console.WriteLine("Your best option(s) are: ");
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
        public void evaluate2()
        {
            Console.WriteLine("Your best option(s) are:");
            while (myenumfact.MoveNext())
            {

                if (result.Except(myenumfact.Current.facts).Count() == 0)
                {
                    Console.WriteLine(myenumfact.Current.GetDescription());
                }
            }
        }
        public string evaluate1()
        {
            while (myenumfact.MoveNext())
            {
                int count = 0;
                foreach (KeyValuePair<string, bool> item in result)
                {
                    if (item.Value == myenumfact.Current.GetValueByID(item.Key))
                    {
                        count++;
                    }
                }
                if (count == 4)
                {
                    return "The recommended model is: " + myenumfact.Current.GetDescription();
                }
            }
            return "error computer";
        }
    }
}
