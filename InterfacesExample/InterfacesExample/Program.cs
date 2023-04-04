using InterfacesExample.Input;
using InterfacesExample.Input.Abstraction;

namespace InterfacesExample
{
	internal class Program
	{
		private IInput input;
		public Program(IInput input)
		{
			this.input = input;
		}
		void Main(string[] args)
		{
			input.GetInput();
			input.SetInput("Hello World");
			input.ClearInput();

			//Tracimy niezaleźność od implementacji!!!
			var d = input as DesktopInput;
			d.DesktopDoSmth();
		}
	}
}