namespace LINQExp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//LINQ - Language integrated query

			// The Three Parts of a LINQ Query:
			// 1. Data source.
			var numbers = new[] { 0, 1, 2, 3, 4, 5, 6 };
			var ship = new Ship();
			var ships = new List<Ship> { };

			// 2. Query creation.
			// numQuery is an IEnumerable<int>
			var numQueryOld =
				from num in numbers
				where (num % 2) == 0
				select num;

			var numList = numQueryOld.ToList();

			var numArrayNew = numbers.Where(num => num % 2 == 0).Select(num => num).ToArray();

			// 3. Query execution.
			foreach (var num in numList)
			{
				Console.WriteLine($"{num}");
			}

			numList.ForEach(num =>
			{
				if (num > 2)
				{

				}
			});

			//static
			MathHelper.Multiply(5, 4);
			Math.Pow(5, 100);
			Console.WriteLine();

			//non static
			var a = new Ship();
			a.SetCoolNumber(5);
		}

		
	}
}