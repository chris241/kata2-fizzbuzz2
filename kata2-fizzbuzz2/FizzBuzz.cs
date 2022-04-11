using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata2_fizzbuzz2
{
    public static class FizzBuzz
    {
        public static object Generate(string number)
        {
            if (IsDivisibleBy3(number, 15)) return "FizzBuzz";
            if (IsDivisibleBy3(number,3)) return "Fizz";
            if (IsDivisibleBy3(number, 5)) return "Buzz";
            return int.Parse(number);

        }

        private static bool IsDivisibleBy3(string number, long div)
        {
            return int.Parse(number) % div == 0;
        }
    }
}
