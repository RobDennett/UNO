using System;

namespace UnoGameUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay.GameSetUp();

            GamePlay.Play();
 
            Console.ReadLine();
        }
    }
}

