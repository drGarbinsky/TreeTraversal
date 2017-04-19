using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeTraversal;
using System.Collections.Generic;

namespace TreeTests
{
    [TestClass]
    public class Tests
    {

        private Node root;

        [TestInitialize]
        public void TestInit()
        {
            root = new Node() // L0
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

        [TestMethod]
        public void DepthFirst()
        {
        }


        [TestMethod]
        public void BreadthFirst()
        {
        }
    }
}
