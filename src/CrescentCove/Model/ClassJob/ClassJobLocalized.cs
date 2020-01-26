namespace FFXIV.CrescentCove
{
	public class ClassJobLocalized : ILocalizedData, IClassJobLocalized
	{
		public string Name { get; set; }
		public string Abbreviation { get; set; }
		public LanguageEnum Language { get; set; }
	}
}