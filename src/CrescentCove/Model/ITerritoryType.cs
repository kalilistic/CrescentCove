namespace FFXIV.CrescentCove
{
    public interface ITerritoryType
    {
        int Id { get; set; }
        int RegionPlaceNameId { get; set; }
        int ZonePlaceNameId { get; set; }
        int TerritoryPlaceNameId { get; set; }
        int MapId { get; set; }
        void SetPropsByStr(string[] propertyStr);
    }
}