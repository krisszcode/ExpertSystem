using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
    class SingleValue : Value
    {
        string Param;
        bool selectionType;
        SingleValue(String Param, bool selectionType)
        {
            this.Param = Param;
            this.selectionType = selectionType;
        }
    }
}
