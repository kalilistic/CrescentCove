namespace FFXIV.CrescentCove
{
	public interface IClassJob
	{
		int Id { get; set; }
		int Category { get; set; }
		string Role { get; set; }
		IClassJobLocalized[] Localized { get; set; }
		void SetPropsByStr(string[] propertyStr);
	}
}