using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeKataOCR;
using System.Collections.Generic;

namespace CodeKataOCRTest
{
    [TestClass]
    public class AccountNumProcessorTest
    {
        AccountNumProcessor processor;

        [TestInitialize]
        public void Setup()
        {
            processor = new AccountNumProcessor();
        }

        [TestMethod]
        public void DetermineAccountNumberReadsZeroCorrectly()
        {
            var accountLines = new List<string>() {
                " _  _  _  _  _  _  _  _  _ ",
                "| || || || || || || || || |",
                "|_||_||_||_||_||_||_||_||_|"
            };

            var accountNum = processor.DetermineAccountNumber(accountLines);

            Assert.AreEqual("000000000", accountNum);
        }
    }
}
