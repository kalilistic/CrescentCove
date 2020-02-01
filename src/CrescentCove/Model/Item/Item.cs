namespace FFXIV.CrescentCove
{
	public class Item : IGameData
	{
		public ItemLocalized[] Localized { get; set; }
		public bool IsCommon { get; set; }
		public bool IsRetired { get; set; }
		public int Id { get; set; }

		public void SetPropsByStr(string[] propertyStr)
		{
			Id = int.Parse(propertyStr[0]);
			Localized = new[]
			{
				new ItemLocalized
				{
					Language = LanguageEnum.en,
					SingularName = propertyStr[1],
					PluralName = propertyStr[2],
					ProperName = propertyStr[3],
					SingularSearchTerm = propertyStr[4],
					PluralSearchTerm = propertyStr[5],
					SingularREP = propertyStr[6],
					PluralREP = propertyStr[7]
				},
				new ItemLocalized
				{
					Language = LanguageEnum.fr,
					SingularName = propertyStr[8],
					PluralName = propertyStr[9],
					ProperName = propertyStr[10],
					SingularSearchTerm = propertyStr[11],
					PluralSearchTerm = propertyStr[12],
					SingularREP = propertyStr[13],
					PluralREP = propertyStr[14]
				},
				new ItemLocalized
				{
					Language = LanguageEnum.de,
					SingularName = propertyStr[15],
					PluralName = propertyStr[16],
					ProperName = propertyStr[17],
					SingularSearchTerm = propertyStr[18],
					PluralSearchTerm = propertyStr[19],
					SingularREP = propertyStr[20],
					PluralREP = propertyStr[21]
				},
				new ItemLocalized
				{
					Language = LanguageEnum.ja,
					SingularName = propertyStr[22],
					PluralName = propertyStr[23],
					ProperName = propertyStr[24],
					SingularSearchTerm = propertyStr[25],
					PluralSearchTerm = propertyStr[26],
					SingularREP = propertyStr[27],
					PluralREP = propertyStr[28]
				}
			};

			IsCommon = bool.Parse(propertyStr[29]);
			IsRetired = bool.Parse(propertyStr[30]);
		}
	}
}