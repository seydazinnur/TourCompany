using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Configurations
{
    class TouristConfiguration : EntityTypeConfiguration<Tourist>
    {
        public TouristConfiguration()
        {
            Property(a => a.TouristID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(a => a.Name)
                .HasMaxLength(20)
                .IsRequired();

            Property(a => a.Surname)
                .HasMaxLength(30)
                .IsRequired();

            Property(a => a.Gender)
                .HasMaxLength(1)
                .HasColumnType("char")
                .IsRequired();

            Property(a => a.BirthDate)
                .HasColumnType("datetime2")
                .IsRequired();

            HasRequired(a => a.Nationality)
                 .WithMany(a => a.Tourists)
                 .HasForeignKey(a => a.NationalityID)
                 .WillCascadeOnDelete(false);

            HasMany(a => a.Countries)
                .WithMany(a => a.Tourists)
                .Map(a =>
                {
                    a.ToTable("TouristCountry");
                    a.MapLeftKey("TouristID");
                    a.MapRightKey("CountryID");
                });

            Map(a => a.MapInheritedProperties());
        }
    }
}
