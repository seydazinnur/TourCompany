using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Entities
{
    class Tourist : BaseEntity
    {
        public Tourist()
        {
            Tours = new HashSet<Tour>();
            Countries = new HashSet<Country>();
        }
        public int TouristID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int NationalityID { get; set; }
        public string Gender { get; set; }



        public Nationality Nationality { get; set; }
        public ICollection<Country> Countries { get; set; }
        public ICollection<Tour> Tours { get; set; }
    }
}
