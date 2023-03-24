namespace Game
{
	public class GameElement
	{
		public Coordinates Location { get; private set; }

		public void ChangeCoordinates(int x, int y)
		{
			Location.Change(x, y, this);
		}
	}
}
