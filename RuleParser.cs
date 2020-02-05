using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace ExpertSystem
{
    public class RuleParser : XMLParser
    {
        FactRepository factRepo;
        
        public RuleParser()
        {
        }

        public RuleRepository GetRuleRepository()
        {
            XmlDocument xmlDoc = base.LoadXmlDocument2("Rules.xml");
            RuleRepository ruleRepo = new RuleRepository();

            foreach (XmlNode node in xmlDoc.DocumentElement)
            {
                Answer ans = new Answer();
                foreach (XmlNode node2 in node.ChildNodes[1].ChildNodes) //Answerben vagyunk
                {
                    string rules = node2.ChildNodes[0].Attributes["value"].Value; //"value", mert az a neve az XML fileban
                    List<string> stringList = rules.Split(",").ToList<string>(); // Multiple, .Split(",")
                    if (stringList.Count>1)
                    {
                        ans.addValue(new MultipleValue(stringList, Convert.ToBoolean(node2.Attributes["value"].Value)));
                    }
                    else if(stringList.Count == 1)
                    {
                        ans.addValue(new SingleValue(stringList[0], Convert.ToBoolean(node2.Attributes["value"].Value)));
                    }
                    else
                    {
                        throw new Exception("Value error!");
                    }

                }
                Question question = new Question(node.Attributes["id"].Value, node.ChildNodes[0].InnerText, ans);
                ruleRepo.AddQuestion(question);
            }
            return ruleRepo;
        }



        public override void LoadXmlDocument(string XMLPath)
        {
            throw new NotImplementedException();
        }
    }
}
