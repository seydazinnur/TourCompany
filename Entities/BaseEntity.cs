using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Entities
{
    abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public BaseEntity()
        {
            this.CreatedDate = DateTime.Now;
            IsActive = true;
        }
    }
}
