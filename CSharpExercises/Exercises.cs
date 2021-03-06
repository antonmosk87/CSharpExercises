﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        //public static string HelloWorld()
        //{
        //    return "Hello World!";
        //}

        //public static string ReverseStringHard(string quote)
        //{
        //    throw new NotImplementedException();
        //}

		/* Alright - your turn now! */

		// 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")

		public static string SayHello(string name)
		{
			
			return "Hello " + name + "!"; 
		}
		// 2. Create a method called Sum that accepts two integers and returns their sum.

		public static int Sum(int a, int b)
		{
			return a + b;
		}
		// 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.

		public static decimal Divide(decimal a, decimal b)
		{
			return a / b;
		}
		// 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.

		public static bool CanOpenCheckingAccount(int age)
		{
			return age >= 18;
		}
		// 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.

		public static string GetFirstName(string name)
		{
		
			return name.Substring(0,name.IndexOf(" "));

		}
		// 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)

		public static string ReverseStringHard(string word)
		{
		
            string reverse = "";

            foreach (char letter in word)
            {
                reverse = letter + reverse;
            }

            return reverse;
		}
		// 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)

		public static string ReverseStringEasy(string word)
		{
			char[] array = word.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}
		// 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.

		public static string PrintTimesTable(int a)
		{
			int x = 0;
			string text = "";
			
			for (int i = 1; i < 11; i++)
			{
				x = a * i;
				text += a.ToString() + " * " + i.ToString() + " = " + x.ToString();
                if (i != 10)
                {
                    text += Environment.NewLine;
                }
			}

			return text;
		}
		/* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 100 */

		// 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.

		public static double ConvertKelvinToFahrenheit(double temp)
		{
			return Math.Round((temp * 9 / 5 - 459.67),2);
		}
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)

        public static double GetAverageHard(int[] average)
        {

            double x = 0;
            int length = average.Length;
            foreach (int i in average)
            {
                x += i;
            }

            return x / length;
        }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)

        public static double GetAverageEasy(int[] average)
        {
            return average.Average();
        }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        public static string DrawTriangle(int number, int width)
        {

            
            string text = "";
            string numString = number.ToString();

            for (int i = width; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    text += numString;
                }

                if (i != 1)
                {
                    text += Environment.NewLine;
                }
            }

            return text;

        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")

        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {

           double time = hours + ((double) minutes/60) + ((double) seconds/3600);


           double MPH = Math.Round(distance / time);

           return MPH.ToString() + "MPH";


        }


        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.

        public static bool IsVowel(char x)
        {


            string z = x.ToString().ToLower();

            return (z == "a" || z == "e" || z == "i" || z == "o" || z == "u");


        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.

        public static bool IsConsonant(char x)
        {
            string z = x.ToString().ToLower();

            return (z != "a" && z != "e" && z != "i" && z != "o" && z != "u");
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

        public static int CollatzConjecture(int n)
        {

            int count = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    count++;
                }
                else
                {
                    n = (n * 3) + 1;
                    count++;
                }
            }
            return count;
        }

        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).

        public static DateTime[] GetNext7Days(DateTime dateTime)
        {
            DateTime[] dateTimes = new DateTime[7];

            for(int i = 0; i < dateTimes.Length; i++)
            {
                dateTimes[i] = dateTime.AddDays(i);
            }


            return dateTimes;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)



        public static bool IsInLeapYear(int x)
        {
            return ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0));
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        public static double MortgageCalculator(double loanB, double interestR, int loanT, int payP)
        {


            return Math.Round(((interestR / 100 / payP) * loanB) / (1 - Math.Pow((1 + (interestR / 100 / payP)), (-loanT * payP))),2);
        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        public static string DuckGoose(int x)
        {
            int i = 0;
            string text = "";
            while (i < x)
            {
                i++;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    text += "DuckGoose";
                }
                else if (i % 3 == 0)
                {
                    text += "Duck";
                }
                else if (i % 5 == 0)
                {
                    text += "Goose";
                }
                else
                {
                    text = text + i.ToString();
                }
                if (i != x)
                {
                    text = text + Environment.NewLine;
                }

            }
            return text;
        }

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}