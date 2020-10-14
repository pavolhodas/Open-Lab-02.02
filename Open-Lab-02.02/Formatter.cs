using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
                string space = "";
                string formattedNumbers = "";
            foreach (double number in numbers)
            {
                formattedNumbers += space + Math.Truncate(number * 100) / 100; ;
                space = " ";
            }
                Console.Write(formattedNumbers);
        }
    }
}
