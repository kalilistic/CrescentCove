namespace FFXIV.CrescentCove
{
	public interface IContentFinderCondition
	{
		int Id { get; set; }
		int TerritoryType { get; set; }
		bool HighEndDuty { get; set; }
		IContentFinderConditionLocalized[] Localized { get; set; }

		void SetPropsByStr(string[] propertyStr);
	}
}