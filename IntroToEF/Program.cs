using IntroToEF.Data.Repositories;
using System;

namespace IntroToEF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter a samurai");
            string name = Console.ReadLine();

            SamuraiRepo repo = new SamuraiRepo();
        }
    }
}