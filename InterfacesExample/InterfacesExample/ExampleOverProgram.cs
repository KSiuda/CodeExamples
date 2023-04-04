using InterfacesExample.Input;

namespace InterfacesExample
{
	public class ExampleOverProgram
	{
		public void Do()
		{
			var input = new DesktopInput();
			Program program = new Program(input);
		}
	}
}
