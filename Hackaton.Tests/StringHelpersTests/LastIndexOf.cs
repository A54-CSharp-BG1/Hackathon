using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class LastIndexOf
    {
        [TestMethod]
        public void LastIndexOf_Should_ReturnIndex_When_StringContainsCharacter()
        {
            string word = "New Company";

            int result = StringHelpers.LastIndexOf(word, 'n');

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void LastIndexOf_Should_ReturnMinusOne_When_StringDoesNotContain()
        {
            string word = "Company";

            int result = StringHelpers.LastIndexOf(word, 'w');

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void LastIndexOf_Should_ReturnMinusOne_When_StringIsEmpty()
        {
            string word = "";

            int result = StringHelpers.LastIndexOf(word, 'w');

            Assert.AreEqual(-1, result);
        }
    }
}
