namespace FFXIV.CrescentCove
{
    public class ClassJob : IGameData, IClassJob
    {
        public ClassJob()
        {
        }

        public ClassJob(int id)
        {
            Id = id;
        }

        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Category { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }

        public void SetPropsByStr(string[] propertyStr)
        {
            Id = int.Parse(propertyStr[0]);
            Name = propertyStr[4];
            Abbreviation = propertyStr[2];
            Category = int.Parse(propertyStr[3]);
            Role = propertyStr[5];
        }
    }
}