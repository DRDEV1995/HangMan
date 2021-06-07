using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Superman", "Batman", "WonderWoman","Flash", "SpiderMan", "DoctorStrange", "Venom", "BlackLightning" };
            Random random = new Random();
            int randomIndex = random.Next(0, 8);

            string mysteryword = words[randomIndex];
            char[] guess = new char[mysteryword.Length];

            Console.WriteLine("Please enter your guess: ");


            for (int i = 0; i < mysteryword.Length; i++)
            {
                guess[i] = '#';
            }


            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryword.Length; j++)
                {
                    if (playerGuess == mysteryword[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
            }


        }
    }
}
