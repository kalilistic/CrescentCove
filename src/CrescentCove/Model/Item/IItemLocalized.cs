namespace FFXIV.CrescentCove
{
	public interface IItemLocalized
	{
		string ProperName { get; set; }
		string SingularName { get; set; }
		string PluralName { get; set; }
		string SingularNameKeyword { get; set; }
		string PluralNameKeyword { get; set; }
		string SingularNameREP { get; set; }
		string PluralNameREP { get; set; }
	}
}