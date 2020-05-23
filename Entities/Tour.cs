using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Entities
{
    class Tour :BaseEntity
    {
        public int CiceroneID { get; set; }
        public int TouristID { get; set; }
        public int PlaceID { get; set; }
        public DateTime TourDate { get; set; }

        public Cicerone Cicerone { get; set; }
        public Tourist Tourist { get; set; }
        public Place Place { get; set; }
    }
}
