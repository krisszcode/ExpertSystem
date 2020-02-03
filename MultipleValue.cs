using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    class MultipleValue : Value
    {
        public List<string> Params = new List<string>();
        public bool selectionType;
        public MultipleValue(List<string> Params, bool selectionType)
        {
            this.Params = Params;
            this.selectionType = selectionType;
        }
    }
}
