using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BrianLiuAssignment1
{
    public class Service : IService
    {
        public bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if ((number % i == 0))
                    return false;
            }
            return true;
        }

        public string ReverseOfString(string input)
        {
            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i].ToString();
            }
            return reverse;
        }

        public string SortNumbers(bool ascending, List<double> numberList)
        {
            if (ascending)           
                numberList.Sort((x, y) => x.CompareTo(y));
            else
                numberList.Sort((x, y) => y.CompareTo(x));

            return string.Join(", ", numberList);
        }

        public int SumOfDigits(int number)
        {
            string parsedNumber = Convert.ToString(number);
            int total = 0;

            for (int i = 0; i < parsedNumber.Length; i++)
            {
                int digit = int.Parse(parsedNumber[i].ToString());
                total += digit;
            }
            return total;
        }

        public string WrapInHTMLTags(string tag, string data)
        {
            return "<" + tag + ">" + data + "</" + tag + ">";
        }
    }
}