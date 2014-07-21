using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter todaysConverter = new Converter(16.25, 11.91, 3.27);

            Console.WriteLine("Please input amount to convert");
            double convertingAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please choose currency you want to convert from: UAH, USD, EUR, RUR");
            string currencyConvertFrom = Console.ReadLine().ToLower();

            switch (currencyConvertFrom)
            {
                case "uah":
                    {
                        Console.WriteLine("Choose currency you want to convert to: USD, EUR, RUR");
                        string currencyConvertTo = Console.ReadLine().ToLower();

                        if (currencyConvertTo == "usd")
                        {
                            Console.WriteLine("Converted amount: {0}",todaysConverter.ConvertToUsd(convertingAmount));
                        }
                        else if (currencyConvertTo == "eur")
                        {
                            Console.WriteLine("Converted amount: {0}", todaysConverter.ConvertToEur(convertingAmount));
                        }
                        else if (currencyConvertTo == "rur")
                        {
                            Console.WriteLine("Converted amount: {0}", todaysConverter.ConvertToRur(convertingAmount));
                        }

                        else
                        {
                            Console.WriteLine("Sorry, we can't convert to the specified currency");
                        }

                        break;
                    }
                case "eur":
                    {
                        Console.WriteLine("{0} EUR is {1} UAH",convertingAmount,todaysConverter.ConvertFromEurToUah(convertingAmount));
                        break;
                    }

                case "usd":
                    {
                        Console.WriteLine("{0} USD is {1} UAH", convertingAmount, todaysConverter.ConvertFromUsdToUah(convertingAmount));
                        break;
                    }

                case "rur":
                    {
                        Console.WriteLine("{0} RUR is {1} UAH", convertingAmount, todaysConverter.ConvertFromRurToUah(convertingAmount));
                        break;
                    }
            }
        }
    }
}
