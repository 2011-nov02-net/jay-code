using System;

namespace multiWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input several seperated words");
            string userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++) {
                if(i == 0 && !Char.IsWhiteSpace(userInput[i])) {
                    Console.Write(userInput[i]);
                }
                if (Char.IsWhiteSpace(userInput[i]) && !Char.IsWhiteSpace(userInput[i + 1])){
                    Console.Write(userInput[i+1]);
                }
            }
        }
    }
}