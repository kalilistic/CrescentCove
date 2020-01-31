namespace FFXIV.CrescentCove
{
	public class ItemLocalized : ILocalizedData
	{
		public string ProperName { get; set; }
		public string SingularName { get; set; }
		public string PluralName { get; set; }
		public string SingularNameKeyword { get; set; }
		public string PluralNameKeyword { get; set; }
		public string SingularNameREP { get; set; }
		public string PluralNameREP { get; set; }
		public LanguageEnum Language { get; set; }
	}
}