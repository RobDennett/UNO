using System;
using System.Collections.Generic;

namespace UnoGameUI
{
    public class GamePlay
    {
        public static void GameSetUp()
        {
            GameMessages.DisplayStart();

            GetInfo.GetPlayerName();

            Deck.CreateDoubleDeck();
            Deck.ShuffleDeck();
            Deck.CreatePlayDeck();
            Deck.DealCards();
        }

        public static void Play()
        {
            bool isThereAWinner = false;
            bool specialCardPlayed;

            do
            {
                DisplayToUser.UsersHand();
                DisplayToUser.PlayDeck();

                do
                {
                    specialCardPlayed = false;
                    int cardInPlayCheck = Deck.playDeck.Count - 1;
                    
                    Turns.PlayersTurn();
                    DisplayToUser.UsersHand();
                    DisplayToUser.PlayDeck();

                    if (cardInPlayCheck != Deck.playDeck.Count - 1)
                    {
                        specialCardPlayed = WasSpecialCardPlayed(Deck.computerHand, "The Computer");
                    }

                    DisplayToUser.UsersHand();
                    DisplayToUser.PlayDeck();

                } while (specialCardPlayed == true);

                if (Deck.playerHand.Count == 0)
                {
                    GameMessages.DisplayWin();
                    isThereAWinner = true;
                    return;
                }

                do
                {
                    specialCardPlayed = false;
                    int cardInPlayCheck = Deck.playDeck.Count - 1;

                    Turns.ComputersTurn();

                    if (cardInPlayCheck != Deck.playDeck.Count - 1)
                    {
                        specialCardPlayed = WasSpecialCardPlayed(Deck.playerHand, "You");
                    }

                    DisplayToUser.UsersHand();
                    DisplayToUser.PlayDeck();

                } while (specialCardPlayed == true);

                if (Deck.computerHand.Count == 0)
                {
                    DisplayToUser.UsersHand();
                    GameMessages.DisplayLose();
                    isThereAWinner = true;
                    return;
                }

                if (Deck.drawPile.Count <= 12)
                {
                    Deck.ShuffleDeck();
                }

            } while (isThereAWinner == false);
        }

        public static bool WasSpecialCardPlayed(List<CardModel> list, string who)
        {
            int cardInPlay = Deck.playDeck.Count - 1;

            
            if (Deck.playDeck[cardInPlay].Value == CardValue.PlusTwo)
            {
                Deck.DrawTwoCards(list);
                Console.WriteLine();
                Console.WriteLine($"{who} picked up two cards. Press enter to continue.");
                Console.ReadLine();
                return true;
            }
            else if (Deck.playDeck[cardInPlay].Value == CardValue.PlusFour)
            {
                Deck.DrawFourCards(list);
                Console.WriteLine();
                Console.WriteLine($"{who} picked up four cards. Press enter to continue.");
                Console.ReadLine();
                return true;
            }
            else if (Deck.playDeck[cardInPlay].Value == CardValue.Skip)
            {
                Console.WriteLine();
                Console.WriteLine($"{who} had to skip a go. Press enter to continue.");
                Console.ReadLine();
                return true;
            }

            return false;
        }
    }
}
