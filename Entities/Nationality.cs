using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Entities
{
    class Nationality : BaseEntity
    {
        public Nationality()
        {
            Tourists = new HashSet<Tourist>();
        }
        public int NationalityID { get; set; }
        public string Description { get; set; }

        public ICollection<Tourist> Tourists { get; set; }
    }
}
