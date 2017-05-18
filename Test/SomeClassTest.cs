using NUnit.Framework;
using SomeNamespace;

namespace Test
{
    [TestFixture]
    public class SomeClassTest
    {
        [Test]
        public void SomeTest()
        {
            Assert.That(new SomeClass().SomeMethod(), Is.EqualTo("A"));
        }
    }
}