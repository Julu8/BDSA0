using System;
using System.IO;
using Xunit;
using LeapYearChecker;

namespace LeapYearTester.Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(2001)]
        [InlineData(2100)]
        [InlineData(2200)]
        public void TestFalse(int year)
        {
            var result = new LeapYearChecker.Program().isLeapYear(year);
            Assert.False(result, $"{year} should not be a leap year.");  
        }

        [Theory]
        [InlineData(2004)]
        [InlineData(2400)]
        [InlineData(2800)]
        public void TestTrue(int year){
            var result = new LeapYearChecker.Program().isLeapYear(year);
            Assert.True(result, $"{year} should be a leap year.");
        }
        
        [Theory]
        [InlineData("2001")]
        [InlineData("2006")]
        [InlineData("2100")]
        [InlineData("2200")]
        public void UserTestFalse(string year){
            var writer = new StringWriter();
            var input = new StringReader(year);
            
            Console.SetOut(writer);
            Console.SetIn(input);

            LeapYearChecker.Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal($"Enter Year: Nay", output);
        }

        [Theory]
        [InlineData("2004")]
        [InlineData("2400")]
        [InlineData("2800")]
        public void UserTestTrue(string year){
            var writer = new StringWriter();
            var input = new StringReader(year);
            
            Console.SetOut(writer);
            Console.SetIn(input);

            LeapYearChecker.Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal($"Enter Year: Yay", output);
        }
    }
}
