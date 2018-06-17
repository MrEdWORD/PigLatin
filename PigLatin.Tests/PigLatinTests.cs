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
            string input = "pig";
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("igpay", output);
        }

        [TestMethod]
        public void PigLatin_WhenToo_ReturnsOotay()
        {
            string input = "Too";
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("ootay", output);
        }

        [TestMethod]
        public void PigLatin_WhenSimple_ReturnsImplesay()
        {
            string input = "Simple";
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("implesay", output);
        }

        [TestMethod]
        public void PigLatin_WhenPoo_ReturnsOopay()
        {
            string input = "pOo";
            string output = PigLatin.ConvertToPigLatin(input);
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
            string input = "bAnAna POO";
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("ananabay oopay", output);
        }

        [TestMethod]
        public void PigLatin_WhenHappyDuck_ReturnsAppyhayUckday()
        {
            string input = "HAPPY duck";
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("appyhay uckday", output);
        }

        [TestMethod]
        public void PigLatin_WhenRealSay_ReturnsEalrayAysay()
        {
            string input = "REAL SAY";
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("ealray aysay", output);
        }

        [TestMethod]
        public void PigLatin_WhenPooPoo_ReturnsOopayOopay()
        {
            string input = "Poo poo"; // ^_^
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("oopay oopay", output);
        }

        [TestMethod]
        public void PigLatin_WhenLatinPig_ReturnsAtinlayIgpay()
        {
            string input = "Latin Pig"; // ^_^
            string output = PigLatin.ConvertToPigLatin(input);
            Assert.AreEqual("atinlay igpay", output);
        }
    }
    #endregion

}
