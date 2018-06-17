using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PigLatin.Tests
{
    #region Single Word Consonant Tests
    [TestClass]
    public class PigLatinTests_SingleWordConsonants
    {
        [TestMethod]
        public void PigLatin_WhenBanana_ReturnsAnanabay()
        {
            //Arrange
            string input = "banana";

            //Act
            string output = PigLatin.ConvertToPigLatin(input);

            //Assert
            Assert.AreEqual("ananabay", output);
        }

        [TestMethod]
        public void PigLatin_WhenPig_ReturnsIgpay()
        {
            //Arrange
            string input = "pig";

            //Act
            string output = PigLatin.ConvertToPigLatin(input);

            //Assert
            Assert.AreEqual("igpay", output);
        }

        [TestMethod]
        public void PigLatin_WhenToo_ReturnsOotay()
        {
            //Arrange
            string input = "Too";

            //Act
            string output = PigLatin.ConvertToPigLatin(input);

            //Assert
            Assert.AreEqual("ootay", output);
        }

        [TestMethod]
        public void PigLatin_WhenSimple_ReturnsImplesay()
        {
            //Arrange
            string input = "Simple";

            //Act
            string output = PigLatin.ConvertToPigLatin(input);

            //Assert
            Assert.AreEqual("implesay", output);
        }

        [TestMethod]
        public void PigLatin_WhenPoo_ReturnsOopay()
        {
            //Arrange
            string input = "pOo";

            //Act
            string output = PigLatin.ConvertToPigLatin(input);

            //Assert
            Assert.AreEqual("oopay", output);
        }
    }
    #endregion

    #region Multiple Word Consonant Tests
    [TestClass]
    public class PigLatinTests_MultipleWordConsonants
    {
        [TestMethod]
        public void PigLatin_WhenBananaPoo_ReturnsAnanabayOopay()
        {
            //Arrange

            //Act

            //Assert

        }
    }
    #endregion
}
