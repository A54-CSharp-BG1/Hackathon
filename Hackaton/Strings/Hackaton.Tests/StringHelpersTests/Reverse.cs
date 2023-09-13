using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Reverse
    {
        [TestMethod]
        public void Reverse_Should_ReverseString()
        {
            string word = "Company";
            string expected = "ynapmoC";

            string result = StringHelpers.Reverse(word);

            Assert.AreEqual(expected, result);
        }
    }
}
