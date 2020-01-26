namespace FFXIV.CrescentCove
{
	public class Language : IGameData, ILanguage
	{
		public int Id { get; set; }

		public void SetPropsByStr(string[] propertyStr)
		{
			Id = int.Parse(propertyStr[0]);
			Name = propertyStr[1];
			Abbreviation = propertyStr[2];
		}

		public string Name { get; set; }
		public string Abbreviation { get; set; }
	}
}