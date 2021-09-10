using IntroToEF.Business;
using IntroToEF.Data.Repositories;
using Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using IntroToEF.Data.Entities;

namespace IntroToEf.Tests
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Tests
    {
        private ISamuraiRepo _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new SolutionsRepo();
        }

        [Test]
        public void AllSamuraiRetrievesAllSamurais()
        {
            var result = _repo.GetAllSamurai();

            Assert.AreEqual(12, result.Count);
        }

        [Test]
        public void GetSamuraiRetrievesSingleSamurai()
        {
            var result = _repo.GetSamurai(1);

            Assert.AreEqual(typeof(Samurai), result.GetType());
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Abe Masakatsu", result.Name);
            Assert.AreEqual("Asuka", result.Dynasty);
        }

        [Test]
        public void GetSamuraiWithAllRelatedDataRetrievesSingleSamuraiWithAllRelatedData()
        {
            var result = _repo.GetSamurai(1);

            Assert.AreEqual(typeof(Samurai), result.GetType());
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Abe Masakatsu", result.Name);
            Assert.AreEqual("Asuka", result.Dynasty);

            Assert.IsNotNull(result.Battles);
            Assert.IsNotNull(result.Horses);
            Assert.IsNotNull(result.Quotes);
        }
    }
}