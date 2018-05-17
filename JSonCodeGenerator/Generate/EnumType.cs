using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSonCodeGenerator.Generate
{
    [Flags]
    public enum DeclareMember
    {
        Filed = 0x1,
        Property = 0x2
    }
}
