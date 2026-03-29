using ConsoleApp.Modules;

class Program
{
    static void Main(string[] args)
    {
        string input = InputModule.ReadString("Введите строку: ");

        if (ValidationModule.IsNonEmptyString(input))
        {
            string reversed = ProcessingModule.ReverseString(input);
            ProcessingModule.PrintResult(reversed);
        }
        else
        {
            Console.WriteLine("Ошибка: строка пуста.");
        }

        Console.Read();
    }
};