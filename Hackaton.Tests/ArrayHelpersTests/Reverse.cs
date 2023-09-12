using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class Reverse
    {
        [TestMethod]
        public void Reverse_Should_Reverse()
        {
            //Arrange
            int[] source = { 1, 2, 3, 4, 5 };
            int[] expected = { 5, 4, 3, 2, 1 };

            //Act
            ArrayHelpers.Reverse(source);

            //Assert
            Assert.AreEqual(expected[4], source[4]);
            Assert.AreEqual(expected[0], source[0]);
        }
    }
}
