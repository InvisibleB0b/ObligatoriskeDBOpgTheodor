using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelsClasses;
using HotelsControllers;

namespace ObligatoriskeDBOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageHotels manageHotels = new ManageHotels();

            List<Hotel> hotels = manageHotels.GetAlle();

            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(hotel);
            }

            Console.ReadKey();

        }
    }
}
