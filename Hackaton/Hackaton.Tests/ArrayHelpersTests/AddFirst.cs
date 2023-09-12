using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class AddFirst
    {
        [TestMethod]
        public void AddFirst_Should_AddNumber()
        {
            //Arrange
            int[] source = { 1, 2, 3 };
            int[] expected = { 4, 1, 2, 3 };

            //Act
            var result = ArrayHelpers.AddFirst(source, 4);

            //Assert
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected.Length, result.Length);
        }
        [TestMethod]
        public void AddFirst_Should_AddNumber_When_SourceIsAnEmptyArray()
        {
            //Arrange
            int[] source = { };
            int[] expected = { 1 };

            //Act
            var result = ArrayHelpers.AddFirst(source, 1);

            //Assert
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected.Length, result.Length);
        }
    }
}
