using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Configurations
{
    class NationalityConfiguration : EntityTypeConfiguration<Nationality>
    {
        public NationalityConfiguration()
        {
            Property(a => a.NationalityID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(a => a.Description)
                .HasMaxLength(30)
                .IsRequired();

            Map(a => a.MapInheritedProperties());
        }
    }
}
