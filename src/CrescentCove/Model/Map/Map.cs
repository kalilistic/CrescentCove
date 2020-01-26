namespace FFXIV.CrescentCove
{
	public class Map : IGameData, IMap
	{
		public int Id { get; set; }

		public void SetPropsByStr(string[] propertyStr)
		{
			Id = int.Parse(propertyStr[0]);
			MapPlaceNameId = int.Parse(propertyStr[1]);
			TerritoryTypeId = int.Parse(propertyStr[2]);
		}

		public int MapPlaceNameId { get; set; }
		public int TerritoryTypeId { get; set; }
	}
}