namespace ConsoleApp.Modules
{
    public static class InputModule
    {
        public static string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}