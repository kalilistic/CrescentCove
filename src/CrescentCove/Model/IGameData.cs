namespace CrescentCove.Model
{
    public interface IGameData
    {
        int Id { get; set; }
        void SetPropsByStr(string[] propertyStr);
    }
}