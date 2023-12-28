using API.Entities.Plans.Traning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations.Traning
{
    public class InstrumentConfiguration : IEntityTypeConfiguration<Instrument>
    {
        public void Configure(EntityTypeBuilder<Instrument> builder)
        {
            builder.ToTable("Instrument");

            builder.HasKey(e => e.IdInstrument);

            builder.Property(e => e.Name).HasMaxLength(100);

            builder.HasData(new List<Instrument>
            {
                new Instrument
                {
                    IdInstrument = 1,
                    Name = "Dumbbells"
                },
                new Instrument
                {
                    IdInstrument = 2,
                    Name = "Barbell"
                },
                new Instrument
                {
                    IdInstrument = 3,
                    Name = "Kettlebell"
                },
                new Instrument
                {
                    IdInstrument = 4,
                    Name = "Resistance Bands"
                },
                new Instrument
                {
                    IdInstrument = 5,
                    Name = "Medicine Ball"
                }
            });
        }
    }
}
