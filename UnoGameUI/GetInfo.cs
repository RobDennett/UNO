using System;

namespace UnoGameUI
{
    public class GetInfo
    {
        public static PlayerModel player = new PlayerModel();
        public static ComputerModel computer = new ComputerModel();

        public static void GetPlayerName()
        {
            bool isValidName;
            do
            {
                Console.Write("Enter Players Name: ");
                player.Name = Console.ReadLine();

                if (player.Name == "")
                {
                    Console.WriteLine("That was not a valid name. Please try again.");
                    isValidName = false;
                }
                else
                {
                    isValidName = true;
                }

            } while (isValidName == false);
        }

        public static int GetPlayerCardSelection()
        {
            Console.WriteLine();
            Console.Write("What card in your hand do you want to play? eg. 1 or 2 or 3 etc: ");
            string cardSelection = Console.ReadLine();
            int.TryParse(cardSelection, out int cardIndex);

            return cardIndex - 1;
        }

        public static bool DoYouWantToPlayAgain()
        {
            do
            {
                Console.WriteLine();
                Console.Write("Do you want to play again? y/n: ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    return true;
                }
                else if (answer.ToLower() == "n" || answer.ToLower() == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That was not a valid answer. Please try again. ");
                }
            } while (true);
        }
    }
}
