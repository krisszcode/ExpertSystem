using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    class SingleValue : Value
    {
        string Param { get; set; }
        private bool selectionType { get; set; }
        SingleValue(String Param, bool selectionType)
        {
            this.Param = Param;
            this.selectionType = selectionType;
        }

        public override List<string> getInputPattern()
        {
            List<string> copy = new List<string>();

            copy.Add(Param);

            return copy;
        }

        public override bool getSelectionType()
        {
            return this.selectionType;
        }
    }
}
