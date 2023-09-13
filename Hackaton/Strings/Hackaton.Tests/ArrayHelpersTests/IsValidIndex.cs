using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class IsValidIndex
    {
        [TestMethod]
        public void IsValidIndex_Should_ReturnTrue_WhenIndexIsValid()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4 };

            //Act
            var result = ArrayHelpers.IsValidIndex(source, 2);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsValidIndex_Should_ReturnFalse_WhenIndexIsInvalid()
        {
            //Arrange
            var source = new int[] { 1, 2, 3, 4 };

            //Act
            var result = ArrayHelpers.IsValidIndex(source, 7);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsValidIndex_Should_ReturnFalse_WhenArrayIsEmpty()
        {
            //Arrange
            var source = new int[] { };

            //Act
            var result = ArrayHelpers.IsValidIndex(source, 0);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
