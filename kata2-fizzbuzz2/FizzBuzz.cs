using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata2_fizzbuzz2
{
    public static class FizzBuzz
    {
        public static string Generate(string number)
        {
            if (IsDivisibleByDiv(number, 15)) return "FizzBuzz";
            if (IsDivisibleByDiv(number,3)) return "Fizz";
            if (IsDivisibleByDiv(number, 5)) return "Buzz";
            return number;

        }

        private static bool IsDivisibleByDiv(string number, long div)
        {
            return int.Parse(number) % div == 0;
        }

        public static string Compute()
        {
            var number = 1;
            var result = "";
            while(number <= 100)
            {
                result+= Generate(number.ToString());
                number++;
            }
            return result;
        }
    }
}
