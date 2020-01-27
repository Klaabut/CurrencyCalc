using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nancy;

namespace CurrencyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS IS FUNCTIONAL, BUT I'M NOT PROUD OF IT.
            Console.WriteLine("Welcome to my currency converter. Currently supported currencies: EUR, USD, GBP, AUD, CAD, PLN, RUB");
                    Console.WriteLine("What is the base currency you would like to calculate from?");
                    string userFrom = Console.ReadLine();

                    Console.WriteLine("What is the currency you would like to calculate to?");
                   string userTo = Console.ReadLine();
            Console.WriteLine("Write the amount: ");
            double userAmount = int.Parse(Console.ReadLine());
            string name = $"{userFrom}_{userTo}".ToUpper();

            string url = ($"https://free.currconv.com/api/v7/convert?q={userFrom}_{userTo}&compact=ultra&apiKey=80530c6ddead743e8d0d");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();


            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                CurrencyDetails currencyDetails = JsonConvert.DeserializeObject<CurrencyDetails>(response);
                
                if(name == "EUR_USD")
                {
                    Console.WriteLine($"Result: {currencyDetails.EUR_USD * userAmount} USD.");
                }
                else if(name == "EUR_GBP")
                {
                    Console.WriteLine($"Result: {currencyDetails.EUR_GBP * userAmount} GBP.");
                }
                else if (name == "EUR_AUD")
                {
                    Console.WriteLine($"Result: {currencyDetails.EUR_AUD * userAmount} AUD.");
                }
                else if (name == "EUR_CAD")
                {
                    Console.WriteLine($"Result: {currencyDetails.EUR_CAD * userAmount} CAD.");
                }
                else if (name == "EUR_PLN")
                {
                    Console.WriteLine($"Result: {currencyDetails.EUR_PLN * userAmount} PLN.");
                }
                else if (name == "EUR_RUB")
                {
                    Console.WriteLine($"Result: {currencyDetails.EUR_RUB * userAmount} RUB.");
                }

                else if (name == "USD_EUR")
                {
                    Console.WriteLine($"Result: {currencyDetails.USD_EUR * userAmount} EUR.");
                }
                else if (name == "USD_GBP")
                {
                    Console.WriteLine($"Result: {currencyDetails.USD_GBP * userAmount} GBP.");
                }
                else if (name == "USD_AUD")
                {
                    Console.WriteLine($"Result: {currencyDetails.USD_AUD * userAmount} AUD.");
                }
                else if (name == "USD_CAD")
                {
                    Console.WriteLine($"Result: {currencyDetails.USD_CAD * userAmount} CAD.");
                }
                else if (name == "USD_PLN")
                {
                    Console.WriteLine($"Result: {currencyDetails.USD_PLN * userAmount} PLN.");
                }
                else if (name == "USD_RUB")
                {
                    Console.WriteLine($"Result: {currencyDetails.USD_RUB * userAmount} RUB.");
                }

                else if (name == "GBP_EUR")
                {
                    Console.WriteLine($"Result: {currencyDetails.GBP_EUR * userAmount} EUR.");
                }
                else if (name == "GBP_USD")
                {
                    Console.WriteLine($"Result: {currencyDetails.GBP_USD * userAmount} USD.");
                }
                else if (name == "GBP_AUD")
                {
                    Console.WriteLine($"Result: {currencyDetails.GBP_AUD * userAmount} AUD.");
                }
                else if (name == "GBP_CAD")
                {
                    Console.WriteLine($"Result: {currencyDetails.GBP_CAD * userAmount} CAD.");
                }
                else if (name == "GBP_PLN")
                {
                    Console.WriteLine($"Result: {currencyDetails.GBP_PLN * userAmount} PLN.");
                }
                else if (name == "GBP_RUB")
                {
                    Console.WriteLine($"Result: {currencyDetails.GBP_RUB * userAmount} RUB.");
                }
                else if (name == "AUD_EUR")
                {
                    Console.WriteLine($"Result: {currencyDetails.AUD_EUR * userAmount} EUR.");
                }
                else if (name == "AUD_USD")
                {
                    Console.WriteLine($"Result: {currencyDetails.AUD_USD * userAmount} USD.");
                }
                else if (name == "AUD_CAD")
                {
                    Console.WriteLine($"Result: {currencyDetails.AUD_CAD * userAmount} CAD.");
                }
                else if (name == "AUD_PLN")
                {
                    Console.WriteLine($"Result: {currencyDetails.AUD_PLN * userAmount} PLN.");
                }
                else if (name == "AUD_RUB")
                {
                    Console.WriteLine($"Result: {currencyDetails.AUD_RUB * userAmount} RUB.");
                }
                else if (name == "CAD_EUR")
                {
                    Console.WriteLine($"Result: {currencyDetails.CAD_EUR * userAmount} EUR.");
                }
                else if (name == "CAD_USD")
                {
                    Console.WriteLine($"Result: {currencyDetails.CAD_USD * userAmount} USD.");
                }
                else if (name == "CAD_GBP")
                {
                    Console.WriteLine($"Result: {currencyDetails.CAD_GBP * userAmount} GBP.");
                }
                else if (name == "CAD_AUD")
                {
                    Console.WriteLine($"Result: {currencyDetails.CAD_AUD * userAmount} AUD.");
                }
                else if(name == "CAD_PLN")
                {
                    Console.WriteLine($"Result: {currencyDetails.CAD_PLN * userAmount} PLN.");
                }
                else if (name == "CAD_RUB")
                {
                    Console.WriteLine($"Result: {currencyDetails.CAD_RUB * userAmount} RUB.");
                }
                else if (name == "PLN_EUR")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_EUR * userAmount} EUR.");
                }
                else if (name == "PLN_USD")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_USD * userAmount} USD.");
                }
                else if (name == "PLN_GBP")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_GBP * userAmount} GBP.");
                }
                else if (name == "PLN_AUD")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_AUD * userAmount} AUD.");
                }
                else if (name == "PLN_CAD")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_CAD * userAmount} CAD.");
                }
                else if (name == "PLN_RUB")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_RUB * userAmount} RUB.");
                }
                else if (name == "RUB_EUR")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_EUR * userAmount} EUR.");
                }
                else if (name == "RUB_USD")
                {
                    Console.WriteLine($"Result: {currencyDetails.PLN_USD * userAmount} USD.");
                }
                else if (name == "RUB_GBP")
                {
                    Console.WriteLine($"Result: {currencyDetails.RUB_GBP * userAmount} GBP.");
                }
                else if (name == "RUB_AUD")
                {
                    Console.WriteLine($"Result: {currencyDetails.RUB_AUD * userAmount} AUD.");
                }
                else if (name == "RUB_CAD")
                {
                    Console.WriteLine($"Result: {currencyDetails.RUB_CAD * userAmount} CAD.");
                }
                else if (name == "RUB_PLN")
                {
                    Console.WriteLine($"Result: {currencyDetails.RUB_PLN * userAmount} PLN");
                }
                else if (name == "AUD_GBP")
                {
                    Console.WriteLine($"Result: {currencyDetails.AUD_GBP * userAmount} GBP.");
                }


            }
        }
    }
}
