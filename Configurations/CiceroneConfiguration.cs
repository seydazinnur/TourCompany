using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20200415_Tour.Configurations
{
    class CiceroneConfiguration : EntityTypeConfiguration<Cicerone>
    {
        public CiceroneConfiguration()
        {
            Property(a => a.CiceroneID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .HasMaxLength(20)
                .IsRequired();

            Property(a => a.Surname)
                .HasMaxLength(30)
                .IsRequired();

            Property(a => a.PhoneNumber)
                .HasMaxLength(10)
                .HasColumnType("char")
                .IsRequired();

            Map(a => a.MapInheritedProperties());
        }
    }
}
