using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task2
    {
        
            public void Run()
            {
            Converter converter = new Converter(39.5, 42.3, 48.1);

            Console.WriteLine("Введіть суму в гривнях: ");
            double uah = double.Parse(Console.ReadLine());

            Console.WriteLine($"UAH to USD: {converter.FromUAHToUSD(uah):F2}");
            Console.WriteLine($"UAH to EUR: {converter.FromUAHToEUR(uah):F2}");
            Console.WriteLine($"UAH to GBP: {converter.FromUAHToGBT(uah):F2}");

            Console.WriteLine("\nВведіть суму в USD для переведення в гривні: ");
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine($"USD to UAH: {converter.FromUSDToUAH(usd):F2}");

            Console.WriteLine("\nВведіть суму в EUR для переведення в гривні: ");
            double eur = double.Parse(Console.ReadLine());
            Console.WriteLine($"EUR to UAH: {converter.FromEURToUAH(eur):F2}");

            Console.WriteLine("\nВведіть суму в GBP для переведення в гривні: ");
            double gbt = double.Parse(Console.ReadLine());
            Console.WriteLine($"GBP to UAH: {converter.FromGBTToUAH(gbt):F2}");
        }
    }


    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double gbtRate;

        public Converter(double usd, double eur, double gbt)
        {
            usdRate = usd;
            eurRate = eur;
            gbtRate = gbt;
        }

        public double FromUAHToUSD(double amount)
        {
            return amount / usdRate;
        }

        public double FromUAHToEUR(double amount)
        {
            return amount / eurRate;
        }

        public double FromUAHToGBT(double amount)
        {
            return amount / gbtRate;
        }

        public double FromUSDToUAH(double amount)
        {
            return amount * usdRate;
        }

        public double FromEURToUAH(double amount)
        {
            return amount * eurRate;
        }

        public double FromGBTToUAH(double amount)
        {
            return amount * gbtRate;
        }
    }

}


