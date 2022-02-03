using IntroToEF.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroToEF.Data.Repositories
{
    public class SamuraiRepo : ISamuraiRepo
    {
        private readonly SamuraiContext _context;

        public SamuraiRepo()
        {
            // Open connection to database
            _context = new SamuraiContext();
        }

        /// <summary>
        /// Voeg een enkele samurai toe aan de database.
        /// </summary>
        /// <param name="samurai"></param>
        public void AddSamurai(Samurai samurai)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Voeg meerdere samurais toe in 1 dezelfde transactie
        /// </summary>
        public void AddSamurais(List<Samurai> samurais)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verwijder een enkel samurai object op basis van een ID
        /// </summary>
        /// <param name="id"></param>
        public void DeleteSamurai(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal alle samurai op in de database, zonder gerelateerde data
        /// </summary>
        /// <returns></returns>
        public IList<Samurai> GetAllSamurai()
        {
            // TODO
            throw new NotImplementedException();
        }

        public IList<Samurai> GetResultFromStoredProcedure(string text)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal een enkele samurai op, zonder gerelateerde data op basis van zijn ID.
        /// Geef NULL terug wanneer geen element gevonden werd.
        /// Gooi een Exception als meer dan 1 element gevonden werd
        /// </summary>
        /// <param name="id">De ID van de gezochte samurai</param>
        /// <returns></returns>
        public Samurai GetSamurai(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal een enkele samurai op, met al zijn gerelateerde data.
        /// Geef NULL terug wanneer geen element gevonden werd
        /// Gooi een Exception als meer dan 1 element gevonden werd
        /// </summary>
        /// <param name="id">De Id van de gezochte samurai</param>
        /// <returns>Een samurai met alle gerelateerde data</returns>

        public Samurai GetSamuraiWithAllRelatedData(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal 1 samurai op waarvan hun naam exact hetzelfde is als een meegegeven naam.
        /// Geef NULL terug wanneer geen element gevonden werd.
        /// Gooi een Exception als er meer dan 1 samurai gevonden werd.
        /// </summary>
        /// <param name="name">De naam van de samurai(s)</param>
        /// <returns></returns>
        public Samurai GetSamuraiByName(string name)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal 1 of meerdere samurai op waarvan hun naam exact hetzelfde is als een meegegeven naam.
        /// Geef NULL terug wanneer geen element gevonden werd.
        /// </summary>
        /// <param name="name">De naam van de samurai(s)</param>
        /// <returns></returns>
        public IList<Samurai> GetSamuraisByName(string name)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Haal 1 of meerdere samurai op waarvan hun naam een stukje tekst bevat.
        /// Geef NULL terug wanneer geen element gevonden werd.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public IList<Samurai> GetSamuraiWhereNameContains(string text)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update een bestaand samurai record
        /// </summary>
        /// <param name="samurai"></param>
        public void UpdateSamurai(Samurai samurai)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update meerdere samurais in 1 dezelfde transactie
        /// </summary>
        public void UpdateSamurais()
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sorteer een lijst van samurai op naam, van Z naar A. Sla dan X aantal samurai over en haal Y aantal op
        /// </summary>
        /// <param name="amountToSkip">Het aantal samurai dat overgeslagen moet worden in de search query</param>
        /// <param name="amountToTake">Het maximaal aantal samurai dat opgehaald moet worden</param>
        /// <returns></returns>
        public List<Samurai> SkipSamuraiThenTakeDescending(int amountToSkip, int amountToTake)
        {
            // TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// Een samurai kan 0, 1 of meerdere quotes gezegd hebben.
        /// Returneer alle samurais met hun quotes die een zoekterm bevatten, geen rekening houdend met hoofd-of kleine letters.
        /// </summary>
        /// <param name="word">Een woord dat een samurai gezegd heeft</param>
        /// <returns>Een lijst van samurai met de quotes die een woord bevatten</returns>
        public IList<Samurai> FindSamuraisThatSaidAWord(string word)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Samurai GetSamuraisWithMoreThan2Horses()
        {
            throw new NotImplementedException();
        }

        public Samurai GetSamuraiWithoutHorses(int id)
        {
            throw new NotImplementedException();
        }
    }
}