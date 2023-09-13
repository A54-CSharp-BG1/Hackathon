using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.StringHelpersTests
{
    [TestClass]
    public class Repeat
    {
        [TestMethod]
        public void Repeat_Should_ReturnSourceRepeated()
        {
            string word = "C#";
            string expected = "C#C#C#C#";

            string result = StringHelpers.Repeat(word, 4);

            Assert.AreEqual(expected, result);
        }
    }
}
