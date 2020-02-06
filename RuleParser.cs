using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace ExpertSystem
{
    public class RuleParser : XMLParser
    {
        RuleRepository ruleRepository;

        public RuleParser()
        {
        }

        public RuleRepository GetRuleRepository()
        {
            this.ruleRepository = new RuleRepository();
            LoadXmlDocument("Rules.xml");
            LoadRulesFromXML();
            return ruleRepository;
        }

        private void LoadRulesFromXML()
        {
            string qid = "";
            string questio = "";
            string param1 = "";
            bool selectionType1 = false;
            string param2 = "";
            bool selectionType2 = false;
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
            {
                qid = xmlNode.Attributes[0].InnerText;
                foreach (XmlNode xmlNode1 in xmlNode)
                {
                    if (xmlNode1.LocalName == "Question")
                    {
                        questio = xmlNode1.InnerText;
                    }
                    if (xmlNode1.LocalName == "Answer")
                    {
                        if (xmlNode1.ChildNodes[0].Attributes[0].Value == "true")
                        {
                            selectionType1 = true;
                        }
                        else{ selectionType1 = false; }
                        param1 = xmlNode1.ChildNodes[0].ChildNodes[0].Attributes[0].Value;
                        if (xmlNode1.ChildNodes[1].Attributes[0].Value == "true")
                        {
                            selectionType2 = true;
                        }
                        else{ selectionType2 = false; }
                        param2 = xmlNode1.ChildNodes[1].ChildNodes[0].Attributes[0].Value;
                    }
                }
                SingleValue singleValue1 = new SingleValue(param1, selectionType1);
                SingleValue singleValue2 = new SingleValue(param2, selectionType2);
                Answer answer = new Answer();
                answer.addValue(singleValue1);
                answer.addValue(singleValue2);
                Question question = new Question(qid, questio, answer);
                ruleRepository.AddQuestion(question);
            }
        }
    }
}
