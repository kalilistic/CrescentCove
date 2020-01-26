﻿namespace FFXIV.CrescentCove
{
	public class ContentFinderCondition : IGameData, IContentFinderCondition
	{
		public string Name { get; set; }
		public int TerritoryType { get; set; }
		public bool HighEndDuty { get; set; }
		public IContentFinderConditionLocalized[] Localized { get; set; }
		public int Id { get; set; }

		public void SetPropsByStr(string[] propertyStr)
		{
			Id = int.Parse(propertyStr[0]);
			TerritoryType = int.Parse(propertyStr[1]);
			HighEndDuty = bool.Parse(propertyStr[2]);
			Localized = new IContentFinderConditionLocalized[]
			{
				new ContentFinderConditionLocalized
				{
					Language = LanguageEnum.en,
					Name = propertyStr[3]
				},
				new ContentFinderConditionLocalized
				{
					Language = LanguageEnum.fr,
					Name = propertyStr[4]
				},
				new ContentFinderConditionLocalized
				{
					Language = LanguageEnum.de,
					Name = propertyStr[5]
				},
				new ContentFinderConditionLocalized
				{
					Language = LanguageEnum.ja,
					Name = propertyStr[6]
				}
			};
		}
	}
}