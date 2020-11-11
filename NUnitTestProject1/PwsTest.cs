using System;
using System.Collections.Generic;
using System.Text;
using LZBC;
using NUnit.Framework;
using test2;

namespace NUnitTestProject1
{
    class PwsTest
    {
        [Test]
        public void PwsCoverTest()
        {
            User user = new User("", "");


            Assert.IsTrue(user.IsPassword("eAd123@"));
            Assert.IsFalse(user.IsPassword("1234567"));
            Assert.IsFalse(user.IsPassword("12345"));
            Assert.IsFalse(user.IsPassword("123456"));

        }
        [Test]
        public void GetCountTest()
        {
            Assert.AreEqual(3, Program.GetCount("1112345", "1"));
            Assert.AreEqual(2, Program.GetCount("123451", "1"));
            Assert.AreEqual(7, Program.GetCount("0000000", "0"));
          
          
        }
    }
}

