using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    internal class Tree
    {
        public int X { get; }
        public int Y { get; }
        public int Age { get; }
        public TreeType Type { get; }

        public Tree(int x, int y, int age, TreeType type)
        {
            X = x;
            Y = y;
            Age = age;
            Type = type;
        }
        public override string ToString()
        {
            return $"{X} x, {Y} y, {Age} age and {Type} type ";
        }
    }
}
