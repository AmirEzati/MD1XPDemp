using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTestProject
{
   
    public partial class StringTester
    {
        #region 1

        [TestMethod]
        public void DoesItReturnPureTextIfSpacesAtTheBeginningIsPassed()
        {
            //arrange

            //act
            string text = "            Agile And Xp Demo";
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: "Agile And Xp Demo", actual: result);
        }
        #endregion

        #region 2

        [TestMethod]
        public void DoesItReturnPureTextIfSpacesAtTheEndIsPassed()
        {
            //arrange

            //act
            string text = "Agile And Xp Demo 2.........";
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: "Agile And Xp Demo 2", actual: result);
        }
        #endregion

        #region 3
        [TestMethod]
        public void DoesItRemoveAllExtraSpacesIfStringIsPassed()
        {
            //arrange

            //act
            string text = "                Agile                  And                     Xp            Demo                           ";
            string result = oStringFixer.FixString(text);
            //Assert
            Assert.AreEqual(expected: "Agile And Xp Demo", actual: result);
        }
        #endregion
    }
}
