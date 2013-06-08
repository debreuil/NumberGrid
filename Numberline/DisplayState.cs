using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDW.Numberline
{
    [Flags]
    public enum DisplayState
    {
        None,
        Full,
        EvenOnly,
        LightColumns,
        StepsFromEdge,
        UniqueX,
    }
}
