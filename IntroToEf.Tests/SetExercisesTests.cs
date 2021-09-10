using IntroToEF.Data.Entities;
using IntroToEF.Data.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace IntroToEf.Tests
{
    public class SetExercisesTests
    {
        //private GetExercises exercises;
        private Mock<ISamuraiRepo> _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new Mock<ISamuraiRepo>();
            _repo.Setup(x => x.GetAllSamurai()).Returns(GetTestData());

            //exercises = new GetExercises(_repo.Object);
        }

        // Mock database data zodat we onze tests kunnen runnen zonder de database te polluten met testdata.
        private List<Samurai> GetTestData()
        {
            return new List<Samurai>
            {
                new Samurai
                {
                    Id = 1, Name = "Abe Masakatsu", Dynasty = "Asuka",
                    Horses = new List<Horse>
                    {
                        new Horse { Id = 1, Age = 7, IsWarHorse = false, Name = "Barnaby", SamuraiId = 1 },
                        new Horse { Id = 2, Age = 5, IsWarHorse = false, Name = "Lacey", SamuraiId = 1 },
                        new Horse { Id = 3, Age = 3, IsWarHorse = true, Name = "Boeddika", SamuraiId = 1 },
                    },
                    Quotes = new List<Quote>
                    {
                        new Quote
                        {
                            Id = 1, SamuraiId = 1, Text = "Summer grasses, All that remains of soldiers' dreams"
                        },
                        new Quote
                        {
                            Id = 2, SamuraiId = 1,
                            Text =
                                "New eras don't come about because of swords, they're created by the people who wield them"
                        },
                    },
                    Battles = new List<Battle>
                    {
                        new Battle { Id = 1, Name = "Ichi-no-Tani", Year = 1184 },
                        new Battle { Id = 2, Name = "Dan-no-Ura", Year = 1185 },
                    }
                },
                new Samurai { Id = 2, Name = "Baba Nobufusa", Dynasty = "Kamakura" },
                new Samurai
                {
                    Id = 3, Name = "Chosokabe Nobuchika", Dynasty = "Kamakura",
                    Battles = new List<Battle>
                    {
                        new Battle { Id = 1, Name = "Ichi-no-Tani", Year = 1184 },
                    }
                },
                new Samurai { Id = 4, Name = "Date Masamune", Dynasty = "Edo" },
                new Samurai { Id = 5, Name = "Eto Shinpei", Dynasty = "Meiji" },
                new Samurai
                {
                    Id = 6, Name = "Fuma Kotaro", Dynasty = "Meiji",
                    Horses = new List<Horse>
                    {
                        new Horse { Id = 4, Age = 7, IsWarHorse = false, Name = "Lucky", SamuraiId = 6 },
                        new Horse { Id = 5, Age = 5, IsWarHorse = false, Name = "Little Joe", SamuraiId = 6 },
                    }
                },
                new Samurai { Id = 7, Name = "Gamo Ujisato", Dynasty = "Edo" },
                new Samurai { Id = 8, Name = "Harada Nobutane", Dynasty = "Asuka" },
                new Samurai { Id = 9, Name = "Ii Naomasa", Dynasty = "Meiji" },
                new Samurai { Id = 10, Name = "Kido Takayoshi", Dynasty = "Edo" },
                new Samurai
                {
                    Id = 11, Name = "Maeda Toshiie", Dynasty = "Edo",
                    Horses = new List<Horse>
                    {
                        new Horse { Id = 7, Age = 7, IsWarHorse = false, Name = "Misty", SamuraiId = 11 },
                        new Horse { Id = 8, Age = 5, IsWarHorse = false, Name = "Rembrandt", SamuraiId = 11 },
                        new Horse { Id = 9, Age = 13, IsWarHorse = true, Name = "Traveler", SamuraiId = 11 },
                    },
                    Quotes = new List<Quote>
                    {
                        new Quote
                        {
                            Id = 1, SamuraiId = 3, Text = "A man who can't uphold his beliefs is pathetic dead or alive"
                        },
                        new Quote
                        {
                            Id = 2, SamuraiId = 4,
                            Text =
                                "It is the genius of life that demands of those who partake in it that they are not only the guardians of what was and is, but what will be"
                        },
                    },
                    Battles = new List<Battle>
                    {
                        new Battle { Id = 1, Name = "Ichi-no-Tani", Year = 1184 },
                        new Battle { Id = 2, Name = "Dan-no-Ura", Year = 1185 },
                    }
                },
                new Samurai { Id = 12, Name = "Mori Okimoto", Dynasty = "Kamakura" }
            };
        }
    }
}