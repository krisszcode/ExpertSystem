﻿using System;
using System.Collections.Generic;
namespace ExpertSystem
{
    public class Fact
    {
        string ID { get; set; }
        string Description { get; set; }

        string Hardware { get; set; } // hardver hozza


        public Dictionary<string, bool> facts = new Dictionary<string, bool>();
        
        public Fact(string id, string description, string hardware = "")
        {
            ID = id;
            Description = description;
            Hardware = hardware;
        }

        public Dictionary<string, bool> GetIDList()
        {
            Dictionary<string, bool> properties = new Dictionary<string, bool>();
            foreach (KeyValuePair<string, bool> item in facts)
            {
                properties.Add(item.Key, item.Value);
            }
            return properties;
        }

        public void SetFactValueByID(string id, bool value)
        {
            if (!facts.ContainsKey(id))
            {
                facts.Add(id, false);
            }
            facts[id] = value;
        }


        public bool GetValueByID(string id)
        {
            foreach (KeyValuePair<string, bool> item in facts)
            {
                if (item.Key == id)
                {
                    return item.Value;
                }
            }
            return false;
        }

        public string GetDescription()
        {
            return Description;
        }
        public string GetID()
        {
            return ID;
        }




        public override string ToString()
        {
            string valami = ID + "-" + Description + "-";
            foreach (KeyValuePair<string,bool> item in facts)
            {
                valami += item.Key + "-";
                valami += item.Value.ToString() + "-";
            }
            return valami;
        }




        public string GetHarware()
        {
            return Hardware;
        }
    }
}
