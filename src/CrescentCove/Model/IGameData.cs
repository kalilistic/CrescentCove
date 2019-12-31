namespace FFXIV.CrescentCove
{
    public interface IGameData
    {
        int Id { get; set; }
        void SetPropsByStr(string[] propertyStr);
    }
}