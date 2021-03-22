using System.Collections.Generic;

namespace IntroToEF.Data.Entities
{
    public class Samurai
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // One to many relationship -> A samurai can have 0,1 or more quotes
        public List<Quote> Quotes { get; set; }
    }
}