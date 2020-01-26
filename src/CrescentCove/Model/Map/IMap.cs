namespace FFXIV.CrescentCove
{
	public interface IMap
	{
		int Id { get; set; }
		int MapPlaceNameId { get; set; }
		int TerritoryTypeId { get; set; }
		void SetPropsByStr(string[] propertyStr);
	}
}