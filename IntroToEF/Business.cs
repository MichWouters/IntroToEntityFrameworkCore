﻿using IntroToEF.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF
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
