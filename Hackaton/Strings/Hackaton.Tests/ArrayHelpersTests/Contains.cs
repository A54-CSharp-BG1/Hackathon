using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class Contains
    {
        [TestMethod]
        public void Contains_Should_ReturnTrue_When_SourceContainsElement()
        {
            //Arrange
            int[] source = { 1, 2, 3 };

            //Act
            var result = ArrayHelpers.Contains(source, 1);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Contains_Should_ReturnFalse_When_SourceDoesNotContainElement()
        {
            //Arrange
            int[] source = { 1, 2, 3 };

            //Act, Assert
            Assert.IsFalse(ArrayHelpers.Contains(source, 4));
        }
    }
}
