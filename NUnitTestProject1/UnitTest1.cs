using LZBC;
using MySelf;
using NUnit.Framework;
using System;
using test2;

namespace NUnitTestProject1
{
    public class Tests
    {


        //为之前作业添加单元测试，包括但不限于：

        //数组中找到最大值
        //找到100以内的所有质数
        //猜数字游戏
        //二分查找
        //栈的压入弹出

        //private int[] container;
        //public MimicStack(int length)
        //{
        //    container = new int[length];
        //}
        [SetUp]
        public void Setup()
        {




        }

        [Test]//数组中得到最大值单元测试
        public void GetMaxTest()
        {

            Assert.AreEqual(55555, HomeWork.GetMax(new double[] { 0, 2, 12, 34, 12, 55555, -0.1, -23 }));
            Assert.AreEqual(34, HomeWork.GetMax(new double[] { 12, 12, 34, 12, -90, -67.89 }));
            Assert.AreEqual(34, HomeWork.GetMax(new double[] { 12, 12, 34, 12, -12 }));
            Assert.AreEqual(34, HomeWork.GetMax(new double[] { 12, 12, 34, 12, -100, -12.99 }));
            Assert.AreEqual(99.9, HomeWork.GetMax(new double[] { -1, -2, 0, 12, 12, 34, 12, 99.9 }));

        }


        [Test] //找到100以内的所有质数
        public void FindPrimeNumTest()//返回一个数组怎么比较？
        {

            //Assert.AreEqual( new int[] { 2, 3, 5, 7 }, HomeWork.findPrimeNum(1, 10));
            //Assert.AreEqual(true, HomeWork.IsPrimeNum(3));
        }


        [Test] //判断一个数是不是质数
        public void IsPrimeNumTest()
        {

            Assert.IsTrue(Program.IsPrimeNum(71));
            Assert.IsFalse(Program.IsPrimeNum(0));
            Assert.IsTrue(Program.IsPrimeNum(23));
            Assert.IsTrue(Program.IsPrimeNum(29));
            Assert.IsFalse(Program.IsPrimeNum(20));
            Assert.IsFalse(Program.IsPrimeNum(100));
            Assert.IsFalse(Program.IsPrimeNum(1));
            Assert.IsFalse(Program.IsPrimeNum(-1));
            Assert.IsFalse(Program.IsPrimeNum(-8));

        }

        [Test]
        public void GuessMeTest() //猜数字游戏
        {



            //Assert.AreEqual(13,HomeWork.GuessMe());


        }



        [Test]
        public void PopTest() //栈的压入弹出
        {


        }

        [Test]
        public void PushTest()
        {


        }

    }
}