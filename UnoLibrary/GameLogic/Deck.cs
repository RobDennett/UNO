using System;
using System.Collections.Generic;
using System.Linq;



namespace UnoGameUI
{
    public class Deck
    {
        public static List<CardModel> mainDeck = new List<CardModel>();
        public static List<CardModel> drawPile = new List<CardModel>();
        public static List<CardModel> playDeck = new List<CardModel>();
        public static List<CardModel> playerHand = new List<CardModel>();
        public static List<CardModel> computerHand = new List<CardModel>();

        public static void CreateSingleDeck()
        {
            for (int colour = 0; colour < 4; colour++)
            {
                for (int value = 0; value < 10; value++)
                {
                    mainDeck.Add(new CardModel { Colour = (CardColour)colour, Value = (CardValue)value });
                }

                for (int value = 10; value < 13; value++)
                {
                    mainDeck.Add(new CardModel { Colour = (CardColour)colour, Value = (CardValue)value });
                }
            }
        }

        public static void CreateDoubleDeck()
        {
            CreateSingleDeck();
            CreateSingleDeck();
        }

        public static void CreatePlayDeck()
        {
            playDeck.Add(DrawOneCard());
        }

        public static void AddCardToPlayDeck(CardModel card)
        {
            playDeck.Add(card);
        }

        public static void ShuffleDeck()
        {
            Random rand = new Random();
            drawPile = mainDeck.OrderBy(x => rand.Next()).ToList();
        }

        public static CardModel DrawOneCard()
        {
            CardModel card = drawPile.Take(1).First();
            drawPile.Remove(card);
            return card;
        }

        public static void DrawTwoCards(List<CardModel> list)
        {
            list.Add(DrawOneCard());
            list.Add(DrawOneCard());
        }

        public static void DrawFourCards(List<CardModel> list)
        {
            list.Add(DrawOneCard());
            list.Add(DrawOneCard());
            list.Add(DrawOneCard());
            list.Add(DrawOneCard());
        }

        public static void DealCards()
        {
            for (int i = 0; i < 7; i++)
            {
                playerHand.Add(DrawOneCard());
            }

            for (int i = 0; i < 7; i++)
            {
                computerHand.Add(DrawOneCard());
            }
        }

        
    }

    
}

