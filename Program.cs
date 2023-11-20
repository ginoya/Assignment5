namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleReader.readFromConsole(OnWord, OnNumber, OnJunk);
        }
        public static void OnJunk(string junk)
        {
            Console.WriteLine("OnJunk called! as user input string is : {0}", junk);
        }

        public static void OnWord(string word)
        {
            Console.WriteLine("OnWord called! as user input string is : {0}", word);
        }

        public static void OnNumber(int number)
        {
            Console.WriteLine("OnNumber called! as user input string is : {0}", number);
        }

    }
}