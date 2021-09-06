using System;
using Xunit;
using LeapYearChecker;

namespace LeapYearTester.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(200)]
        public void TestFalse(int year)
        {
            var result = new LeapYearChecker.Program().isLeapYear(year);
            Assert.False(result, $"{year} should not be a leap year.");  
        }

        [Theory]
        [InlineData(4)]
        [InlineData(400)]
        [InlineData(800)]
        public void TestTrue(int year){
            var result = new LeapYearChecker.Program().isLeapYear(year);
            Assert.True(result, $"{year} should be a leap year.");
        }
    }
}
