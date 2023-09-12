using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class RemoveAllOccurencies
    {
        [TestMethod]
        public void RemoveAllOccurrences_Should_RemoveElements_When_ElementsExist()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 2, 4, 2, 5, 6 };
            var expected = new int[] { 1, 3, 4, 5, 6 };

            //Act
            var result = ArrayHelpers.RemoveAllOccurrences(source, 2);

            //Assert
            Assert.AreEqual(expected[4], result[4]);
            Assert.AreEqual(expected.Length, result.Length);
        }

        [TestMethod]
        public void RemoveAllOccurrences_Should_ReturnUnchangedArray_When_ElementDoesntExist()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 2, 4, 2, 5, 6 };
            var expected = new int[] { 1, 2, 3, 2, 4, 2, 5, 6 };

            //Act
            var result = ArrayHelpers.RemoveAllOccurrences(source, 7);

            //Assert
            Assert.AreEqual(expected[7], result[7]);
            Assert.AreEqual(expected.Length, result.Length);
        }
    }
}
