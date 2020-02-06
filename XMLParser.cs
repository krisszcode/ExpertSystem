using System;
using System.Xml;

namespace ExpertSystem
{
    public abstract class XMLParser
    {
        protected XmlDocument xmlDoc;

        protected void LoadXmlDocument(string XMLPath)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(XMLPath);
        }
    }
}
