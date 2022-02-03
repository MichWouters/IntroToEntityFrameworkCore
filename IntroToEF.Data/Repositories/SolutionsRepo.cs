using IntroToEF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IntroToEF.Data.Repositories
{
    public class SolutionsRepo : ISamuraiRepo
    {
        private readonly SamuraiContext _context;

        public SolutionsRepo()
        {
            // Open connection to database
            _context = new SamuraiContext();
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

        public void DeleteSamurai(int id)
        {
            Samurai samurai = GetSamurai(id);
            _context.Samurais.RemoveRange(samurai);
            _context.SaveChanges();
        }

        public IList<Samurai> FindSamuraisThatSaidAWord(string word)
        {
            // Using a find(id) does the exact same thing as below
            var samurais = _context.Samurais
                .Include(x => x.Quotes
                    .Where(quote => quote.Text.ToLower().Contains(word.ToLower()))).ToList()
                .Where(x => x.Quotes.Any()).ToList();


            return samurais;
        }

        public IList<Samurai> GetAllSamurai()
        {
            return _context.Samurais.ToList();
        }

        public IList<Samurai> GetResultFromStoredProcedure(string text)
        {
            var samurais = _context.Samurais.FromSqlRaw(
                    "EXEC [dbo].[SamuraisWhoSaidAWord] {0}", text)
                .ToList();

            return samurais;
        }

        public Samurai GetSamurai(int id)
        {
            return _context.Samurais.Find(id);
        }

        public Samurai GetSamuraiByName(string name)
        {
            return _context.Samurais.FirstOrDefault(x => x.Name == name);
        }

        public IList<Samurai> GetSamuraisByName(string name)
        {
            var samurai =
                _context.Samurais
                    .Include(x => x.Quotes)
                    .Where(x => x.Name == name)
                    .ToList();

            return samurai;
        }

        public IList<Samurai> GetSamuraiWhereNameContains(string text)
        {
            throw new NotImplementedException();
        }

        public Samurai GetSamuraiWithAllRelatedData(int id)
        {
            return _context.Samurais
                    .Include(x => x.Horses)
                    .Include(x => x.Battles)
                    .Include(x => x.Quotes)
                .SingleOrDefault(x => x.Id == id);
        }

        public Samurai GetSamuraiWithHorses(int id)
        {
            return _context.Samurais
                .Include(x => x.Horses)
                .SingleOrDefault(x => x.Id == id);
        }

        public Samurai GetSamuraiWithoutHorses(int id)
        {
            return _context.Samurais.Find(id);
        }
        public List<Samurai> SkipSamuraiThenTakeDescending(int amountToSkip, int amountToTake)
        {
            List<Samurai> samurais = _context.Samurais
                    .OrderByDescending(x => x.Name)
                    .Skip(amountToSkip)
                    .Take(amountToTake)
                    .ToList();

            return samurais;
        }

        public void UpdateSamurai(Samurai samurai)
        {
            _context.Update(samurai);
            _context.SaveChanges();
        }

        public void UpdateSamurais()
        {
            // Get samurais -> Skip the first rows, then take 6
            List<Samurai> samurais = _context.Samurais
                .Skip(1).Take(6).ToList();

            for (var i = 0; i < samurais.Count; i++)
            {
                var samurai = samurais[i];
                samurai.Name = "I was changed in code " + i;
                samurai.Dynasty = "Sengoku";
            }

            _context.SaveChanges();
        }
    }
}