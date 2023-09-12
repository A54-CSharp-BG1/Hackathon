using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class Copy
    {
        [TestMethod]
        public void Copy_ShouldCopy_When_SourceArrayIsLarger()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4, 5 };
            var destination = new int[4];
            var expected = new int[] { 1, 2, 3, 4 };

            //Act
            ArrayHelpers.Copy(source, destination, 4);

            //Assert
            Assert.AreEqual(expected[3], destination[3]);
        }


        [TestMethod]
        public void Copy_ShouldCopy_When_DestinationArrayIsLarger()
        {
            //Arrange
            var source = new int[] { 1, 2, 3 };
            var destination = new int[6];
            var expected = new int[] { 1, 2, 3, 0, 0, 0 };

            //Act
            ArrayHelpers.Copy(source, destination, 6);

            //Assert
            Assert.AreEqual(expected[5], destination[5]);
        }
    }
}
