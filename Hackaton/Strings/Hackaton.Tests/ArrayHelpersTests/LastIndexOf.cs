using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class LastIndexOf
    {
        [TestMethod]
        public void LastIndexOf_IndexOf_Should_Return_NegativeOne_When_ElementNotFound()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 2, 1 };
            var expected = -1;

            //Act
            var result = ArrayHelpers.LastIndexOf(source, 7);

            //Assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void LastIndexOf_Should_ReturnIndex_When_ElementFound()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 2, 1 };
            var expected = 4;

            //Act
            var result = ArrayHelpers.LastIndexOf(source, 1);

            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void LastIndexOf_IndexOf_Should_Return_NegativeOne_When_ArrayIsEmpty()
        {
            //Arrange
            var source = new int[] { };
            var expected = -1;

            //Act
            var result = ArrayHelpers.LastIndexOf(source, 1);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
