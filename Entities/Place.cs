using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Entities
{
    class Place :BaseEntity
    {
        public Place()
        {
            Tours = new HashSet<Tour>();
        }
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }

        public ICollection<Tour> Tours { get; set; }
    }
}
