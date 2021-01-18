using System;

namespace UnoGameUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain;
            do
            {
                Console.Clear();

                GamePlay.ClearCards();

                GamePlay.GameSetUp();

                GamePlay.Play();

                playAgain = GetInfo.DoYouWantToPlayAgain();

            } while (playAgain == true);

            Console.WriteLine();
            Console.WriteLine("THANKS FOR PLAYING!");
 
            Console.ReadLine();
        }

    }
 
}

