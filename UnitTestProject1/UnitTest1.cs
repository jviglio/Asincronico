using System;
using System.Collections.Generic;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetReult_Juan_ReturnsPapa()
        {
            // Arrange
            //var program = new Program();
            Dictionary<string, string> relatives = new Dictionary<string, string>();
            relatives.Add("Juan", "Papa");
            relatives.Add("Ana", "Mama");
            relatives.Add("Alejo", "Hijo");

            // Act
            var result = Program.GetResult("Juan", relatives);

            // Assert
            Assert.AreEqual(result, "Papa");
        }
    }
}
