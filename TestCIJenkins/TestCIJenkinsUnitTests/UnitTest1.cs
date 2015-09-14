using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using TestCIJenkins;

namespace TestCIJenkinsUnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main__Given_SingleCommand__Then_PrintCommandProcessed()
        {
            var testTextWriter = new StringWriter();
            Console.SetOut(testTextWriter);

            Program.Main(new[] { "print" });

            Assert.AreEqual("Command: [print] processed\r\n", testTextWriter.GetStringBuilder().ToString());
        }

        [TestMethod]
        public void Main__Given_MultipleCommands__Then_ReportIssue()
        {
            var testTextWriter = new StringWriter();
            Console.SetOut(testTextWriter);

            Program.Main(new[] { "print", "me" });

            Assert.AreEqual("Unknown command\r\nblah", testTextWriter.GetStringBuilder().ToString());
        }
    }
}
