﻿namespace FFXIV.CrescentCove
{
	public class PlaceName : IGameData, IPlaceName
	{
		public int Id { get; set; }

		public void SetPropsByStr(string[] propertyStr)
		{
			Id = int.Parse(propertyStr[0]);
			Localized = new IPlaceNameLocalized[]
			{
				new PlaceNameLocalized
				{
					Language = LanguageEnum.en,
					Name = propertyStr[1]
				},
				new PlaceNameLocalized
				{
					Language = LanguageEnum.fr,
					Name = propertyStr[2]
				},
				new PlaceNameLocalized
				{
					Language = LanguageEnum.de,
					Name = propertyStr[3]
				},
				new PlaceNameLocalized
				{
					Language = LanguageEnum.ja,
					Name = propertyStr[4]
				}
			};
		}

		public IPlaceNameLocalized[] Localized { get; set; }

		public string Name { get; set; }
	}
}