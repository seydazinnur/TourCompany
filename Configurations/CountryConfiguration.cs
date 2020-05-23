using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Configurations
{
    class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            Property(a => a.CountryID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .HasColumnName("CountryName")
                .HasMaxLength(30)
                .IsRequired();

            Map(a => a.MapInheritedProperties());
        }
    }
}
