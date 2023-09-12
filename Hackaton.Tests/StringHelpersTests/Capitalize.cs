using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Capitalize
    {
        [TestMethod]
        public void Capitalize_Should_Return_CapitalizedString()
        {
            string source = "company";
            string expected = "Company";

            string result = StringHelpers.Capitalize(source);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Capitalize_Returns_Empty_when_StringEmpty()
        {
            string source = "";
            string expected = "";

            string result = StringHelpers.Capitalize(source);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Capitalize_ShouldNot_ChangeOtherCharacters()
        {
            string source = "Company";
            string expected = "Company";

            string result = StringHelpers.Capitalize(source);

            Assert.AreEqual(expected, result);
        }
    }
}
