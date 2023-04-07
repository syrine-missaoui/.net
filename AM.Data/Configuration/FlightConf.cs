using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configuration
{
    internal class FlightConf: IEntityTypeConfiguration<Flight>
    {
    

        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(f => f.Passengers)
                 .WithMany(p => p.Flights).UsingEntity(t => t.ToTable("fp"));
             
        }
    }
}
