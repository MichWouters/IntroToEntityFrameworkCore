using IntroToEF.Data.Entities;

namespace IntroToEF.Data.Repositories
{
    public class SamuraiRepo: ISamuraiRepo
    {
        public void AddSamurai(string name)
        {
            // Create an object to be INSERTED
            Samurai samurai = new Samurai
            {
                Name = name
            };

            // Open connection to database
            var context = new SamuraiContext();

            // Add object(s) to be tracked by context
            // Specify target table and data to be added
            context.Samurais.Add(samurai);

            // Push changes to DB
            context.SaveChanges();
        }
    }
}
