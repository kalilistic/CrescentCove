namespace CrescentCove.Model
{
    public interface IClassJob
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abbreviation { get; set; }
        int Category { get; set; }
        string Role { get; set; }
        void SetPropsByStr(string[] propertyStr);
    }
}