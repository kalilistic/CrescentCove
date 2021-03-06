using NUnit.Framework;

namespace FFXIV.CrescentCove.Test
{
	[TestFixture]
	public class GameDataManagerTest
	{
		[Test]
		public void GameDataManager_GetGameData()
		{
			var gameDataManager = new GameDataManager();
			Assert.IsNotNull(gameDataManager.ClassJob);
			Assert.IsNotNull(gameDataManager.Item);
			Assert.IsNotNull(gameDataManager.World);
			Assert.IsNotNull(gameDataManager.ContentFinderCondition);
			Assert.IsNotNull(gameDataManager.Language);
			Assert.IsNotNull(gameDataManager.Map);
			Assert.IsNotNull(gameDataManager.PlaceName);
			Assert.IsNotNull(gameDataManager.TerritoryType);
		}
	}
}