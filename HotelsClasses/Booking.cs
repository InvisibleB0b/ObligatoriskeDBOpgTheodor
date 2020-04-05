using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsClasses
{
   public class Booking
    {
        public int Booking_Id { get; set; }
        public int Room_Id { get; set; }
        public int Hotel_Id { get; set; }
        public int Guest_Id { get; set; }
        public DateTime Booking_Start { get; set; }
        public DateTime Booking_End { get; set; }

        public override string ToString()
        {
            return $"{nameof(Booking_Id)}: {Booking_Id}, {nameof(Room_Id)}: {Room_Id}, {nameof(Hotel_Id)}: {Hotel_Id}, {nameof(Guest_Id)}: {Guest_Id}, {nameof(Booking_Start)}: {Booking_Start}, {nameof(Booking_End)}: {Booking_End}";
        }
    }
}
