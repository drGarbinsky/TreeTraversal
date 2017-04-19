using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class Node
    {
        public Node()
        {
            this.Children = new List<Node>();
        }


        public string NodeId { get; set; }

        public List<Node> Children { get; set; }
    }
}
