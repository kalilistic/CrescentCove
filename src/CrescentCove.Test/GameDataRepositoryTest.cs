﻿using System;
using System.IO;
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
			Expression<Func<GameDataMock, bool>> query = gameDataMock => gameDataMock.Id == 690;
			var gameDataMockList = _gameDataMockRepository.Find(query).ToList();
			Assert.IsNotNull(gameDataMockList);
			Assert.AreEqual(690, gameDataMockList[0].Id);
		}

		[Test]
		public void GetAll_ReturnsGameDataList()
		{
			var gameDataMockList = _gameDataMockRepository.GetAll().ToList();
			Assert.IsNotNull(gameDataMockList);
			Assert.AreEqual(690, gameDataMockList[0].Id);
			Assert.AreEqual(856, gameDataMockList[0].TerritoryType);
			Assert.IsTrue(gameDataMockList[0].HighEndDuty);
			Assert.AreEqual("Eden's Gate: Sepulture (Savage)", gameDataMockList[0].Localized[0].Name);
			Assert.AreEqual("L'Éveil d'Éden - Inhumation (sadique)", gameDataMockList[0].Localized[1].Name);
			Assert.AreEqual("Edens Erwachen - Beerdigung (episch)", gameDataMockList[0].Localized[2].Name);
			Assert.AreEqual("希望の園エデン零式：覚醒編4", gameDataMockList[0].Localized[3].Name);
			using (var writer = new StreamWriter("C:\\Users\\caleb\\Desktop\\logger.txt", false))
			{
				//byte[] bytes = Encoding.GetEncoding(1252).GetBytes(result);
				// var nameFixed = Encoding.UTF8.GetString(bytes);
				writer.WriteLine(gameDataMockList[0].Localized[1].Name);
			}
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
			var gameDataMock = _gameDataMockRepository.GetById(690);
			Assert.AreEqual(typeof(GameDataMock), gameDataMock.GetType());
		}
	}
}