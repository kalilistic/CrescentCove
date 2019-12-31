namespace FFXIV.CrescentCove
{
    public interface IGameDataManager
    {
        string ClassJob { get; }
        string Item { get; }
        string World { get; }
        string ContentFinderCondition { get; }
        string TerritoryType { get; }
        string PlaceName { get; }
        string Map { get; }
    }
}