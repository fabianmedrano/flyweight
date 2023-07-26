using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    internal class TreeFactory
    {
        private Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string type)
        {
            if (!_treeTypes.ContainsKey(type))
            {
                _treeTypes[type] = new TreeType(type);
            }

            return _treeTypes[type];
        }
    }
}
