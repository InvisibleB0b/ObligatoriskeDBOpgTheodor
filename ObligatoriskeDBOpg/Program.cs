using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HotelsClasses;

namespace ObligatoriskeDBOpg
{
    class Program
    {
        static void Main(string[] args)
        {

            const string ServerUrl = "http://localhost:50741/";

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var repsonse = client.GetAsync("api/hotels").Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        List<Hotel> hoteller = repsonse.Content.ReadAsAsync<List<Hotel>>().Result;

                        foreach (Hotel hotel in hoteller)
                        {
                            Console.WriteLine(hotel);
                        }
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }

                    repsonse = client.GetAsync("api/hotels?str=Roskilde").Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        Hotel hotel = repsonse.Content.ReadAsAsync<Hotel>().Result;

                        Console.WriteLine(hotel);
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }



            }

            Console.ReadKey();

        }
    }
}
