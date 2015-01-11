using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Training.FizzBuzz.Business
{
    public class FizzBuzzCalculator
    {
        public string[] CalculateNumber(int minNumber, int maxNumber)
        {
            string[] result = new string[101];

            if ((minNumber < 0 || minNumber > 100) || (maxNumber < 0 || maxNumber > 100))
            {
                throw new IndexOutOfRangeException("The minimum and maximum number should be between 0 and 100");
            }

            int divFizzValue = 0;
            int divBuzzValue = 0;
            for (int i = minNumber; i <= maxNumber; i++)
            {
                result[i] = i.ToString();
                divFizzValue = i % 3;
                if (divFizzValue == 0) result[i] = "Fizz";
                divBuzzValue = i % 5;
                if (divBuzzValue == 0) result[i] = "Buzz";
                if (divFizzValue == 0 && divBuzzValue == 0) result[i] = "FizzBuzz";
            }

            return result;
        }
    }
}
