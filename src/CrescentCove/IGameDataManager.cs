namespace CrescentCove
{
    public interface IGameDataManager
    {
        string ClassJob { get; }
        string Item { get; }
        string World { get; }
        string ContentFinderCondition { get; }
    }
}