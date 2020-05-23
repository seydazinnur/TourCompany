using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Entities
{
    class Country : BaseEntity
    {
        public Country()
        {
            Tourists = new HashSet<Tourist>();
        }
        public int CountryID { get; set; }
        public string Name { get; set; }

        public ICollection<Tourist> Tourists { get; set; }
    }
}
