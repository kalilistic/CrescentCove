namespace FFXIV.CrescentCove
{
    public interface IWorld
    {
        int Id { get; set; }
        string Name { get; set; }
        void SetPropsByStr(string[] propertyStr);
    }
}