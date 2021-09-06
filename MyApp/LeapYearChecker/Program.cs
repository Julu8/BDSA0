using System;

namespace LeapYearChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Year: ");
            string input = Console.ReadLine();
            int year = Convert.ToInt32(input);
            var testYear = new Program(); 
            testYear.isLeapYear(year);
        }

        public bool isLeapYear(int year){
            if ((year % 400) == 0){
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

    }
}
