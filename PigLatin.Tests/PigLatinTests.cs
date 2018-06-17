using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PigLatin.Tests
{
    [TestClass]
    public class PigLatinTests
    {
        [TestMethod]
        public void PigLatin_WhenBanana_ReturnsAnanabay()
        {
            //Arrange
            string input = "banana";

            //Act
            string output = PigLatin.GetValue(input);

            //Assert
            Assert.AreEqual("ananabay", output);
        }
    }
}
