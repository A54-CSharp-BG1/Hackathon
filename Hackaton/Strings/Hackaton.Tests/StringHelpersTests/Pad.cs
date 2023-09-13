using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Pad
    {
        [TestMethod]
        public void Pad_Should_PadString_FromBothSides()
        {
            string source = "Company";
            char paddingSymbol = '-';
            string expected = "---Company---";

            string result = StringHelpers.Pad(source, expected.Length, paddingSymbol);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Pad_Should_PadEvenly_FromBothSides()
        {
            string source = "Company";
            char paddingSymbol = '-';
            string expected = "-Company-";

            string result = StringHelpers.Pad(source, 10, paddingSymbol);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Pad_ReturnsSource_When_Longer()
        {
            string source = "Company";
            char paddingSymbol = '-';
            string expected = "Company";

            string result = StringHelpers.Pad(source, 1, paddingSymbol);

            Assert.AreEqual(expected, result);
        }
    }
}
