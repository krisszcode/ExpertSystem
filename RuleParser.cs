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
            string id = "";
            string desc = "";
            bool portable = false;
            bool gaming = false;
            bool expensive = false;
            bool backlit = false;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XMLPath);
            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                id = xmlNode.Attributes[0].InnerText;
                foreach (XmlNode xmlNode1 in xmlNode)
                {
                    if (xmlNode1.LocalName == "Description")
                    {
                        desc = xmlNode1.Attributes["value"].Value;
                    }
                    foreach (XmlNode xmlNode2 in xmlNode1)
                    {
                        switch (xmlNode2.Attributes["id"].Value)
                        {
                            case "portable":
                                if (xmlNode2.InnerText == "false") { portable = false; }
                                else { portable = true; }
                                break;
                            case "gaming":
                                if (xmlNode2.InnerText == "false") { gaming = false; }
                                else { gaming = true; }
                                break;
                            case "expensive":
                                if (xmlNode2.InnerText == "false") { expensive = false; }
                                else { expensive = true; }
                                break;
                            case "backlit keyboard":
                                if (xmlNode2.InnerText == "false") { backlit = false; }
                                else { backlit = true; }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
         
        }

    }
}
