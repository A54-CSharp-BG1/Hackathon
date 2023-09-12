using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Tests.ArrayHelpersTests
{
    [TestClass]
    public class AppendAll
    {
        [TestMethod]
        public void AppendAll_Should_Append()
        {
            //Arrange
            int[] source = { 1, 2, 3 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            //Act
            var result = ArrayHelpers.AppendAll(source, new int[] { 4, 5, 6 });

            //Assert
            Assert.AreEqual(expected[5], result[5]);
            Assert.AreEqual(expected.Length, result.Length);
        }
        [TestMethod]
        public void AppendAll_Should_Append_When_SourceIsAnEmptyArray()
        {
            //Arrange
            int[] source = { };
            int[] expected = { 1, 2, 3 };

            //Act
            var result = ArrayHelpers.AppendAll(source, new int[] { 1, 2, 3 });

            //Assert
            Assert.AreEqual(expected[2], result[2]);
            Assert.AreEqual(expected.Length, result.Length);
        }

        [TestMethod]
        public void AppendAll_ShouldNot_Append_When_EmptyArrayIsAppended()
        {
            //Arrange
            int[] source = { 1, 2, 3 };
            int[] expected = { 1, 2, 3 };

            //Act
            var result = ArrayHelpers.AppendAll(source, new int[0]);

            //Assert
            Assert.AreEqual(expected[2], result[2]);
            Assert.AreEqual(expected.Length, result.Length);
        }
    }
}
