namespace Game
{
	public class Creature : GameElement
	{
		public int Health { get; set; }
		public int Mana { get; set; }

		public Creature (Coordinates location)
		{
			Health = 100;
			Mana = 20;

			Location.Change(location.X, location.Y, this);
		}
	}
}
