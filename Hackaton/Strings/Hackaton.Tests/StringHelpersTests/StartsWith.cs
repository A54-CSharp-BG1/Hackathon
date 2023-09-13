using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class StartsWith
    {
        [TestMethod]
        public void StartsWith_ReturnsTrue_When_StringStartsWithTarget()
        {
            string word = "Company";

            bool result = StringHelpers.StartsWith(word, 'C');

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void StartsWith_ReturnsFalse_When_StringDoesntStartWithTarget()
        {
            string word = "Company";

            bool result = StringHelpers.StartsWith(word, 'q');

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void StartsWith_ReturnsFalse_When_StringEmpty()
        {
            string word = "";

            bool result = StringHelpers.StartsWith(word, 'q');

            Assert.IsFalse(result);
        }
    }
}
