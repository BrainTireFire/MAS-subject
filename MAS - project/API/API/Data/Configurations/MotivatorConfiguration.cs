using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Configurations
{
    public class MotivatorConfiguration : IEntityTypeConfiguration<Motivator>
    {
        public void Configure(EntityTypeBuilder<Motivator> builder)
        {
            builder.ToTable("Motivator");

            builder.HasKey(e => e.IdMotivator);

            builder.Property(e => e.Name).HasMaxLength(100);

            builder.HasData(new List<Motivator>
            {
                new Motivator
                {
                    IdMotivator = 1,
                    Name = "John Doe",
                    Pseudonym = "MotivatorX",
                    MotivatingWords = new List<string>
                    {
                        "You are capable of greatness!",
                        "Believe in yourself and your dreams.",
                        "Every step you take brings you closer to your goals.",
                        "Embrace challenges and grow stronger.",
                        "You have the power to create the life you desire."
                    }
                },
                new Motivator
                {
                    IdMotivator = 2,
                    Name = "Emily Smith",
                    Pseudonym = "InspireMe",
                    MotivatingWords = new List<string>
                    {
                        "You are stronger than you think.",
                        "Doubt kills more dreams than failure ever will.",
                        "Your persistence will lead to success.",
                        "Embrace the journey, not just the destination.",
                        "You have the potential to make a difference."
                    }
                },
                new Motivator
                {
                    IdMotivator = 3,
                    Name = "David Johnson",
                    Pseudonym = "MotivateToday",
                    MotivatingWords = new List<string>
                    {
                        "You have the power to overcome any obstacle.",
                        "Success is not final, failure is not fatal: It is the courage to continue that counts.",
                        "You are capable of achieving greatness.",
                        "Stay focused and never give up on your dreams.",
                        "The only limit is the one you set for yourself."
                    }
                },
                new Motivator
                {
                    IdMotivator = 4,
                    Name = "Sarah Thompson",
                    Pseudonym = "PositiveVibes",
                    MotivatingWords = new List<string>
                    {
                        "Believe in yourself and all that you are.",
                        "Your positive attitude can change your life.",
                        "Every day is a new opportunity to grow.",
                        "Choose to be optimistic and see the beauty in life.",
                        "You are the author of your own story. Write it with joy and enthusiasm."
                    }
                },
                new Motivator
                {
                    IdMotivator = 5,
                    Name = "Michael Rodriguez",
                    Pseudonym = "DreamAchiever",
                    MotivatingWords = new List<string>
                    {
                        "Dream big, work hard, and make it happen.",
                        "Success is not just about making money, it's about making a difference.",
                        "You have the potential to achieve extraordinary things.",
                        "Never underestimate the power of your dreams.",
                        "Every day is a new chance to chase your dreams and make them a reality."
                    }
                }
            });
        }
    }
}
