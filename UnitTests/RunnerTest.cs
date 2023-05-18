using System;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PdfCompressorLibrary;

namespace UnitTests
{
    [TestClass]
    public class RunnerTest
    {
        public static void Main()
        {
            new RunnerTest().RunCompression();
        }

        [TestMethod]
        public void RunCompression()
        {
            var (sourceFolder,targetFolder)=PdfCompressor.ReadConfigSettings();
            PdfCompressor.Run(sourceFolder, targetFolder, Directory.GetFiles(sourceFolder, "*.pdf").Select(f=> Path.GetFileName(f)).ToArray());
        }
    }
}
