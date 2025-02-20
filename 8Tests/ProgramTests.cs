using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            string input = "53he";
            var result = Logic.CalculateLetterPercentage(input);
            string output = $"Доля букв в предложении: {result.percentage}%";
            Assert.AreEqual(output, "Доля букв в предложении: 50%");
            
        }
        public void MainTest2()
        {
            string input = "538787he";
            var result = Logic.CalculateLetterPercentage(input);
            string output = $"Доля букв в предложении: {result.percentage}%";
            Assert.AreEqual(output, "Доля букв в предложении: 25%");

        }
    }
}