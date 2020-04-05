using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsClasses
{
   public class Room
    {
        public int Room_Id { get; set; }
        public int Hotel_Id { get; set; }
        public int Room_No { get; set; }
        public char Room_Type { get; set; }
        public double Room_Price { get; set; }

        public override string ToString()
        {
            return $"{nameof(Room_Id)}: {Room_Id}, {nameof(Hotel_Id)}: {Hotel_Id}, {nameof(Room_No)}: {Room_No}, {nameof(Room_Type)}: {Room_Type}, {nameof(Room_Price)}: {Room_Price}";
        }
    }
}
