using InterfacesExample.Input.Abstraction;

namespace InterfacesExample.Input
{
    internal class ConsoleInput : IInput
    {
        public string GetInput()
        {
            var input = Console.ReadLine();
            if (input is string)
            {
                return input;
            }

            return string.Empty;
        }

        public void SetInput(string input)
        {
            throw new NotImplementedException();
        }

        public void ClearInput()
        {
            throw new NotImplementedException();
        }

        public void PrintInput()
        {
            throw new NotImplementedException();
        }

        public void PrintBoard(char[] characters)
        {
            throw new NotImplementedException();
        }
    }
}
