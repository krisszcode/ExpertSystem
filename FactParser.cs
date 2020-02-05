﻿using System;
using System.Collections.Generic;
using System.Xml;
using static ExpertSystem.toolbox;

namespace ExpertSystem
{
    public class FactParser : XMLParser
    {
        FactRepository factRepository;

        public FactRepository GetfactRepository()
        {
            FactRepository factRepository = new FactRepository();
            this.factRepository = factRepository;
            LoadXmlDocument("Fact.xml");
            return factRepository;
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
            Fact fact = new Fact(id, desc);
            fact.SetFactValueByID("portable", portable);
            fact.SetFactValueByID("gaming", gaming);
            fact.SetFactValueByID("expensive", expensive);
            fact.SetFactValueByID("backlit keyboard", backlit);
            factRepository.AddFact(fact);
        }
    }
}
