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