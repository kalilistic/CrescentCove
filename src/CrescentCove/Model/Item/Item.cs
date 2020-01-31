namespace FFXIV.CrescentCove
{
	public class Item : IGameData
	{
		public int Id { get; set; }

		public void SetPropsByStr(string[] propertyStr)
		{
			Id = int.Parse(propertyStr[0]);
			Localized = new ItemLocalized[]
			{
				new ItemLocalized
				{
					Language = LanguageEnum.en,
					SingularName = propertyStr[1],
					PluralName = propertyStr[2],
					ProperName = propertyStr[3],
					SingularNameKeyword = propertyStr[4],
					PluralNameKeyword = propertyStr[5],
					SingularNameREP = propertyStr[6],
					PluralNameREP = propertyStr[7]
				},
				new ItemLocalized
				{
					Language = LanguageEnum.fr,
					SingularName = propertyStr[8],
					PluralName = propertyStr[9],
					ProperName = propertyStr[10],
					SingularNameKeyword = propertyStr[11],
					PluralNameKeyword = propertyStr[12],
					SingularNameREP = propertyStr[13],
					PluralNameREP = propertyStr[14]
				},
				new ItemLocalized
				{
					Language = LanguageEnum.de,
					SingularName = propertyStr[15],
					PluralName = propertyStr[16],
					ProperName = propertyStr[17],
					SingularNameKeyword = propertyStr[18],
					PluralNameKeyword = propertyStr[19],
					SingularNameREP = propertyStr[20],
					PluralNameREP = propertyStr[21]
				},
				new ItemLocalized
				{
					Language = LanguageEnum.ja,
					SingularName = propertyStr[22],
					PluralName = propertyStr[23],
					ProperName = propertyStr[24],
					SingularNameKeyword = propertyStr[25],
					PluralNameKeyword = propertyStr[26],
					SingularNameREP = propertyStr[27],
					PluralNameREP = propertyStr[28]
				}
			};

			IsCommon = bool.Parse(propertyStr[29]);
			IsRetired = bool.Parse(propertyStr[30]);
		}

		public ItemLocalized[] Localized { get; set; }
		public bool IsCommon { get; set; }
		public bool IsRetired { get; set; }
	}
}