using IntroToEF.Data.Entities;
using IntroToEF.Data.Repositories;
using System.Collections.Generic;

namespace IntroToEF.Business
{
    public class Business
    {
        // Composition
        private ISamuraiRepo _repo;

        public Business()
        {
            _repo = new SamuraiRepo();
        }

        public void RunApp()
        {
            //    Console.WriteLine("Hello. Please enter a samurai");
            //    string name = Console.ReadLine();

            //    _repo.AddSamurai(name);

            //_repo.AddDifferentObjectsToContext();

            //AddSamuraiWithQuotes();

            GetAllSamurais();
        }

        public void AddSamuraiWithQuotes()
        {
            var samurai = new Samurai
            {
                Name = "QuotedSamurai",
                Dynasty = "Sengoku",
                Quotes = new List<Quote>
                {
                    new Quote
                    {
                        Text = "I have saved your life. Now will you feed me?"
                    },
                    new Quote
                    {
                        Text = "Thank you for feeding me"
                    }
                }
            };

            _repo.AddSamurai(samurai);
        }


        public void GetAllSamurais()
        {
            var samurais = _repo.GetSamurais();
        }
    }
}