using LZBC;
using MySelf;
using NUnit.Framework;
using System;
using test2;

namespace NUnitTestProject1
{
    public class Tests
    {


        //Ϊ֮ǰ��ҵ��ӵ�Ԫ���ԣ������������ڣ�

        //�������ҵ����ֵ
        //�ҵ�100���ڵ���������
        //��������Ϸ
        //���ֲ���
        //ջ��ѹ�뵯��

        //private int[] container;
        //public MimicStack(int length)
        //{
        //    container = new int[length];
        //}
        [SetUp]
        public void Setup()
        {




        }

        [Test]//�����еõ����ֵ��Ԫ����
        public void GetMaxTest()
        {

            Assert.AreEqual(55555, HomeWork.GetMax(new double[] { 0, 2, 12, 34, 12, 55555, -0.1, -23 }));
            Assert.AreEqual(34, HomeWork.GetMax(new double[] { 12, 12, 34, 12, -90, -67.89 }));
            Assert.AreEqual(34, HomeWork.GetMax(new double[] { 12, 12, 34, 12, -12 }));
            Assert.AreEqual(34, HomeWork.GetMax(new double[] { 12, 12, 34, 12, -100, -12.99 }));
            Assert.AreEqual(99.9, HomeWork.GetMax(new double[] { -1, -2, 0, 12, 12, 34, 12, 99.9 }));

        }


        [Test] //�ҵ�100���ڵ���������
        public void FindPrimeNumTest()//����һ��������ô�Ƚϣ�
        {

            //Assert.AreEqual( new int[] { 2, 3, 5, 7 }, HomeWork.findPrimeNum(1, 10));
            //Assert.AreEqual(true, HomeWork.IsPrimeNum(3));
        }


        [Test] //�ж�һ�����ǲ�������
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
        public void GuessMeTest() //��������Ϸ
        {



            //Assert.AreEqual(13,HomeWork.GuessMe());


        }



        [Test]
        public void PopTest() //ջ��ѹ�뵯��
        {


        }

        [Test]
        public void PushTest()
        {


        }

    }
}