namespace FFXIV.CrescentCove
{
	public class ItemLocalized : ILocalizedData
	{
		public LanguageEnum Language { get; set; }
		public string ProperName { get; set; }
		public string SingularName { get; set; }
		public string PluralName { get; set; }
		public string SingularSearchTerm { get; set; }
		public string PluralSearchTerm { get; set; }
		public string SingularREP { get; set; }
		public string PluralREP { get; set; }
	}
}