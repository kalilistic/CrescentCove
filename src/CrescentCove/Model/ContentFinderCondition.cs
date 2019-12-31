namespace FFXIV.CrescentCove
{
    public class ContentFinderCondition : IGameData, IContentFinderCondition
    {
        public string Name { get; set; }
        public int TerritoryType { get; set; }
        public bool HighEndDuty { get; set; }
        public int Id { get; set; }

        public void SetPropsByStr(string[] propertyStr)
        {
            Id = int.Parse(propertyStr[0]);
            TerritoryType = int.Parse(propertyStr[1]);
            Name = propertyStr[2];
            HighEndDuty = bool.Parse(propertyStr[3]);
        }
    }
}