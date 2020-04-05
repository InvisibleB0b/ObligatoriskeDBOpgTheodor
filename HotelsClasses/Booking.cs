using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsClasses
{
    class Booking
    {
        public int Booking_Id { get; set; }
        public int Room_Id { get; set; }
        public int Hotel_Id { get; set; }
        public int Guest_Id { get; set; }
        public DateTime Booking_Start { get; set; }
        public DateTime Booking_End { get; set; }
    }
}
