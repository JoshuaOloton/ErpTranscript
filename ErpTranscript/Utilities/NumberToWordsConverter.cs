namespace ErpTranscript.Utilities
{
    public class NumberToWordsConverter
    {
        private static string[] ones =
        {
            "Zero", "One", "Two", "Three", "Four",
            "Five", "Six", "Seven", "Eight", "Nine"
        };

        private static string[] teens =
        {
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static string[] tens =
        {
            "", "", "Twenty", "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        private static string[] thousands =
        {
            "", "Thousand", "Million", "Billion"
        };

        public string ConvertToWords(int number)
        {
            if (number == 0)
                return ones[0];

            if (number < 0)
                return "Minus " + ConvertToWords(Math.Abs(number));

            string words = "";

            int groupCount = 0;
            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    words = ConvertGroupToWords(number % 1000) + thousands[groupCount] + " " + words;
                }

                number /= 1000;
                groupCount++;
            }

            return words.Trim();
        }

        private static string ConvertGroupToWords(int number)
        {
            string groupWords = "";

            if (number % 100 < 10)
            {
                groupWords = ones[number % 100];
                number /= 100;
            }
            else if (number % 100 < 20)
            {
                groupWords = teens[number % 10];
                number /= 10;
            }
            else
            {
                groupWords = ones[number % 10];
                number /= 10;

                groupWords = tens[number % 10] + " " + groupWords;
                number /= 10;
            }

            if (number == 0)
                return groupWords;

            return ones[number] + " Hundred " + groupWords;
        }
    }
}
