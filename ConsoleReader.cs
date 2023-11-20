using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public delegate void OnWord(string word);

    public delegate void OnNumber(int number);

    public delegate void OnJunk(string junk);

    public static class ConsoleReader
    {
        public static void readFromConsole(OnWord onWord, OnNumber onNumber, OnJunk onJunk)
        {
            Console.WriteLine("Please enter text : ");
            string inputWord = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputWord))
            {
                if (inputWord.All(char.IsLetter))
                {
                    onWord(inputWord);
                }
                else if (inputWord.All(char.IsDigit))
                {
                    onNumber(int.Parse(inputWord));
                }
                else
                {
                    onJunk(inputWord);
                }
            }

        }
    }
}
