namespace FFXIV.CrescentCove
{
	public class PlaceNameLocalized : ILocalizedData, IPlaceNameLocalized
	{
		public LanguageEnum Language { get; set; }
		public string Name { get; set; }
	}
}