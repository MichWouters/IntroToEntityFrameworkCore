using IntroToEF.Data.Entities;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IntroToEF.Data.Repositories
{
    public class SamuraiRepo : ISamuraiRepo
    {
        private SamuraiContext context;

        public SamuraiRepo()
        {
            // Open connection to database
            context = new SamuraiContext();
        }

        public void AddSamurai(string name)
        {
            // Create a single object to be inserted
            var samurai = new Samurai
            {
                Name = name
            };

            // Add object(s) to be tracked by context
            // Specify target table and data to be added
            context.Samurais.Add(samurai);

            // Push changes to DB
            context.SaveChanges();
        }

        public void AddSamurai(Samurai samurai)
        {
            context.Samurais.Add(samurai);
            context.SaveChanges();
        }

        public void AddSamurais(List<Samurai> samurais)
        {
            // Create a list of objects to be INSERTED
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

            // Add object(s) to be tracked by context
            // Specify target table and data to be added
            context.Samurais.AddRange(myList);

            // Push changes to DB
            context.SaveChanges();
        }

        public Samurai GetSamurai(int id)
        {
            throw new NotImplementedException();
        }

        public List<Samurai> GetSamurais()
        {
            return context.Samurais
                .Include(x => x.Quotes)
                .Include(x => x.Horses)
                .ToList();
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
            // Objects can be inserted in multiple tables in one statement
            var quote = new Quote
            {
                SamuraiId = 1,
                Text = "If the Bird does not sing, Kill it."
            };

            var horse = new Horse
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