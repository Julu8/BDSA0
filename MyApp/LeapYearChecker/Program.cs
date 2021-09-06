using System;

namespace LeapYearChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            try {
                Console.Write("Enter Year: ");
                string input = Console.ReadLine();
                int year = Convert.ToInt32(input);
                var testYear = new Program();  
                testYear.isLeapYear(year);
            } catch (FormatException e){
                Console.WriteLine("Year needs to be a number: {0}", e.Message);
            } catch (NumberTooLowException e){
                Console.WriteLine("NumberTooLowException: {0}", e.Message);
            }
        }

        public bool isLeapYear(int year){
            if (year < 1582){
                throw (new NumberTooLowException("Year needs to be above 1582."));
            }
            else if ((year % 400) == 0){
                Console.WriteLine("Yay");
                return true;
            }
            else if ((year % 100) == 0){
                Console.WriteLine("Nay");
                return false;
            }
            else if ((year % 4) == 0){
                Console.WriteLine("Yay");
                return true;
            }
            
            else {
                Console.WriteLine("Nay");
                return false;
            }
        }

        public class NumberTooLowException: Exception {
            public NumberTooLowException(string message): base(message){}
        }

    }
}
