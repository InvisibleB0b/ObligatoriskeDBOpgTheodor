using System;

namespace HotelsClasses
{
    public class Hotel
    {

        public int Hotel_Id { get; set; }
        public string Hotel_Name { get; set; }
        public string Hotel_Address { get; set; }

        public override string ToString()
        {
            return $"{nameof(Hotel_Id)}: {Hotel_Id}, {nameof(Hotel_Name)}: {Hotel_Name}, {nameof(Hotel_Address)}: {Hotel_Address}";
        }
    }
}
