using IntroToEF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IntroToEF.Data.Repositories
{
    public class SolutionsRepo: ISamuraiRepo
    {
        private readonly SamuraiContext _context;

        public SolutionsRepo()
        {
            // Open connection to database
            _context = new SamuraiContext();
        }

        public void DeleteSamurai(int id)
        {
            Samurai samurai = GetSamurai(id);
            _context.Samurais.Remove(samurai);
            _context.SaveChanges();
        }

        public List<Samurai> GetAllSamurai()
        {
            return _context.Samurais.ToList();
        }

        public Samurai GetSamurai(int id)
        {
            return _context.Samurais.Find(id);
        }

        public Samurai GetSamuraiWithAllRelatedData(int id)
        {
            return _context.Samurais
                    .Include(x => x.Horses)
                    .Include(x => x.Battles)
                    .Include(x => x.Quotes)
                .SingleOrDefault(x => x.Id == id);
        }

        public Samurai GetSamuraiByName(string name)
        {
            return _context.Samurais.FirstOrDefault(x => x.Name == name);
        }

        public List<Samurai> GetSamuraiWhereNameContains(string text)
        {
            throw new NotImplementedException();
        }

        public void UpdateSamurai(Samurai samurai)
        {
            throw new NotImplementedException();
        }

        public void AddSamurai(Samurai samurai)
        {
            _context.Add(samurai);
            _context.SaveChanges();
        }

        public void AddSamurais(List<Samurai> samurais)
        {
            _context.AddRange(samurais);
            _context.SaveChanges();
        }

        public List<Samurai> GetResultFromStoredProcedure(string text)
        {
            var samurais = _context.Samurais.FromSqlRaw(
                    "EXEC [dbo].[SamuraisWhoSaidAWord] {0}", text)
                .ToList();

            return samurais;
        }

        public List<Samurai> GetSamuraisByName(string name)
        {
            var samurai =
                _context.Samurais
                    .Include(x => x.Quotes)
                    .Where(x => x.Name == name)
                    .ToList();

            return samurai;
        }

        public void UpdateSamurais()
        {
            // Get samurais -> Skip the first four rows, then take three
            List<Samurai> samurais = _context.Samurais
                .Skip(1)
                .Take(6)
                .ToList();

            int i = 0;
            foreach (var samurai in samurais)
            {
                i++;
                samurai.Name = "I was changed in DB " + i;
                samurai.Dynasty = "Sengoku";
            }

            _context.SaveChanges();
        }

        public List<Samurai> FindSamuraisThatSaidAWord(string word)
        {
            // Using a find(id) does the exact same thing as below
            var samurais = _context.Samurais
                .Include(x => x.Horses)
                .Include(x => x.Quotes.Where(y => y.Text.Contains(word)))
                .ToList();

            return samurais;
        }
    }
}