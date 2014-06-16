using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataOCR
{
    public class AccountNumProcessor
    {
        private const string ZERO = " _ | ||_|";
        private const string ONE = "     |  |";
        private const string TWO = " _  _||_ ";
        private const string THREE = " _  _| _|";
        private const string FOUR = "   |_|  |";
        private const string FIVE = " _ |_  _|";
        private const string SIX = " _ |_ |_|";
        private const string SEVEN = " _   |  |";
        private const string EIGHT = " _ |_||_|";
        private const string NINE = " _ |_| _|";

        public string DetermineAccountNumber(List<string> accountLines)
        {
            StringBuilder accountNumber = new StringBuilder();
            for (int i = 0; i < accountLines.Count; i += 4)
            {
                string firstLine = accountLines[i];
                string secondLine = accountLines[i + 1];
                string thirdLine = accountLines[i + 2];

                for (int lineSubstr = 0; lineSubstr < 27; lineSubstr += 3)
                {
                    string number = firstLine.Substring(lineSubstr, 3) + secondLine.Substring(lineSubstr, 3) + thirdLine.Substring(lineSubstr, 3);
                    accountNumber.Append(DetermineStringNumber(number));
                }
                
            }

            return accountNumber.ToString();
        }

        private string DetermineStringNumber(string number)
        {
            switch (number)
            {
                case ZERO:
                    return "0";
                case ONE:
                    return "1";
                case TWO:
                    return "2";
                case THREE:
                    return "3";
                case FOUR:
                    return "4";
                case FIVE:
                    return "5";
                case SIX:
                    return "6";
                case SEVEN:
                    return "7";
                case EIGHT:
                    return "8";
                case NINE:
                    return "9";
                default:
                    return string.Empty;
            }
        }
    }
}
