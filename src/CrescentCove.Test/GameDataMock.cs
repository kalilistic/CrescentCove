using CrescentCove.Model;

namespace CrescentCove.Test
{
    public class GameDataMock : IGameData
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public void SetPropsByStr(string[] propertyStr)
        {
            Id = int.Parse(propertyStr[0]);
            Name = propertyStr[1];
        }
    }
}