using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a tree factory
            TreeFactory factory = new TreeFactory();

            // Create some trees
            Tree tree1 = new Tree(1, 2, 3, factory.GetTreeType("Oak"));
            Tree tree2 = new Tree(4, 5, 6, factory.GetTreeType("Pine"));
            Tree tree3 = new Tree(7, 8, 9, factory.GetTreeType("Oak"));
            Console.WriteLine(tree1.ToString() + " " + tree2.ToString() + " " +tree3.ToString());
            Console.ReadLine();
            // The Type property of tree1 and tree3 references the same TreeType object
        }

    }
}
