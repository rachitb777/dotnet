using System;

namespace singleRowKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: <keyboard> <word>");
                return;
            }

            Console.WriteLine(GetTime(args[0], args[1]));
        }

        static int GetTime(string keyboard, string word)
        {
            if (keyboard.Length != 26) 
            {
                throw new ArgumentException("The length of keyboard should be 26");
            }
            int []charMap = new int[26];
            for (int i = 0; i < keyboard.Length; i++)
            {
                int charVal = keyboard[i] - 97;
                charMap[charVal] = i;
            }
            int cost = 0;
            int lastPos = keyboard[0]-97;
            for (int i = 0; i < word.Length; i++)
            {
                int charVal = word[i] - 97;
                cost += Math.Abs(charMap[charVal] - charMap[lastPos]);
                lastPos = charVal;
            }
            return cost;
        }
    }
}
