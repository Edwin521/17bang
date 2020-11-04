using NUnit.Framework;
using System;
using LZBC;

namespace DLinkNodeTest
{
    public class DLinkNodeTest
    {

        private DLinkNode node1, node2, node3, node4;
        [SetUp]
        public void Setup()
        {
            node1 = new DLinkNode();
            node2 = new DLinkNode();
            node3 = new DLinkNode();
            node4 = new DLinkNode();

            node1.Next = node2;
            node2.Previous = node1;
            node2.Next = node3;
            node3.Previous = node2;
            node3.Next = node4;
            node4.Previous = node3;



        }


        [Test]
        public void AddAfterTest()
        {
            //1 2
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node2, node1.Next);

            Assert.AreEqual(node1, node2.Previous);
            //Assert.IsNull(node2.Next);
            // 1  2 [3]
            //Assert.IsNull(node3.Next);
            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node3, node2.Next);

            /// 1 2 [4] 3
            /// 

            Assert.AreEqual(node4, node2.Next);
            Assert.AreEqual(node2, node4.Previous);
            Assert.AreEqual(node3, node4.Next);
            Assert.AreEqual(node4, node3.Previous);
            Assert.IsNull(node3.Next);





        }


        [Test]
        public void AddBeforeTest()
        {


        }

        [Test]
        public void DeleteNodeTest()
        {


        }

        [Test]
        public void SwapTest()
        {


        }


    }
}