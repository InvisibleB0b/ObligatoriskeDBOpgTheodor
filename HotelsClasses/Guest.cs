using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsClasses
{
   public class Guest
    {
        public int Guest_Id { get; set; }
        public string Guest_Name { get; set; }
        public string Guest_Address { get; set; }

        public override string ToString()
        {
            return $"{nameof(Guest_Id)}: {Guest_Id}, {nameof(Guest_Name)}: {Guest_Name}, {nameof(Guest_Address)}: {Guest_Address}";
        }
    }
}
