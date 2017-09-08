using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringNumbers
{
    [TestFixture]
    public class Class1
    {
        

        [TestCase("Negatives not allowed -1", "3,-1")]
        [TestCase("Negatives not allowed -3 -1", "-3,-1")]
        [TestCase(0, "")]
        [TestCase(3, "3")]
        [TestCase(12, "3,2,3,4")]
        [TestCase(6, "1\n2,3")]
        [TestCase(5, "//;\n2;3")]
        [TestCase(4, "//c\n1c3")]
        
        [Test]
        public static void addNumbers(int expected, string input)
        {
            var number = Calculator.Add(input);
            Assert.AreEqual(expected, number);
        }
    }
}
