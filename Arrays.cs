using System;
using System.Globalization;

namespace CursoCSharp
{
    class Array
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];

            }

            double avg = sum / 3;

            Console.WriteLine("Average Height = " + avg.ToString("F2", CultureInfo.InvariantCulture))
        }
    }
}