﻿using System;
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

    #region Single Word Consonant Cluster Tests
    [TestClass]
    public class PigLatinTests_SingleWordConsonantClusters
    {
        [TestMethod]
        public void PigLatin_WhenCheers_ReturnsEerschay()
        {
            string input = "cheers";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("eerschay", output);
        }

        [TestMethod]
        public void PigLatin_WhenShesh_ReturnsEshshay()
        {
            string input = "Shesh";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("eshshay", output);
        }

        [TestMethod]
        public void PigLatin_WhenSmile_ReturnsIlesmay()
        {
            string input = "SmilE";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("ilesmay", output);
        }

        [TestMethod]
        public void PigLatin_WhenString_ReturnsIngstray()
        {
            string input = "STRING";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("ingstray", output);
        }

        [TestMethod]
        public void PigLatin_WhenThanks_ReturnsAnksthay()
        {
            string input = "Thanks";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("anksthay", output);
        }
    }
    #endregion

    #region Multiple Word Consonant Cluster Tests
    [TestClass]
    public class PigLatinTests_MultipleWordConsonantClusters
    {
        [TestMethod]
        public void PigLatin_WhenCheersShesh_ReturnsEerschayEshshay()
        {
            string input = "cheers shesh";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("eerschay eshshay", output);
        }

        [TestMethod]
        public void PigLatin_WhenSmileString_ReturnsIlesmayIngstray()
        {
            string input = "SmIlE strING";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("ilesmay ingstray", output);
        }

        [TestMethod]
        public void PigLatin_WhenThanksStupid_ReturnsAnksthayUpidstay()
        {
            string input = "thanks stupid";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("anksthay upidstay", output);
        }

        [TestMethod]
        public void PigLatin_WhenGloveTrash_ReturnsOveglayAshtray()
        {
            string input = "glove trash";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("oveglay ashtray", output);
        }

        [TestMethod]
        public void PigLatin_WhenGloveTrashThanksStupidSmile_ReturnsOveglayAshtray()
        {
            string input = "glove trash thanks stupid SmIlE";
            //string output = PigLatin.ConvertToPigLatin(input);
            string output = PigLatin.ConvertToPigLatinCluster(input);
            Assert.AreEqual("oveglay ashtray anksthay upidstay ilesmay", output);
        }
    }
    #endregion

}
