namespace CrescentCove.Model
{
    public class ContentFinderCondition : IGameData, IContentFinderCondition
    {
        public string TerritoryType { get; set; }
        public bool HighEndDuty { get; set; }
        public int Id { get; set; }

        public void SetPropsByStr(string[] propertyStr)
        {
            Id = int.Parse(propertyStr[0]);
            TerritoryType = propertyStr[1];
            HighEndDuty = bool.Parse(propertyStr[2]);
        }
    }
}