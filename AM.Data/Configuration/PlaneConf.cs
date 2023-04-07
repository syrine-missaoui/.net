using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Immutable.ImmutableArray<T>;

namespace AM.Data.Configuration
{
    internal class PlaneConf: IEntityTypeConfiguration<Plane> //implementans


    { 
         internal void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlane");
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");
            builder.HasKey(p => p.Capacity);
        }
    }
}
