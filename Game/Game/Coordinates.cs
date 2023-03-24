namespace Game
{
	public class Coordinates
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		public int Z { get; private set; }
		public GameElement Item { get; private set; }

		public Coordinates(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Coordinates(int x, int y)
		{
			X = x;
			Y = y;
			Z = 0;
		}

		public void Change(int x, int y, GameElement item)
		{
			X = x;
			Y = y;
			Item = item;
		}
	}
}