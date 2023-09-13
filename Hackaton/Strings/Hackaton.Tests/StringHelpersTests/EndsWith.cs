using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class EndsWith
    {
        [TestMethod]
        public void EndsWith_Should_ReturnTrue_When_StringEndsWithTarget()
        {
            string word = "Company";

            bool result = StringHelpers.EndsWith(word, 'y');

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EndsWith_Should_ReturnFalse_When_StringDoesntEndWithTarget()
        {
            string word = "Company";

            bool result = StringHelpers.EndsWith(word, 'k');

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EndsWith_ReturnsFalse_When_StringEmpty()
        {
            string word = "";

            bool result = StringHelpers.EndsWith(word, 'k');

            Assert.IsFalse(result);
        }
    }
}
