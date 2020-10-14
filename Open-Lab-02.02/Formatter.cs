using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            //double[] numberss = new double[5] { 10.531, 20.221, 30.4866, 40.4612, 50.987 };

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
