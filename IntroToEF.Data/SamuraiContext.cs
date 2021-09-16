using IntroToEF.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace IntroToEF.Data
{
    // Context is absolutely essential in EF -> MUST inherit from DBContext
    public class SamuraiContext : DbContext
    {
        // Each entity that needs a table needs to be defined here
        public DbSet<Quote> Quotes { get; set; }

        public DbSet<Samurai> Samurais { get; set; }

        public DbSet<Horse> Horses { get; set; }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<Spouse> Spouses { get; set; }

        private const string CONNECTION = @"Server=.\SQLEXPRESS;Database=SamuraiDB2;Trusted_Connection=True;";

        // Override the OnConfigure to dictate which database is being used and the type of said DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION);
            //.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samurai>().HasData(
                new Samurai { Id = 1, Name = "Abe Masakatsu", Dynasty = "Asuka" },
                new Samurai { Id = 2, Name = "Baba Nobufusa", Dynasty = "Kamakura" },
                new Samurai { Id = 3, Name = "Chosokabe Nobuchika", Dynasty = "Kamakura" },
                new Samurai { Id = 4, Name = "Date Masamune", Dynasty = "Edo" },
                new Samurai { Id = 5, Name = "Eto Shinpei", Dynasty = "Meiji" },
                new Samurai { Id = 6, Name = "Fuma Kotaro", Dynasty = "Meiji" },
                new Samurai { Id = 7, Name = "Gamo Ujisato", Dynasty = "Edo" },
                new Samurai { Id = 8, Name = "Harada Nobutane", Dynasty = "Asuka" },
                new Samurai { Id = 9, Name = "Ii Naomasa", Dynasty = "Meiji" },
                new Samurai { Id = 10, Name = "Kido Takayoshi", Dynasty = "Edo" },
                new Samurai { Id = 11, Name = "Maeda Toshiie", Dynasty = "Edo" },
                new Samurai { Id = 12, Name = "Mori Okimoto", Dynasty = "Kamakura" });

            modelBuilder.Entity<Quote>().HasData(
                new Quote { Id = 1, SamuraiId = 1, Text = "Summer grasses, All that remains of soldiers' dreams" },
                new Quote { Id = 2, SamuraiId = 1, Text = "New eras don't come about because of swords, they're created by the people who wield them" },
                new Quote { Id = 3, SamuraiId = 2, Text = "A man who can't uphold his beliefs is pathetic dead or alive" },
                new Quote { Id = 4, SamuraiId = 2, Text = "I dreamt of worldly success once" },
                new Quote { Id = 5, SamuraiId = 5, Text = "Rehearse your death every morning and night. Only when you constantly live as though already a corpse will you be able to find freedom in the martial Way, and fulfill your duties without fault throughout your life" },
                new Quote { Id = 6, SamuraiId = 5, Text = "The Way of the warrior (bushido) is to be found in dying." },
                new Quote { Id = 7, SamuraiId = 7, Text = "It is the genius of life that demands of those who partake in it that they are not only the guardians of what was and is, but what will be" },
                new Quote { Id = 8, SamuraiId = 1, Text = "Bushido is realized in the presence of death. This means choosing death whenever there is a choice between life and death. There is no other reasoning" },
                new Quote { Id = 9, SamuraiId = 7, Text = "It is the genius of life that demands of those who partake in it that they are not only are guardians of what was and is, but what will be" },
                new Quote { Id = 10, SamuraiId = 10, Text = "The katana has been the weapon of the samurai since time immemorial. Consider the inner meaning" },
                new Quote { Id = 11, SamuraiId = 5, Text = "Death is just another journey" },
                new Quote { Id = 12, SamuraiId = 12, Text = "No matter how much you hate or how much you suffer, you can't bring the dead back to life" });

            modelBuilder.Entity<Horse>().HasData(
                new Horse { Id = 1, SamuraiId = 1, Name = "Barnaby", IsWarHorse = false, Age = 12 },
                new Horse { Id = 2, SamuraiId = 1, Age = 5, IsWarHorse = false, Name = "Lacey", },
                new Horse { Id = 3, SamuraiId = 1, Age = 5, IsWarHorse = true, Name = "Boeddika" },
                new Horse { Id = 4, SamuraiId = 6, Age = 7, IsWarHorse = false, Name = "Lucky" },
                new Horse { Id = 5, SamuraiId = 6, Age = 5, IsWarHorse = false, Name = "Little Joe" },
                new Horse { Id = 7, SamuraiId = 11, Age = 7, IsWarHorse = false, Name = "Misty" },
                new Horse { Id = 8, SamuraiId = 11, Age = 5, IsWarHorse = false, Name = "Rembrandt" },
                new Horse { Id = 9, SamuraiId = 11, Age = 13, IsWarHorse = true, Name = "Traveler" });
        }
    }
}