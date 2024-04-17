using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1_3;
class Program
{
    static void Main(string[] args)
    {
        var rootNode = new TreeNode<string>("root");
        var child1 = rootNode.AddChild("root/a");
        var child3 = rootNode.AddChildren("root/t", "root/k", "root/r");
        var child2 = rootNode.AddChild("root/h");
        var grandChild1 = child1.AddChild("root/a/b");
        var grandChild2 = child1.AddChild("root/a/c");
        var grandChild3 = child2.AddChild("root/h/n");
        var greatGrandChild1 = grandChild3.AddChild("root/h/n/x");

        rootNode.PrintChildrenValues();
    }
}