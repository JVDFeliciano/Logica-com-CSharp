using System;
using System.Globalization;


namespace SomaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}