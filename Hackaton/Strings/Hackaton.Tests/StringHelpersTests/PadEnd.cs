using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class PadEnd
    {
        [TestMethod]
        public void PadEnd_Should_Return_PaddedString()
        {
            string source = "Company";
            char paddingSymbol = '-';
            string expected = "Company---";

            string result = StringHelpers.PadEnd(source, expected.Length, paddingSymbol);

            Assert.AreEqual(expected, result);
        }
    }
}
