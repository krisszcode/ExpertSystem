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
                Console.WriteLine(xmlNode.ChildNodes);
            }


        }

        public FactRepository GetfactRepository()
        {
            FactRepository factRepository = new FactRepository();
            return factRepository;
        }
    }
}
