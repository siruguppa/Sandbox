using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mounika_NUnitProject.UnitTest
{
    public class CalculatorTests
    {
        [Test]
        public void ValidateMyCalculatorAddFunctionality()
        {
            int a = 3;
            int b = 5;
            int expectedResult = 8;

            Calculator calculator = new Calculator();
            int actualResult = calculator.AddTwoNumbers(a, b);
            if (actualResult == expectedResult)
            {
                Console.WriteLine("oh god ! i know sum");
            }
            else
            {
                Console.WriteLine("oh god ! i dont know sum");
            }
        }
        [Test]
        public void ValidateMyCalculatorMultiplicationFunctionality()
        {
            int a = 3;
            int b = 5;
            int expectedResult = 15;

            Calculator calculator = new Calculator();
            int actualResult = calculator.MultiplyTwoNumbers(a, b);
            if (actualResult == expectedResult)
            {
                Console.WriteLine("oh god ! i know Multiplication");
            }
            else
            {
                Console.WriteLine("oh god ! i dont know Multiplication");
            }

        }
    }
}
