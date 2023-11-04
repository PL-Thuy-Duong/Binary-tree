using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    public class Node
    {
        public int Data;
        public string Val;
        public Node Left;
        public Node Right;

        public Node(int data, string val = "")
        {
            Data = data;
            Left = null;
            Right = null;
            Val = val;
        }
    }
}
