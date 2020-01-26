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
            /*
                    Console.WriteLine("What is the base currency you would like to calculate from?");
                    string userFrom = Console.ReadLine();

                    Console.WriteLine("What is the currency you would like to calculate to?");
                    string userTo = Console.ReadLine();
                    Console.WriteLine("Write the amount: ");
                    double userAmount = int.Parse(Console.ReadLine());*/


            string url = "https://api.exchangeratesapi.io/latest";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();



            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                var currencyDetails = JsonConvert.DeserializeObject<List<CurrencyDetails>>(response);
                Console.WriteLine(currencyDetails[0].Base);
                Console.WriteLine(currencyDetails[0].Date);
                Console.WriteLine(currencyDetails[0].rates[0].CAD);
                
            }
        }
    }
}
