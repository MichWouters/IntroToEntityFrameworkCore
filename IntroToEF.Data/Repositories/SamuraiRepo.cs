using IntroToEF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroToEF.Data.Repositories
{
    public class SamuraiRepo : ISamuraiRepo
    {
        private readonly SamuraiContext _context;

        public SamuraiRepo()
        {
            // Open connection to database
            _context = new SamuraiContext();
        }

        public void AddSamurai(Samurai samurai)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void AddSamurais(List<Samurai> samurais)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void DeleteSamurai(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Samurai> GetAllSamurai()
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Samurai> GetResultFromStoredProcedure(string text)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Samurai GetSamurai(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Samurai GetSamuraiWithAllRelatedData(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Samurai GetSamuraiByName(string name)
        {
            // Find a single object in a table by id
            var samurai =
                _context.Samurais
                .FirstOrDefault(x => x.Name == name);

            return samurai;
        }

        public List<Samurai> GetSamurais()
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Samurai> GetSamuraisByName(string name)
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Samurai> GetSamuraiWhereNameContains(string text)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Samurai GetSamuraiWithIncludedData(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void UpdateSamurai(Samurai samurai)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void UpdateSamurais()
        {
            // TODO
            throw new NotImplementedException();
        }

        public List<Samurai> FindSamuraisThatSaidAWord(string word)
        {
            // TODO:
            throw new NotImplementedException();
        }
    }
}