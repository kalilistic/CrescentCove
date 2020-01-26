namespace FFXIV.CrescentCove
{
	public interface IItem
	{
		int Id { get; set; }
		bool IsCommon { get; set; }
		bool IsRetired { get; set; }
		IItemLocalized[] Localized { get; set; }
		void SetPropsByStr(string[] propertyStr);
	}
}