namespace ConsoleApp.Modules
{
    public static class ProcessingModule
    {
        public static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static void PrintResult(string result)
        {
            Console.WriteLine("Результат: " + result);
        }
    }
}