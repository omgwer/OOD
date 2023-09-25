namespace Lab1_4.utils
{
    public static class CommandLineExtensions
    {
        public static IReadOnlyList<string> ToArgumentsList(this string inputString)
        {
            return inputString.Split( ' ' ).ToList();
        }
    }
}