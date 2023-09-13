using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Contains
    {
        [TestMethod]
        public void Contains_Should_ReturnTrue_When_StringContainsCharacter()
        {
            string word = "Company";

            bool result = StringHelpers.Contains(word, 'm');

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Contains_Should_ReturnFalse_When_StringDoesNotContainCharacter()
        {
            string word = "Company";

            bool result = StringHelpers.Contains(word, 'q');

            Assert.IsFalse(result);
        }
    }
}
