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
            
                    Console.WriteLine("What is the base currency you would like to calculate from?");
                    string userFrom = Console.ReadLine();

                    Console.WriteLine("What is the currency you would like to calculate to?");
                    string userTo = Console.ReadLine();
            //Console.WriteLine("Write the amount: ");
            //double userAmount = int.Parse(Console.ReadLine());
            string name = $"{userFrom}_{userTo}";

            string url = ($"https://free.currconv.com/api/v7/convert?q= + {userFrom} + _ + {userTo} + &compact=ultra&apiKey=80530c6ddead743e8d0d");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            List<Value> values = new List<Value>();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                CurrencyDetails currencyDetails = JsonConvert.DeserializeObject<CurrencyDetails>(response);
                
                

            }
        }
    }
}
