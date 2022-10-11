using System;
using System.Globalization;


namespace MediaNoteAluno2 {
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((2.0 * A) + (3.0 * B) + (5.0 * C)) / 10.0;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}