using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Concat
    {
        [TestMethod]
        public void Concat_Should_Concatenate()
        {
            string word1 = "New";
            string word2 = " Company";
            string expected = "New Company";

            string actual = StringHelpers.Concat(word1, word2);

            Assert.AreEqual(expected, actual);
        }
    }
}
