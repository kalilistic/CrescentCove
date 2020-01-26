namespace FFXIV.CrescentCove
{
	public interface IPlaceName
	{
		int Id { get; set; }
		string Name { get; set; }
		IPlaceNameLocalized[] Localized { get; set; }
		void SetPropsByStr(string[] propertyStr);
	}
}