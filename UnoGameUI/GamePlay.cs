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
                DisplayToUser.CardInfo();

                do
                {
                    specialCardPlayed = false;
                    int cardInPlayCheck = Deck.playDeck.Count - 1;
                    
                    Turns.PlayersTurn();

                    DisplayToUser.CardInfo();

                    if (cardInPlayCheck != Deck.playDeck.Count - 1)
                    {
                        specialCardPlayed = WasSpecialCardPlayed(Deck.computerHand, "The Computer");
                    }

                    DisplayToUser.CardInfo();

                    if (Deck.playerHand.Count == 0)
                    {
                        GameMessages.DisplayWin();
                        isThereAWinner = true;
                        return;
                    }

                    CheckDrawPile();

                } while (specialCardPlayed == true);

                do
                {
                    specialCardPlayed = false;
                    int cardInPlayCheck = Deck.playDeck.Count - 1;

                    Turns.ComputersTurn();

                    if (cardInPlayCheck != Deck.playDeck.Count - 1)
                    {
                        specialCardPlayed = WasSpecialCardPlayed(Deck.playerHand, "You");
                    }

                    DisplayToUser.CardInfo();

                    if (Deck.computerHand.Count == 0)
                    {
                        GameMessages.DisplayLose();
                        isThereAWinner = true;
                        return;
                    }

                    CheckDrawPile();

                } while (specialCardPlayed == true);

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

        public static void CheckDrawPile()
        {
            if (Deck.drawPile.Count <= 5)
            {
                Deck.ShuffleDeck();
            }
        }
    }
}
