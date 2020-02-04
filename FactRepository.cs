using System;
using static ExpertSystem.toolbox;
using System.Collections.Generic;

namespace ExpertSystem
{
    public class FactRepository
    {
        List<Fact> factList = new List<Fact>();
        public FactRepository()
        {
        }
        public void AddFact(Fact fact)
        {
            string id = AnyInput("The ID of the fact?: ");
            string description = AnyInput("The description of the fact?: ");
            Fact newFact = new Fact(id, description);
            List<string> propertiesList = new List<string>();
            foreach (KeyValuePair<string, bool> properties in newFact.GetIDList())
            {
                propertiesList.Add(properties.Key);
            }
            foreach (string property in propertiesList)
            {
                newFact.SetFactValueByID(property, BoolInput(property + "?: "));
            }
        }
        public IEnumerator<Fact> GetEnumerator()
        {

        }
    }
}
