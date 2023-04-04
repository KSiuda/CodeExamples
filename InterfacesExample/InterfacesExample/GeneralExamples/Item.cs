namespace InterfacesExample.GeneralExamples
{
    public class Item : Test1, IEquatable<Item>, IDestructible
    {
        public int HealthPoints { get; set; }

        public bool Equals(Item? other)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }

}
