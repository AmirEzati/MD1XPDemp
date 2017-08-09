using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTestProject
{
    [TestClass]
    public partial class StringTester
    {
        StringPlayers.BL.StringFixer oStringFixer =
               new StringPlayers.BL.StringFixer();
        [TestMethod]
        public void DoesItReturnEmptyIfNullOrEmptyIsPassed()
        {
            //arrange
            //act
            string text = string.Empty;
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: string.Empty, actual: result);
        }

        [TestMethod]
        public void DoesItReturnExactIfPureStringIsPassed()
        {
            //arrange

            //act
            string text = "Agile And Xp Demo";
            string result = oStringFixer.FixString(text);// developer
            //Assert
            Assert.AreEqual(expected: "Agile And Xp Demo", actual: result);
        }

        [TestMethod]
        public void DoesItReturnEmptyIfSpacesIsPassed()
        {
            //arrange
           
            //act
            string text = "                          ";
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: string.Empty, actual: result);
        }

      

        [TestMethod]
        public void DoesItRemoveAllExtraSpacesBeforeAndAfterIfStringIsPassed()
        {
            //arrange

            //act
            string text = "                Agile And Xp Demo                           ";
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: "Agile And Xp Demo", actual: result);
        }


        [TestMethod]
        public void DoesItRemoveAllExtraDoubleSpacesIfStringIsPassed()
        {
            //arrange

            //act
            string text = "                Agile                 &           Xp        Demo                           ";
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: "Agile & Xp Demo", actual: result);
        }


    }
}
