using NUnit.Framework;
using System.IO;
using System;
namespace HelloWorldTest2
{
    public class Tests
    {
        private const string Expected = "Hello World!";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}