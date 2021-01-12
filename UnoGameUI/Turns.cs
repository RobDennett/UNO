using System;
using System.Collections.Generic;

namespace UnoGameUI
{
    public class Turns
    {
        public static void ComputersTurn()
        {
            int cardInPlay = Deck.playDeck.Count - 1;
            CardColour colour = Deck.playDeck[cardInPlay].Colour;
            CardValue value = Deck.playDeck[cardInPlay].Value;

            bool validCardInHand = false;

            foreach (CardModel card in Deck.computerHand)
            {
                if (card.Colour == colour || card.Value == value)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The Computer played {card.Colour} " +
                        $"{card.Value}. Press enter to continue.");
                    Console.ReadLine();
                    Deck.playDeck.Add(card);
                    Deck.computerHand.Remove(card);

                    validCardInHand = true;

                    return;
                }
            }

            if (validCardInHand == false)
            {
                PickUpACard(Deck.computerHand,
                    "The Computer picked up a card. Press enter to continue.");
            }
        }

        public static void PlayersTurn()
        {
            int cardInPlay = Deck.playDeck.Count - 1;
            CardColour colour = Deck.playDeck[cardInPlay].Colour;
            CardValue value = Deck.playDeck[cardInPlay].Value;

            bool validCardInHand = false;
            bool isValidSelection = false;
            
            foreach (CardModel card in Deck.playerHand)
            {
                if (card.Colour == colour || card.Value == value)
                {
                    validCardInHand = true;
                }
            }

            do
            {
                if (validCardInHand == true)
                {
                    isValidSelection = SelectCard(colour, value);
                }
                else
                {
                    isValidSelection = PickUpACard(Deck.playerHand,
                        "You do not have any matching cards. So you have to pick one up. " +
                        "Press enter to continue.");
                }
            } while (isValidSelection == false);
        }

        public static bool SelectCard(CardColour colour, CardValue value)
        {
            int card = GetInfo.GetPlayerCardSelection();

            try
            {
                if (Deck.playerHand.Contains(Deck.playerHand[card]))
                {
                    if (Deck.playerHand[card].Colour == colour || Deck.playerHand[card].Value == value)
                    {
                        Deck.playDeck.Add(Deck.playerHand[card]);
                        Deck.playerHand.Remove(Deck.playerHand[card]);

                         return true;
                    }
                    else
                    {
                        Console.WriteLine("That was an invalid selction. Press enter to try again");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That was an invalid selction. Please try again");
                return false;
            }

           return false;
        }

        public static bool PickUpACard(List<CardModel> list, string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            list.Add(Deck.DrawOneCard());
            Console.ReadLine();

            return true;
        }

        
    }
}
