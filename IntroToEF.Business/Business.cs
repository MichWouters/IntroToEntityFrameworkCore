using IntroToEF.Data.Repositories;

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

            _repo.AddDifferentObjectsToContext();
        }
    }
}