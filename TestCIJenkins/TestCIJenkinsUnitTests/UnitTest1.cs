using System;
using System.IO;
using TestCIJenkins;
using NUnit.Framework;

namespace TestCIJenkinsUnitTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Main__Given_SingleCommand__Then_PrintCommandProcessed()
        {
            var testTextWriter = new StringWriter();
            Console.SetOut(testTextWriter);

            Program.Main(new[] { "print" });

            Assert.AreEqual("Command: [print] processed\r\n", testTextWriter.GetStringBuilder().ToString());
        }

        [Test]
        public void Main__Given_MultipleCommands__Then_ReportIssue()
        {
            var testTextWriter = new StringWriter();
            Console.SetOut(testTextWriter);

            Program.Main(new[] { "print", "me" });

            Assert.AreEqual("Unknown command\r\n", testTextWriter.GetStringBuilder().ToString());
        }
    }
}
