using IntroToEF.Data.Entities;
using System.Collections.Generic;

namespace IntroToEF.Data.Repositories
{
    public interface ISamuraiRepo
    {
        void AddSamurai(Samurai samurai);

        void AddSamurais(List<Samurai> samurais);

        void DeleteSamurai(int id);

        List<Samurai> FindSamuraisThatSaidAWord(string word);

        List<Samurai> GetAllSamurai();

        List<Samurai> GetResultFromStoredProcedure(string text);

        Samurai GetSamurai(int id);

        Samurai GetSamuraiByName(string name);

        List<Samurai> GetSamuraisByName(string name);

        List<Samurai> GetSamuraiWhereNameContains(string text);

        Samurai GetSamuraiWithAllRelatedData(int id);

        void UpdateSamurai(Samurai samurai);

        void UpdateSamurais();
    }
}