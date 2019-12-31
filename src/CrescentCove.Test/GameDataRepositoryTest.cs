using System;
using System.Linq;
using System.Linq.Expressions;
using CrescentCove.Test.Properties;
using NUnit.Framework;

namespace FFXIV.CrescentCove.Test
{
    [TestFixture]
    public class GameDataRepositoryTest
    {
        [SetUp]
        public void TestInitialize()
        {
            _gameDataMockRepository = new GameDataRepository<GameDataMock>(Resources.GameDataMock);
        }

        private GameDataRepository<GameDataMock> _gameDataMockRepository;

        [Test]
        public void Find_ReturnsGameDataList()
        {
            Expression<Func<GameDataMock, bool>> query = gameDataMock => gameDataMock.Id == 1;
            var gameDataMockList = _gameDataMockRepository.Find(query).ToList();
            Assert.IsNotNull(gameDataMockList);
            Assert.AreEqual(01, gameDataMockList[0].Id);
        }

        [Test]
        public void GetAll_ReturnsGameDataList()
        {
            var gameDataMockList = _gameDataMockRepository.GetAll().ToList();
            Assert.IsNotNull(gameDataMockList);
            Assert.AreEqual(gameDataMockList[0].Id, 1);
        }

        [Test]
        public void GetById_BadID_ReturnsGameData()
        {
            var gameDataMock = _gameDataMockRepository.GetById(-1);
            Assert.IsNull(gameDataMock);
        }

        [Test]
        public void GetById_MissingID_ReturnsGameData()
        {
            var gameDataMock = _gameDataMockRepository.GetById(5);
            Assert.IsNull(gameDataMock);
        }

        [Test]
        public void GetById_ReturnsGameData()
        {
            var gameDataMock = _gameDataMockRepository.GetById(3);
            Assert.AreEqual(typeof(GameDataMock), gameDataMock.GetType());
        }
    }
}