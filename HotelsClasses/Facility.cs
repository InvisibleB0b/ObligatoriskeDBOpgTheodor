using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsClasses
{
   public class Facility
    {
        public int Facility_Id { get; set; }
        public string Facility_Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Facility_Id)}: {Facility_Id}, {nameof(Facility_Name)}: {Facility_Name}";
        }
    }
}
