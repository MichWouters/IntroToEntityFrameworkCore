using System.Collections.Generic;
using IntroToEF.Data.Entities;
using IntroToEF.Data.Repositories;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace IntroToEf.Tests
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class GetExercisesTests
    {
        private ISamuraiRepo _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new SolutionsRepo();
        }

        [Test]
        public void GetAllSamurai_RetrievesAllSamurais()
        {
            var result = _repo.GetAllSamurai();

            Assert.AreEqual(12, result.Count);
        }

        [Test]
        public void GetSamurai_RetrievesSingleSamurai()
        {
            var result = _repo.GetSamuraiWithHorses(1);

            Assert.AreEqual(typeof(Samurai), result.GetType());
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Abe Masakatsu", result.Name);
            Assert.AreEqual("Asuka", result.Dynasty);
        }

        [Test]
        public void GetSamurai_WhenNoResultIsFound_ReturnsNull()
        {
            var result = _repo.GetSamurai(-1);

            Assert.IsNull(result);
        }

        [Test]
        public void GetSamuraiWithAllRelatedData_RetrievesSingleSamuraiWithAllRelatedData()
        {
            var result = _repo.GetSamuraiWithAllRelatedData(1);

            Assert.AreEqual(typeof(Samurai), result.GetType());
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Abe Masakatsu", result.Name);
            Assert.AreEqual("Asuka", result.Dynasty);

            Assert.IsNotNull(result.Battles);
            Assert.IsNotNull(result.Horses);
            Assert.IsNotNull(result.Quotes);

            Assert.AreEqual(3, result.Quotes.Count);
            Assert.AreEqual(3, result.Horses.Count);
        }

        [Test]
        public void SkipTakeSamurai_SortsByNameDescending_SkipsXAmountOfSamurai_ThenTakesYAmountOfSamurai()
        {
            // Arrange
            int amountToSkip = 3;
            int amountToTake = 5;
            
            // Act 
            List<Samurai> result = _repo.SkipSamuraiThenTakeDescending(amountToSkip, amountToTake);

            // Assert
            Assert.AreEqual(amountToTake, result.Count);
            Assert.AreEqual("Ii Naomasa", result[0].Name);
            Assert.AreEqual("Eto Shinpei", result[^1].Name);
        }

        [Test]
        public void SkipTakeSamurai_WhenNoResult_ReturnsEmptyList()
        {
            // Arrange
            int amountToSkip = 13;
            int amountToTake = 5;

            // Act 
            List<Samurai> result = _repo.SkipSamuraiThenTakeDescending(amountToSkip, amountToTake);

            // Assert
            Assert.IsEmpty(result);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void FindSamuraisThatSaidAWord_ReturnsAllSamuraisWithQuotesThatContainAWord()
        {
            // Arrange
            string word = "death";

            // Act
            List<Samurai> result = _repo.FindSamuraisThatSaidAWord(word);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(1, result[0].Quotes.Count);
            Assert.AreEqual(2, result[1].Quotes.Count);
        }

        [Test]
        public void FindSamuraisThatSaidAWord_IsCaseInsensitive()
        {
            // Arrange
            string uppercase = "DEATH";
            string lowercase = "death";

            // Act
            List<Samurai> result = _repo.FindSamuraisThatSaidAWord(uppercase);
            List<Samurai> result2 = _repo.FindSamuraisThatSaidAWord(lowercase);

            // Assert
            Assert.AreEqual(result2.Count, result.Count);
            Assert.AreEqual(1, result[0].Quotes.Count);
            Assert.AreEqual(2, result[1].Quotes.Count);
        }
    }
}