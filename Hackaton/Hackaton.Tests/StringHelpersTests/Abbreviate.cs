using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Abbreviate
    {
        [TestMethod]
        public void Abbreviate_Should_Abbreviate_Input()
        {
            string word = "Company";
            string expected = "Compan...";

            string result = StringHelpers.Abbreviate(word, 6);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abbreviate_Returns_Unchanged_When_LongerLength()
        {
            string word = "Company";
            string expected = "Company";

            string result = StringHelpers.Abbreviate(word, 30);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abbreviate_Returns_Empty_When_EmptyString()
        {
            string word = "";
            string expected = "";

            string result = StringHelpers.Abbreviate(word, 30);

            Assert.AreEqual(expected, result);
        }
    }
}
