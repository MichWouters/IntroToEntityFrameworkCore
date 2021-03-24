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
            // Find a single object in a table by id
            var samurai = context.Samurais.Find(id);

            return samurai;
        }

        public Samurai GetSamuraiByName(string name)
        {
            // Find a single object in a table by id
            var samurai =
                context.Samurais
                .FirstOrDefault(x => x.Name == name);

            return samurai;
        }

        public List<Samurai> GetSamuraisByName(string name)
        {
            // Find a single object in a table by id
            var samurai =
                context.Samurais
                .Include(x => x.Quotes)
                .Where(x => x.Name == name)
                .ToList();

            return samurai;
        }

        public List<Samurai> GetSamuraiWhereNameContains(string text)
        {
            var samurai = context.Samurais
                .Where(x => x.Name.Contains(text))
                .OrderByDescending(x => x.Name)
                .ToList();

            return samurai;
        }

        public Samurai GetSamuraiWithIncludedData(int id)
        {
            // Using a find(id) does the exact same thing as below
            var samurai = context.Samurais
                .Include(x => x.Horses)
                .Include(x => x.Quotes.Where (y => y.Text.Contains("thank")))
                .FirstOrDefault(x => x.Id == id);

            return samurai;
        }

        public List<Samurai> GetSamurais()
        {
            // Include data in related tables
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

        Samurai ISamuraiRepo.GetSamuraiWhereNameContains(string text)
        {
            throw new NotImplementedException();
        }
    }
}