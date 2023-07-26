using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    internal class TreeType
    {
        public string Type { get; }

        public TreeType(string type)
        {
            Type = type;
        }
    }
}
