using IntroToEF.Data.Entities;
using System.Collections.Generic;
using System;

namespace IntroToEF.Data.Repositories
{
    public class SamuraiRepo : ISamuraiRepo
    {
        public void AddSamurai(string name)
        {
            // Create an object to be INSERTED

            List<Samurai> myList = new List<Samurai>
            {
                new Samurai
                {
                    Name = "ListSam1"
                },
                 new Samurai
                {
                    Name = "ListSam2"
                },
                new Samurai
                {
                    Name = "ListSam3"
                },
            };

            // Open connection to database
            var context = new SamuraiContext();

            // Add object(s) to be tracked by context
            // Specify target table and data to be added

            context.Samurais.AddRange(myList);

            // Push changes to DB
            context.SaveChanges();
        }

        public void AddSamurais(List<Samurai> samurais)
        {
            throw new NotImplementedException();
        }

        public Samurai GetSamurai(int id)
        {
            throw new NotImplementedException();
        }

        public List<Samurai> GetSamurais()
        {
            throw new NotImplementedException();
        }

        public void UpdateSamurai(int id, Samurai samurai)
        {
            throw new NotImplementedException();
        }

        public void DeleteSamurai(int id)
        {
            throw new NotImplementedException();
        }

        public void AddDifferentObjectsToContext()
        {
            var context = new SamuraiContext();

            Quote quote = new Quote
            {
                SamuraiId = 1,
                Text = "If the Bird does not sing, Kill it."
            };

            Horse horse = new Horse
            {
                SamuraiId = 1,
                Age = 5,
                IsWarHorse = true,
                Name = "Jolly jumper"
            };

            context.Add(quote);
            context.Add(horse);
            context.SaveChanges();
        }
    }
}