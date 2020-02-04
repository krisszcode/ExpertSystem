using System;
using System.Collections.Generic;
using System.Xml;

namespace ExpertSystem
{
    public class FactParser : XMLParser
    {
        public override void LoadXmlDocument(string XMLPath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XMLPath);
            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                Console.WriteLine(xmlNode.Attributes[0].InnerText);
                foreach (XmlNode xmlNode1 in xmlNode)
                {
                    //List<string> listString = new List<string>() { "id", "value", "asd" };
                    //if (listString[0])
                    if (xmlNode1.LocalName == "Description")
                    {
                        Console.WriteLine(xmlNode1.Attributes["value"].Value);
                    }
                    foreach (XmlNode xmlNode2 in xmlNode1)
                    {
                        XmlAttribute idAttr = xmlNode2.Attributes["id"];
                        Console.Write(idAttr.Value + " - ");
                        Console.WriteLine(xmlNode2.InnerText);
                    }
                    Console.WriteLine();
                }

            }


        }

        public FactRepository GetfactRepository()
        {
            FactRepository factRepository = new FactRepository();
            return factRepository;
        }
    }
}
