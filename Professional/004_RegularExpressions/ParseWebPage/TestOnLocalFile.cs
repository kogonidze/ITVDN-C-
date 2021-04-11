using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using ParseWebPage.Constants;

namespace ParseWebPage
{
    [TestFixture]
    public class TestOnLocalFile
    {
        string webPageSource;

        [SetUp]
        public void Init()
        {
            var pathToAssembly = NUnit.Framework.Internal.AssemblyHelper.GetAssemblyPath(typeof(TestOnLocalFile).Assembly);

            var projectFolder = Directory.GetParent(Path.GetDirectoryName(pathToAssembly)).Parent;
            var testFile = Directory.GetFiles(projectFolder.FullName, "testpage.html").FirstOrDefault();
            webPageSource = File.ReadAllText(testFile);
        }

        [Test]
        public void FindAllLinks()
        {
            var allLinks = Program.GetAllMatchesToArray(webPageSource, PatternConstants.patternForLinks);

            var expectedResult = new string[] {
                "http://www.w3.org/1999/xhtml",
                "https://github.com/kogonidze",
                "https://www.kufar.by/listings",
                "http://www.nyu.edu/"
            };

            Assert.AreEqual(allLinks, expectedResult);
        }

        [Test]
        public void FindAllEmails()
        {
            var allEmails = Program.GetAllMatchesToArray(webPageSource, PatternConstants.patternForEmail);

            var expectedResult = new string[]
            {
                "ivanivanov@mail.ru",
                "sergeisergeev@gmail.com",
                "viktorandreev@rambler.ru",
                "olegsidorov@tut.by"
            };

            Assert.AreEqual(allEmails, expectedResult);
        }

        [Test]
        public void FindAllPhoneNumbers()
        {
            var allPhoneNumbers = Program.GetAllMatchesToArray(webPageSource, PatternConstants.patternForPhoneNumber);

            var expectedResult = new string[]
            {
                "+375291234567",
                "8(926)9876534",
                "+380395555555"
            };

            Assert.AreEqual(allPhoneNumbers, expectedResult);
        }
    }
}
