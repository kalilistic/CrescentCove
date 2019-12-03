namespace CrescentCove.Model
{
    public interface IContentFinderCondition
    {
        int Id { get; set; }
        string TerritoryType { get; set; }
        bool HighEndDuty { get; set; }
        void SetPropsByStr(string[] propertyStr);
    }
}