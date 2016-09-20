using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MonoApp.Test
{
    [TestFixture]
    public class GreeterTest
    {

        [Test, Description("Should properly say Hello")]
        public void HelloTest()
        {
            string result = Greeter.SayHello("Alice");
            Assert.AreEqual(result, "Hello, Alice");
        }

        [Test, Description("Should properly say Bye")]
        public void ByeTest()
        {
            string result = Greeter.SayBye("Bob");
            Assert.AreEqual(result, "Bye, Bob!");
        }

        [Test, Ignore("For demo only - Do not break the CI build")]
        public void FailingTest()
        {
            int x = 5;
            int y = 8;
            Assert.AreEqual(x, y);
        }
    }
}