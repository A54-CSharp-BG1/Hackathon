using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class FirstIndexOf
    {
        [TestMethod]
        public void FirstIndexOf_Should_Return_NegativeOne_When_ElementNotFound()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var expected = -1;

            //Act, Assert
            Assert.AreEqual(expected, ArrayHelpers.FirstIndexOf(source, 7));

        }
        [TestMethod]
        public void FirstIndexOf_Should_ReturnCorrectIndex_When_ElementFound()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var expected = 1;

            //Act, Assert
            Assert.AreEqual(expected, ArrayHelpers.FirstIndexOf(source, 2));

        }

        [TestMethod]
        public void FirstIndexOf_Should_ReturnCorrectIndex_When_MultipleIndexesExist()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4, 4, 4, 4 };
            var expected = 3;

            //Act, Assert
            Assert.AreEqual(expected, ArrayHelpers.FirstIndexOf(source, 4));

        }
    }
}
