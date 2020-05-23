using _20200415_Tour.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200415_Tour.Configurations
{
    class PlaceConfiguration : EntityTypeConfiguration<Place>
    {
        public PlaceConfiguration()
        {
            Property(a => a.PlaceID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(a => a.PlaceName)
                .HasMaxLength(50)
                .IsRequired();

            HasMany(a => a.Tours)
                .WithRequired(a => a.Place)
                .HasForeignKey(a => a.PlaceID)
                .WillCascadeOnDelete(false);

            Map(a => a.MapInheritedProperties());
        }
    }
}
