using System;
using System.Collections.Generic;
using System.Xml;
using static ExpertSystem.toolbox;

namespace ExpertSystem
{
    public class FactParser : XMLParser
    {
        FactRepository factRepository;

        public Dictionary<string, string> HardwareOfPCs = new Dictionary<string, string>();


        private void AddHardwareToPC()
        {
            HardwareOfPCs.Add("sparpc", "Processor: Intel i5 HQ4100-K,\nVideocard: Geforce GTX 1060 Ti 6GB,\nRAM: 16GB DDR4 2472MHZ.\n");
            HardwareOfPCs.Add("razerdeathbringer", "Processor: Intel i4 HQ4100-K,\nVideocard: Geforce GTX 1050 Ti 4GB,\nRAM: 256GB DDR4 2444MHZ.\n");
            HardwareOfPCs.Add("gamingcomputer", "Processor: Intel i6 HQ4100-K,\nVideocard: Geforce GTX 1040 Ti 2GB,\nRAM: 1024GB DDR4 24346MHZ.\n");
            HardwareOfPCs.Add("AlienwareUFO", "Processor: Intel i7 HQ4100-K,\nVideocard: Geforce GTX 1030 Ti 8GB,\nRAM: 11235GB DDR4 24123MHZ.\n");
            HardwareOfPCs.Add("Win11", "Processor: Intel i8 HQ4100-K,\nVideocard: Geforce GTX 1020 Ti 16GB,\nRAM: 154GB DDR4 24623MHZ.\n");
            HardwareOfPCs.Add("MacAndCheese", "Processor: Intel i9 HQ4100-K,\nVideocard: Geforce GTX 1010 Ti 32GB,\nRAM: 125GB DDR4 2423MHZ.\n");
            HardwareOfPCs.Add("Win95", "Processor: Intel i2 HQ4100-K,\nVideocard: Geforce GTX 1024 Ti 1024GB,\nRAM: 151GB DDR4 24124MHZ.\n");
            HardwareOfPCs.Add("Razor", "Processor: Intel i1 HQ4100-K,\nVideocard: Geforce GTX 1072 Ti 256GB,\nRAM: 153GB DDR4 24234MHZ.\n");
            HardwareOfPCs.Add("laptop1", "Processor: Intel i4 HQ4100-K,\nVideocard: Geforce GTX 1015 Ti 126GB,\nRAM: 154GB DDR4 2476MHZ.\n");
            HardwareOfPCs.Add("RacerAligator", "Processor: Intel i6 HQ4100-K,\nVideocard: Geforce GTX 1063 Ti 2GB,\nRAM: 125GB DDR4 2434MHZ.\n");
            HardwareOfPCs.Add("Primitive", "Processor: Intel i7 HQ4100-K,\nVideocard: Geforce GTX 10123 Ti 4GB,\nRAM: 151GB DDR4 2474MHZ.\n");
            HardwareOfPCs.Add("HyperXSamsung", "Processor: Intel i3 HQ4100-K,\nVideocard: Geforce GTX 1092 Ti 6GB,\nRAM: 145GB DDR4 24234MHZ.\n");
            HardwareOfPCs.Add("Mekkbook", "Processor: Intel i2 HQ4100-K,\nVideocard: Geforce GTX 6969 Ti 8GB,\nRAM: 155GB DDR4 24054HZ.\n");
            HardwareOfPCs.Add("Agent", "Processor: Intel i1 HQ4100-K,\nVideocard: Geforce GTX 420 Ti 16GB,\nRAM: 152GB DDR4 2402340MHZ.\n");
            HardwareOfPCs.Add("JustforWork", "Processor: Intel i6 HQ4100-K,\nVideocard: Geforce GTX 360 Ti 18GB,\nRAM: 151GB DDR4 24005MHZ.\n");
            HardwareOfPCs.Add("Electricbill", "Processor: Intel i5 HQ4100-K,\nVideocard: Geforce GTX 1337 Ti 6GB,\nRAM: 175GB DDR4 24060MHZ.\n");           
        }

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
            string id;
            string desc = "";
            bool portable = false;
            bool gaming = false;
            bool expensive = false;
            bool backlit = false;
            string hardware = "";
            AddHardwareToPC();
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

                        else if (xmlNode2.Attributes["id"].Value == "hardware")
                        {
                            foreach (var key in HardwareOfPCs.Keys)
                            {
                                if (HardwareOfPCs.ContainsKey(id))
                                {
                                    hardware = HardwareOfPCs.GetValueOrDefault(key);
                                }
                            }
                           
                        }

                        else if (xmlNode2.Attributes["id"].Value == "backlit keyboard")
                        {
                            if (xmlNode2.InnerText == "false") { backlit = false; }
                            else { backlit = true; }
                        }
                    }
                    
                }
                Fact fact = new Fact(id, desc,hardware);
                fact.SetFactValueByID("portable", portable);
                fact.SetFactValueByID("gaming", gaming);
                fact.SetFactValueByID("expensive", expensive);
                fact.SetFactValueByID("backlit keyboard", backlit);

                factRepository.AddFact(fact);
            }
        }
    }
}
