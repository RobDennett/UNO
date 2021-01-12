using System;
using System.Linq;

namespace UnoGameUI
{
    public class DisplayToUser
    {
        public static void UsersHand()
        {
            Console.Clear();

            Console.WriteLine($"{GetInfo.player.Name}'s cards...          " +
                $"{GetInfo.computer.Name}'s card count: {ComputersCardCount()}");

            Console.WriteLine();

            int index = 1;

            foreach (var card in Deck.playerHand)
            {
                Console.WriteLine($"{index++}: {card.Colour.ToString()} {card.Value.ToString()}");
            }
            Console.WriteLine();
        }

        public static int ComputersCardCount()
        {
            int output = Deck.computerHand.Count();

            return output;
        }

        public static void PlayDeck()
        {
            int lastCard = Deck.playDeck.Count - 1;
            Console.WriteLine($"Card in Play: {Deck.playDeck[lastCard].Colour} {Deck.playDeck[lastCard].Value} ");
        }
    }
}
