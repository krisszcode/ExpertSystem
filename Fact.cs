using System;
using System.Collections.Generic;
namespace ExpertSystem
{
    public class Fact
    {
        string ID { get; set; }
        string Description { get; set; }
        bool Portable { get; set; }
        bool Gaming { get; set; }
        bool Expensive { get; set; }
        bool BacklitKeyboard { get; set; }

        public Fact(string id, string description)
        {
            ID = id;
            Description = description;
        }
        public List<string> GetIDList()
        {
            List<string> iDList = new List<string>() { "Portable", "Gaming", "Expensive", "BacklitKeyboard" };
            return iDList;
        }
        public void SetFactValueByID(string id, bool value)
        {
            switch (id)
            {
                case "Portable":
                    Portable = value;
                    break;
                case "Gaming":
                    Gaming = value;
                    break;
                case "Expensive":
                    Expensive = value;
                    break;
                case "BackLitKeyboard":
                    BacklitKeyboard = value;
                    break;
                default:
                    break;
            }
        }
        public bool GetValueByID(string id)
        {
            switch (id)
            {
                case "Portable":
                    return Portable;
                case "Gaming":
                    return Gaming;
                case "Expensive":
                    return Expensive;
                case "BackLitKeyboard":
                    return BacklitKeyboard;
                default:
                    Console.WriteLine("wrong id");
                    return false;
            }
        }
        public string GetDescription()
        {
            return Description;
        }
    }
}
