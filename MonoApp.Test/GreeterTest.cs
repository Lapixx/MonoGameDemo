using NUnit.Framework;

namespace MonoApp.Test
{
    [TestFixture]
    public class GreeterTest
    {

        [Test]
        public void HelloTest()
        {
            string result = Greeter.SayHello("Alice");
            Assert.AreEqual(result, "Hello, Alice");
        }

        [Test]
        public void ByeTest()
        {
            string result = Greeter.SayBye("Bob");
            Assert.AreEqual(result, "Bye, Bob!");
        }

        /*
        [Test]
        public void FailingTest()
        {
            int x = 5;
            int y = 8;
            Assert.AreEqual(x, y);
        }
        */
    }
}