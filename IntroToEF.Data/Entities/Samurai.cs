using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntroToEF.Data.Entities
{
    public class Samurai
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Dynasty { get; set; }

        // One to one relationship -> A samurai can have 0 or 1 spouses
        public int SpouseId { get; set; }

        public Spouse Spouse { get; set; }

        // One to many relationship -> A samurai can have 0,1 or more quotes
        public List<Quote> Quotes { get; set; }

        public List<Horse> Horses { get; set; }

        public List<Battle> Battles { get; set; }
    }
}