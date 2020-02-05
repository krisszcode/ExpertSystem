using System;
using System.Xml;

namespace ExpertSystem
{
    public class RuleParser : XMLParser
    {
        public RuleParser()
        {
        }

        public RuleRepository GetRuleRepository()
        {
            return new RuleRepository();
        }

        public override void LoadXmlDocument(string XMLPath)
        {
            throw new NotImplementedException();
        }
    }
}
