namespace ConsoleApp.Modules
{
    public static class ValidationModule
    {
        public static bool IsNonEmptyString(string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}