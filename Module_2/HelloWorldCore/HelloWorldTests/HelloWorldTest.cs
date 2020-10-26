using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using HelloWorldCore;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTest
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
