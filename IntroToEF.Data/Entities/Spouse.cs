using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF.Data.Entities
{
    public class Spouse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Samurai")]
        public int SamuraiId { get; set; }

        public Samurai Samurai { get; set; }
    }
}
