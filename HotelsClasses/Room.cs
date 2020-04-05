using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsClasses
{
    class Room
    {
        public int Room_Id { get; set; }
        public int Hotel_Id { get; set; }
        public int Room_No { get; set; }
        public char Room_Type { get; set; }
        public double Room_Price { get; set; }
    }
}
