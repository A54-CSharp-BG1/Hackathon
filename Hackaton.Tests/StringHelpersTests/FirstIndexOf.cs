using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class FirstIndexOf
    {
        [TestMethod]
        public void FirstIndexOf_Should_ReturnIndex_When_StringContainsCharacter()
        {
            string word = "Company";

            int result = StringHelpers.FirstIndexOf(word, 'm');

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FirstIndexOf_Should_ReturnMinusOne_When_StringDoesNotContainChar()
        {
            string word = "Company";

            int result = StringHelpers.FirstIndexOf(word, 'w');

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void FirstIndexOf_Should_ReturnMinusOne_When_StringIsEmpty()
        {
            string word = "";

            int result = StringHelpers.FirstIndexOf(word, 'w');

            Assert.AreEqual(-1, result);
        }
    }
}
