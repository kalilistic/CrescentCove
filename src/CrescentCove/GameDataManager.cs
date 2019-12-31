using FFXIV.CrescentCove.Properties;

namespace FFXIV.CrescentCove
{
    public class GameDataManager : IGameDataManager
    {
        public string ClassJob { get; } = Resources.ClassJob;
        public string Item { get; } = Resources.Item;
        public string World { get; } = Resources.World;
        public string ContentFinderCondition { get; } = Resources.ContentFinderCondition;
        public string TerritoryType { get; } = Resources.TerritoryType;
        public string PlaceName { get; } = Resources.PlaceName;
        public string Map { get; } = Resources.Map;
    }
}