using System;
using System.Xml;

namespace ExpertSystem
{
    public abstract class XMLParser
    {
        public abstract void LoadXmlDocument(string XMLPath); // Zoli (FactParser)

        public XmlDocument LoadXmlDocument2(string xmlPath) // thanks Milan
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            return xmlDoc;
        } // Load  .xml

    }
}
