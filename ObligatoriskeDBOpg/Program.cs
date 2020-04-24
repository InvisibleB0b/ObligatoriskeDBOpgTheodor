using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HotelsClasses;
using Newtonsoft.Json;

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

                    Console.WriteLine("få alle hoteller \n");
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

                    Console.WriteLine("\nGet hotel, med adresse med roskilde i sig \n");

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

                    Console.WriteLine("\nIndsæt ny hotel \n");

                    Hotel hotel_to_insert = new Hotel() { Hotel_Address = "test til JP", Hotel_Name = "Test til JP" };

                    int id_fromH = 0;

                    repsonse = client.PostAsJsonAsync("api/hotels", hotel_to_insert).Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        int hotelId = repsonse.Content.ReadAsAsync<int>().Result;

                        Console.WriteLine(hotelId);
                        id_fromH = hotelId;
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }

                    Console.WriteLine("\nOpdater Et Hotel \n");

                    Hotel updatedHotel = new Hotel() { Hotel_Address = "Opdateret for JP", Hotel_Name = "Opdateret for JP" };

                    repsonse = client.PutAsJsonAsync($"api/hotels/{id_fromH}", updatedHotel).Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        Hotel hotel = repsonse.Content.ReadAsAsync<Hotel>().Result;

                        Console.WriteLine(hotel);
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }
                    Console.WriteLine("\nSlet et Hotel \n");

                    repsonse = client.DeleteAsync($"api/hotels/{id_fromH}").Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Succeeded");
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }


                    Console.WriteLine("\nfå alle Facaliteter \n");
                    repsonse = client.GetAsync("api/facility").Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        List<Facility> facilities = repsonse.Content.ReadAsAsync<List<Facility>>().Result;

                        foreach (Facility facility in facilities)
                        {
                            Console.WriteLine(facility);
                        }
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }

                    Console.WriteLine("\nfå et Facalitet med id 1 \n");
                    repsonse = client.GetAsync($"api/facility/1").Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        Facility facility = repsonse.Content.ReadAsAsync<Facility>().Result;

                       
                            Console.WriteLine(facility);
                        
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }

                    Console.WriteLine("\n Opret et Facalitet og får facilitet Id der bliver oprettet tilbage\n");

                    Facility fToInsert = new Facility() { Facility_Name = "JP TEST" };

                    int id_from_f = 0;

                    repsonse = client.PostAsJsonAsync("api/facility/1", fToInsert).Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        id_from_f = repsonse.Content.ReadAsAsync<int>().Result;


                        Console.WriteLine(id_from_f);

                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }

                    Console.WriteLine("\nOpdatere den facalitet der lige er blevet indsat \n");

                    Facility updatedF = new Facility() { Facility_Name = "Se JP Den Virker" };

                    repsonse = client.PutAsJsonAsync($"api/facility/{id_from_f}", updatedF).Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        Facility facility = repsonse.Content.ReadAsAsync<Facility>().Result;


                        Console.WriteLine(facility);

                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }

                    Console.WriteLine("\nSletter den vi lige har indsat \n");

                    repsonse = client.DeleteAsync($"api/facility/{id_from_f}").Result;
                    if (repsonse.IsSuccessStatusCode)
                    {
                        Console.WriteLine("den blev slettet");

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
