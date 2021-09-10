using IntroToEF.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using IntroToEF.Data.Entities;

namespace IntroToEF.Business
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class GetExercises

    {
        private readonly ISamuraiRepo _repo;

        public GetExercises(ISamuraiRepo repo)
        {
            // Open connection to database
            _repo = repo;
        }

        /// <summary>
        /// Haal alle samurai op
        /// </summary>
        public List<Samurai> GetAllSamurai()
        {
            return _repo.GetAllSamurai();
        }

        /// <summary>
        /// Haal de laatste samurai op in een alfabetisch gesorteerde lijst
        /// </summary>
        public List<Samurai> GetLastSamuraiByName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///  Zoek een enkele samurai op basis van de naam
        /// </summary>
        public Samurai GetSingleSamuraiByName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal alle samurai op, samen met de informatie over hun paarden als ze die hebben
        /// </summary>
        public List<Samurai> GetAllSamuraiWithHorses()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal een enkele samurai op, gebaseerd op ID, met al zijn gerelateerde data.
        /// </summary>
        public Samurai GetSamuraiWithAllRelatedData(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal alle samurai op die aan minstens 1 gevecht deelgenomen hebben
        /// </summary>
        public void GetAllSamuraiWhoFoughtInABattle()
        {
            throw new NotImplementedException();
        }
    }
}