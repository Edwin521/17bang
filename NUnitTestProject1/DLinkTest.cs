using LZBC;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
namespace NUnitTestProject1
{
    class DLinkTest
    {
        private DLinkNode node1, node2, node3, node4, node5;
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
            node4.Next = node5;
            node5.Previous = node4;
        }


        [Test]
        public void DeleteNodeTest1()
        {
            //[1] 2 3 4 5
            node1.Delete();
            Assert.IsNull(node2.Previous);
            Assert.IsNull(node1.Next);
        }
        [Test]
        public void DeleteNodeTest5()
        {
            //1 2 3 4 [5]

            node5.Delete();
            Assert.IsNull(node4.Next);
            Assert.IsNull(node5.Previous);
        }
        [Test]
        public void DeleteNodeTest4()
        {

            // 1 2 3 [4] 5
            node4.Delete();
            Assert.AreEqual(node3, node5.Previous);
            Assert.AreEqual(node5, node3.Next);
        }
        [Test]
        public void DeleteNodeTest()
        {
            //删到最后只剩下一个   【3】
            node1.Delete();
            node2.Delete();
            node4.Delete();
            node5.Delete();

            Assert.IsNull(node3.Next);
            Assert.IsNull(node3.Previous);
        }
    

    [Test]
    public void SwapTest1_2()
    {
        //[1] [2] 3 4 5   最左边两个相邻的交换
        node1.Swap(node2);
        Assert.IsNull(node2.Previous);
        Assert.AreEqual(node2.Next, node1);
        Assert.AreEqual(node1.Previous, node2);
        Assert.AreEqual(node1.Next, node3);
        Assert.AreEqual(node3.Previous, node1);
    }


    [Test]
    public void SwapTest1_3()
    {
        ///  [1] 2 [3] 4 5  一个最左边上，一个中间的交换

        node1.Swap(node3);
        Assert.IsNull(node3.Previous);
        Assert.AreEqual(node3.Next, node2);
        Assert.AreEqual(node1.Next, node4);
        Assert.AreEqual(node1.Previous, node2);
        Assert.AreEqual(node2.Previous, node3);
        Assert.AreEqual(node2.Next, node1);
        Assert.AreEqual(node4.Previous, node1);
    }

    [Test]
    public void SwapTest4_5()
    {
        /// 1 2 3 [4] [5]  最右边两个相邻的交换
        node4.Swap(node5);
        Assert.IsNull(node4.Next);
        Assert.AreEqual(node4.Previous, node5);
        Assert.AreEqual(node5.Next, node4);
        Assert.AreEqual(node5.Previous, node3);
        Assert.AreEqual(node3.Next, node5);
    }

    [Test]
    public void SwapTest3_5()
    {
        //  1 2 [3] 4 [5]   一个最右边上，一个中间的进行交换
        node3.Swap(node5);
        Assert.IsNull(node3.Next);
        Assert.AreEqual(node3.Previous, node4);
        Assert.AreEqual(node5.Next, node4);
        Assert.AreEqual(node5.Previous, node2);
        Assert.AreEqual(node4.Next, node3);
        Assert.AreEqual(node4.Previous, node5);
        Assert.AreEqual(node2.Next, node5);
    }

    [Test]
    public void SwapTest2_3()
    {
        // 1 [2] [3] 4 5   两个相邻且都不在边上的进行交换

        node3.Swap(node2);
        Assert.AreEqual(node3.Next, node2);
        Assert.AreEqual(node3.Previous, node1);
        Assert.AreEqual(node2.Previous, node3);
        Assert.AreEqual(node2.Next, node4);
        Assert.AreEqual(node1.Next, node3);
        Assert.AreEqual(node4.Previous, node2);
    }

    [Test]
    public void SwapTest2_4()
    {
        // 1 [2] 3 [4] 5   两个不相邻且都不在边上的进行交换
        node2.Swap(node4);
        Assert.AreEqual(node4.Next, node3);
        Assert.AreEqual(node4.Previous, node1);
        Assert.AreEqual(node2.Next, node5);
        Assert.AreEqual(node2.Previous, node3);
        Assert.AreEqual(node3.Next, node2);
        Assert.AreEqual(node3.Previous, node4);
        Assert.AreEqual(node1.Next, node4);
        Assert.AreEqual(node5.Previous, node2);
    }

    [Test]
    public void SwapTest1_5()
    {
        //[1] 2 3 4 [5]  最左边和最右边的进行交换

        node1.Swap(node5);
        Assert.IsNull(node5.Previous);
        Assert.AreEqual(node5.Next, node2);
        Assert.IsNull(node1.Next);
        Assert.AreEqual(node1.Previous, node4);
        Assert.AreEqual(node2.Previous, node5);
        Assert.AreEqual(node4.Next, node1);

    }



}
}
