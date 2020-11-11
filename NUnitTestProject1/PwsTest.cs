using System;
using System.Collections.Generic;
using System.Text;
using LZBC;
using NUnit.Framework;

namespace NUnitTestProject1
{
    class PwsTest
    {
        [Test]
        public void PwsCoverTest()
        {
            User user = new User("", "");


            Assert.IsTrue(user.IsPassword("Ad123@"));
            Assert.IsFalse(user.IsPassword("1234567"));
            Assert.IsFalse(user.IsPassword("12345"));
            Assert.IsFalse(user.IsPassword("123456"));
           
            

        }
    }
}

