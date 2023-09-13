using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class InsertAt
    {
        [TestMethod]
        public void InsertAt_Should_Insert()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 4, 2, 3 };

            //Act
            var result = ArrayHelpers.InsertAt(source, 1, 4);

            //Assert
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected.Length, result.Length);
        }

        [TestMethod]
        public void InsertAt_Should_InsertAtZeroIndex()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var expected = new int[] { 4, 1, 2, 3 };

            //Act
            var result = ArrayHelpers.InsertAt(source, 0, 4);

            //Assert
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected.Length, result.Length);
        }

        [TestMethod]
        public void InsertAt_Should_InsertAtLastIndex()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 3, 4 };

            //Act
            var result = ArrayHelpers.InsertAt(source, source.Length, 4);

            //Assert
            Assert.AreEqual(expected[3], result[3]);
            Assert.AreEqual(expected.Length, result.Length);
        }
    }
}
