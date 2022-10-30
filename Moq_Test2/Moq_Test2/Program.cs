using System;
using Xunit;
using Moq;

namespace Moq_Test2
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Console.WriteLine("Hello World!");
    //    }
    //}

    public class CalculatorTests
    {
        [Fact]
        public void ShouldDivideNumbers()
        {
            var sut = new Calculator();

            var actualResult = sut.Divide(10, 2);
            Assert.Equal(5, actualResult);
        }
    }

    public class Calculator
    {
        public double Divide(int x, int y)
        {
            return x / y;
        }
    }


    public interface ITaxCalculator
    {
        decimal CalculateItemTax(decimal itemValue);
    }
}
