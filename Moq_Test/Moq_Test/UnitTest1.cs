using System;
using Xunit;
using Moq;

namespace Moq_Test
{
    public class UnitTest1
    {
        private IUSD_INR_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_INR_ExchangeRateFeed> mockObject = new Mock<IUSD_INR_ExchangeRateFeed>();
            mockObject.Setup(x => x.GetActualUSDValue()).Returns(50);

            return mockObject.Object;
        }

        [Fact]
        public void Test1()
        {
            IUSD_INR_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 3);
            int expectedResult = 3;
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TC1_DivideByZero()
        {
            IUSD_INR_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            var ex =  Assert.Throws<DivideByZeroException>(()  => calculator.Divide(9, 0));
        }

        [Fact]
        public void TC3_ConvertUSDtoCLPTest()
        {
            IUSD_INR_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoINR(1);
            int expectedResult = 50;
            Assert.Equal(expectedResult, actualResult);
        }
    }

    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multipy(int param1, int param2);
        int Divide(int param1, int param2);
        int ConvertUSDtoINR(int unit);
    }

    public interface IUSD_INR_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }

    public class Calculator : ICalculator
    {
        private IUSD_INR_ExchangeRateFeed _feed;

        public Calculator(IUSD_INR_ExchangeRateFeed feed)
        {
            this._feed = feed;
        }


        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        public int ConvertUSDtoINR(int unit)
        {
            return unit * this._feed.GetActualUSDValue();
        }

        public int Divide(int param1, int param2)
        {
            return param1 / param2;
        }

        public int Multipy(int param1, int param2)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
    }
}
