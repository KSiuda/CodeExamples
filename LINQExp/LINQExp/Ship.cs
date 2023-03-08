namespace LINQExp
{
	public class Ship
	{
		//1. Automatic property
		public int Id { get; set; }

		//2. Get only property
		public int Count => list.Count;
		//{ get{ return list.Count }
		
		//3. Init property
		public List<int> list { get; init; } = new();

		//4. Set/init only property
		public Guid UniqueIdentifier
		{
			init => UniqueIdentifier = new Guid();
		}

		//5. Private set property
		public int CoolNumber { get; private set; }

		public bool SetCoolNumber(int coolNumber)
		{
			coolNumber = coolNumber * 2;
			CoolNumber = coolNumber;
			return true;
		}
	}
}
