using CrescentCove.Properties;

namespace CrescentCove
{
    public class GameDataManager : IGameDataManager
    {
        public string ClassJob { get; } = Resources.ClassJob;
        public string Item { get; } = Resources.Item;
        public string World { get; } = Resources.World;
        public string ContentFinderCondition { get; } = Resources.ContentFinderCondition;
    }
}