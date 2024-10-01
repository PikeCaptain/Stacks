using System;
using System.Collections.Generic;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intializes an array of Card objects with various cards
            Card[] myCardsArray = new Card[]
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Diamonds"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Ace", "Diamonds")
            };

            //Creates a stack from the array of cards to represent the starting deck
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            //Outputs the cards currently in the deck
            Console.WriteLine("Cards in Deck");
            foreach (Card card in startingDeck) 
            {
                // Displays each card
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            //Displays the number of cards currently in the deck
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            //Intializes a list to represent the player's hand
            List<Card> myHand = new List<Card>();
            myHand.Add(new Card("jack", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("3", "Diamonds"));

            //Checks if there are any cards left in the deck before adding to hand
            Console.WriteLine("Got any 8's");
            if (startingDeck.Count > 0) 
            {
                //Removes a card from the deck and adds it to the hand
                myHand.Add(startingDeck.Pop());
            }

            //Displays the updated count oof cards in the deck
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            //Moves the first card from the hand back to the deck 
            startingDeck.Push(myHand[0]); //Pushes the first card in hand back to deck
            myHand.RemoveAt(0); // removes that card from the hand

            //Outputs the cards currently in the deck again
            Console.WriteLine("Cards in Deck");
            foreach (Card card in startingDeck)
            {
                //Displays each card in the updated deck
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}
