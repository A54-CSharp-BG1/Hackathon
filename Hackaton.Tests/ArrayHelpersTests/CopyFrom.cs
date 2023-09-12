using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class CopyFrom
    {
        [TestMethod]
        public void CopyFrom_Should_Copy_When_SourceArrayIsLarger()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4, 5 };
            var destination = new int[4];
            var expected = new int[] { 0, 1, 2, 0 };

            //Act
            ArrayHelpers.CopyFrom(source, 0, destination, 1, 2);

            //Assert
            Assert.AreEqual(expected[2], destination[2]);
        }

        [TestMethod]
        public void CopyFrom_Should_Copy_When_DestinationArrayIsLarger()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var destination = new int[5];
            var expected = new int[] { 0, 1, 2, 0, 0 };

            //Act
            ArrayHelpers.CopyFrom(source, 0, destination, 1, 2);

            //Assert
            Assert.AreEqual(expected[2], destination[2]);
        }
        [TestMethod]
        public void CopyFrom_Should_CopyAllElementsFromSource()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var destination = new int[4];

            var expected = new int[] { 0, 1, 2, 3 };

            //Act
            ArrayHelpers.CopyFrom(source, 0, destination, 1, 3);

            //Assert
            Assert.AreEqual(expected[3], destination[3]);
        }
    }
}
