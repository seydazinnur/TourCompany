using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Configurations
{
    class TourConfiguration : EntityTypeConfiguration<Tour>
    {
        public TourConfiguration()
        {
            HasKey(a => new { a.PlaceID, a.TouristID, a.CiceroneID });
            //oko
            Property(a => a.TourDate)
                .HasColumnType("datetime2");

            HasRequired(a => a.Cicerone)
                .WithMany(a => a.Tours)
                .HasForeignKey(a => a.CiceroneID)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.Tourist)
                .WithMany(a => a.Tours)
                .HasForeignKey(a => a.TouristID)
                .WillCascadeOnDelete(false);

            Map(a => a.MapInheritedProperties());
        }
    }
}
