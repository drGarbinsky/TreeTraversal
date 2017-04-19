using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTraversal;

namespace TreeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node() // L0
            {
                NodeId = "1",
                Children = new List<Node>() // L1
                {
                    new Node()
                    {
                        NodeId = "1.1",
                        Children = new List<Node>() // L2
                        {
                            new Node() {NodeId = "1.1.1" },
                            new Node() {NodeId = "1.1.2" },
                            new Node() {NodeId = "1.1.3" }
                        }
                    },
                    new Node()
                    {
                        NodeId = "1.2",
                        Children = new List<Node>() // L2
                        {
                            new Node()
                            {
                                NodeId = "1.2.1",
                                Children = new List<Node>()
                                {
                                    new Node() {NodeId = "1.2.1.1" },
                                    new Node() {NodeId = "1.2.1.2" }
                                }
                            }
                        }
                    },
                    new Node()
                    {
                        NodeId = "1.3",
                        Children = new List<Node>() // L2
                        {
                            new Node() {NodeId = "1.3.1" },
                            new Node() {NodeId = "1.3.2" }
                        }
                    }
                }
            };


        }

    }
}
