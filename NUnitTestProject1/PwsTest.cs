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
        public void GetCountTest()
        {
            Assert.AreEqual(3, Program.GetCount("1112345", "1"));
            Assert.AreEqual(2, Program.GetCount("123451", "1"));
            Assert.AreEqual(7, Program.GetCount("0000000", "0"));
            Assert.AreEqual(9, Program.GetCount("0000000**00", "0"));
            Assert.AreEqual(11, Program.GetCount("0000000**00?00", "0"));
          
          
        }
    }
}

