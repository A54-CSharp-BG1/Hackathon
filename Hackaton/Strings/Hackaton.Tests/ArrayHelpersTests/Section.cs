using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class Section
    {
        [TestMethod]
        public void Section_Should_ReturnModifiedArray()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4, 5, 6 };
            var expected = new int[] { 2, 3, 4, 5 };

            //Act
            var result = ArrayHelpers.Section(source, 1, 4);

            //Assert
            Assert.AreEqual(expected[3], result[3]);
            Assert.AreEqual(expected.Length, result.Length);
        }

        [TestMethod]
        public void Section_Should_ReturnModifiedArray_When_StartingFromFirstIndex()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4, 5, 6 };
            var expected = new int[] { 1, 2, 3, 4, 5 };

            //Act
            var result = ArrayHelpers.Section(source, 0, 4);

            //Assert
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected.Length, result.Length);
        }
        [TestMethod]
        public void Section_ShouldReturn_ModifiedArray_When_SourceIsEmpty()
        {
            //Arrange
            var source = new int[] { };
            var expected = new int[] { };

            //Act
            var result = ArrayHelpers.Section(source, 0, 4);

            //Assert
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected.Length, result.Length);
        }
        [TestMethod]
        public void Section_ShouldReturn_ModifiedArray_WhenSourceIsLarger()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4, 5, 6 };
            var expected = new int[] { 3, 4, 5, 6 };

            //Act
            var result = ArrayHelpers.Section(source, 2, 10);

            //Assert
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected[3], result[3]);
        }
        [TestMethod]
        public void Section_ShouldReturn_SourceArray_WhenIndexNotValid()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 3 };

            //Act
            var result = ArrayHelpers.Section(source, 10, 1);

            //Assert
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected[0], result[0]);
        }
    }
}
