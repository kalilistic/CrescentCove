namespace FFXIV.CrescentCove
{
    public class PlaceName : IGameData, IPlaceName
    {
        public int Id { get; set; }

        public void SetPropsByStr(string[] propertyStr)
        {
            Id = int.Parse(propertyStr[0]);
            Name = propertyStr[1];
        }

        public string Name { get; set; }
    }
}