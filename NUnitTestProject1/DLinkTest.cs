using LZBC;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
namespace NUnitTestProject1
{
    class DLinkTest
    {
        private DLinkNode node1, node2, node3, node4,node5;
        [SetUp]
        public void Setup()
        {
            node1 = new DLinkNode();
            node2 = new DLinkNode();
            node3 = new DLinkNode();
            node4 = new DLinkNode();
            node5 = new DLinkNode();
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


          
            node4.AddAfter(node5);

            //1 2 3 4 [5]
            Assert.IsNull(node5.Next);
            Assert.AreEqual(node5, node4.Next);

            Assert.AreEqual(node4, node5.Previous);



          
        }

        [Test]
        public void AddMiddle()
        {

          
            node3.AddAfter(node5);
            // / 1 2 3 [5] 4 

            Assert.AreEqual(node5, node3.Next);
            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node4, node5.Next);
            Assert.AreEqual(node5, node4.Previous);
            Assert.IsNull(node4.Next);
        }

        [Test]
        public void AddBeforeTest()
        {
            // [2] 1  [5] 1 2 3 4
            DLinkNode node5 = new DLinkNode();
            node1.AddBefore(node5);

            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node5, node1.Previous);
            Assert.AreEqual(node1, node5.Next);
            Assert.IsNull(node5.Previous);




         
            node2.AddBefore(node5);
            // 3 [4]  2  1    1 [5] 2 3 4
            Assert.AreEqual(node4, node2.Previous);
            Assert.AreEqual(node2, node4.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node4, node3.Next);
            Assert.IsNull(node3.Previous);

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
