namespace CrescentCove.Model
{
    public class Item : IGameData, IItem
    {
        public int Id { get; set; }

        public void SetPropsByStr(string[] propertyStr)
        {
            Id = int.Parse(propertyStr[0]);
            SingularName = propertyStr[1];
            PluralName = propertyStr[2];
            ProperName = propertyStr[3];
            IsCommon = bool.Parse(propertyStr[4]);
            IsRetired = bool.Parse(propertyStr[5]);
        }

        public string ProperName { get; set; }
        public string SingularName { get; set; }
        public string PluralName { get; set; }
        public int Quantity { get; set; }
        public bool IsHQ { get; set; }
        public bool IsCommon { get; set; }
        public bool IsRetired { get; set; }
    }
}