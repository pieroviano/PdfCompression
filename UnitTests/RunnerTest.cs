using System;
using System.IO;
using System.Linq;
using System.Xml;
using NUnit.Framework;
using PdfCompressorLibrary;

namespace UnitTests
{
    [TestFixture]
    public class RunnerTest
    {
        public static void Main()
        {
            new RunnerTest().RunCompression();
        }

        [Test]
        public void RunCompression()
        {
            var (sourceFolder, targetFolder) = PdfCompressor.ReadConfigSettings();
            PdfCompressor.Run(
                sourceFolder,
                targetFolder,
                Directory.GetFiles(sourceFolder, "*.pdf").Select(f => Path.GetFileName(f)).ToArray()
            );
        }
    }
}
