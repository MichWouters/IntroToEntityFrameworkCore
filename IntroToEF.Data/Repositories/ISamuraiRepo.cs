using IntroToEF.Data.Entities;
using System.Collections.Generic;

namespace IntroToEF.Data.Repositories
{
    public interface ISamuraiRepo
    {
        void AddSamurai(Samurai samurai);

        void AddSamurais(List<Samurai> samurais);

        void DeleteSamurai(int id);

        IList<Samurai> FindSamuraisThatSaidAWord(string word);

        IList<Samurai> GetAllSamurai();

        IList<Samurai> GetResultFromStoredProcedure(string text);

        Samurai GetSamurai(int id);

        Samurai GetSamuraiByName(string name);

        IList<Samurai> GetSamuraisByName(string name);

        IList<Samurai> GetSamuraiWhereNameContains(string text);

        Samurai GetSamuraiWithAllRelatedData(int id);

        Samurai GetSamuraiWithHorses(int id);

        Samurai GetSamuraiWithoutHorses(int id);

        List<Samurai> SkipSamuraiThenTakeDescending(int amountToSkip, int amountToTake);

        void UpdateSamurai(Samurai samurai);

        void UpdateSamurais();
    }
}