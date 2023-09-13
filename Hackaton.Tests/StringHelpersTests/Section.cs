using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Section
    {
        [TestMethod]
        public void Section_Should_ReturnCorrectPartOfTheSourceString()
        {
            string source = "xxCompanyxx";
            string expected = "Company";

            string result = StringHelpers.Section(source, 2, 8);

            Assert.AreEqual(expected, result);

        }
    }
}
