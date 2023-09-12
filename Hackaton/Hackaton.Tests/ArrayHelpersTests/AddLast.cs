using Hackaton;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class AddLast
    {
        [TestMethod]
        public void AddLast_Should_AddNumber()
        {
            //Arrange
            int[] source = { 1, 2, 3 };
            int[] expected = { 1, 2, 3, 4 };

            //Act
            var result = ArrayHelpers.AddLast(source, 4);

            //Assert
            Assert.AreEqual(expected[3], result[3]);
            Assert.AreEqual(expected.Length, result.Length);

        }
        [TestMethod]
        public void AddLast_Should_AddNumber_When_SourceIsAnEmptyArray()
        {
            //Arrange
            int[] source = { };
            int[] expected = { 1 };

            //Act
            var result = ArrayHelpers.AddLast(source, 1);

            //Assert
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected.Length, result.Length);
        }
    }
}
