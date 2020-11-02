using MySelf;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void grow()
        {
            human lls = new human();
 
            Assert.AreEqual(13,lls.grow(12));

        }

    }
}