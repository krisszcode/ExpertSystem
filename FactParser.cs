using System;
using System.Collections.Generic;
using System.Xml;
using static ExpertSystem.toolbox;

namespace ExpertSystem
{
    public class FactParser : XMLParser
    {
        FactRepository factRepository;

        public FactRepository GetFactRepository()
        {
            FactRepository factRepository = new FactRepository();
            this.factRepository = factRepository;
            LoadXmlDocument("Facts.xml");
            LoadFactsFromXML();
            return factRepository;
        }

        private void LoadFactsFromXML()
        {
            string id = "";
            string desc = "";
            bool portable = false;
            bool gaming = false;
            bool expensive = false;
            bool backlit = false;
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
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
                        if (xmlNode2.Attributes["id"].Value == "portable")
                        {
                            if (xmlNode2.InnerText == "false") { portable = false; }
                            else { portable = true; }
                        }
                        else if(xmlNode2.Attributes["id"].Value == "gaming")
                        {
                            if (xmlNode2.InnerText == "false") { gaming = false; }
                            else { gaming = true; }
                        }
                        else if (xmlNode2.Attributes["id"].Value == "expensive")
                        {
                            if (xmlNode2.InnerText == "false") { expensive = false; }
                            else { expensive = true; }
                        }
                        else if (xmlNode2.Attributes["id"].Value == "backlit keyboard")
                        {
                            if (xmlNode2.InnerText == "false") { backlit = false; }
                            else { backlit = true; }
                        }
                    }
                    
                }
                Fact fact = new Fact(id, desc);
                fact.SetFactValueByID("portable", portable);
                fact.SetFactValueByID("gaming", gaming);
                fact.SetFactValueByID("expensive", expensive);
                fact.SetFactValueByID("backlit keyboard", backlit);
                factRepository.AddFact(fact);
            }
        }
    }
}
