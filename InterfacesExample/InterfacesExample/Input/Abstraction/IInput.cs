namespace InterfacesExample.Input.Abstraction
{
    public interface IInput
    {
        string GetInput();

        void SetInput(string input);

        void ClearInput();

        void PrintInput();

        void PrintBoard(char[] characters);
    }
}
