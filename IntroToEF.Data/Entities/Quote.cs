namespace IntroToEF.Data.Entities
{
    public class Quote
    {
        public int Id { get; set; }

        public string Text { get; set; }

        // One to many -> A quote can have only one samurai
        public Samurai Samurai { get; set; }

        public int SamuraiId { get; set; }
    }
}