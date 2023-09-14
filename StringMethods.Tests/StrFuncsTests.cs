using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringMethods.Tests
{
    [TestClass]
    public class StrFuncsTests
    {
        [TestMethod]
        public void FindShortestWord_inputString_returnShortestWord()
        {
            string input = "Это просто пробная строка чтобы проверить метод.";
            string expected = "Это";
            StrFuncs strFuncs = new StrFuncs();
            string result = strFuncs.FindShortestWord(input);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountWords_inputString_return7()
        {
            string input = "Это просто пробная строка чтобы проверить метод.";
            int expected = 7;

            StrFuncs strFuncs = new StrFuncs();
            int result = strFuncs.CountWords(input);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountCharacters_inputString_return5()
        {
            string input = "Это .";
            int expected = 5;

            StrFuncs strFuncs = new StrFuncs();
            int result = strFuncs.CountCharacters(input);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetNinthCharacter_inputString_returnTchar()
        {
            string input = "Это просто пробная строка чтобы проверить метод.";
            char expected = 'т';

            StrFuncs strFuncs = new StrFuncs();
            char result = strFuncs.GetNinthCharacter(input);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountDigits_inputString_return6()
        {
            string input = "Это 123123ыв.";
            int expected = 6;

            StrFuncs strFuncs = new StrFuncs();
            int result = strFuncs.CountDigits(input);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FindLongestDigitSequence_inputString_return5()
        {
            string input = "Это 12312ыв.";
            int expected = 5;

            StrFuncs strFuncs = new StrFuncs();
            int result = strFuncs.FindLongestDigitSequence(input);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountAMCombinations_inputString_return3()
        {
            string input = "Это амамамАМ.";
            int expected = 3;

            StrFuncs strFuncs = new StrFuncs();
            int result = strFuncs.CountAMCombinations(input);

            Assert.AreEqual(expected, result);
        }
    }
}
