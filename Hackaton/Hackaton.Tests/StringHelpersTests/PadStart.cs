using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class PadStart
    {
        [TestMethod]
        public void PadStart_Should_ReturnPaddedString()
        {
            string source = "Company";
            char paddingSymbol = '-';
            string expected = "---Company";

            //Act
            string actual = StringHelpers.PadStart(source, expected.Length, paddingSymbol);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
