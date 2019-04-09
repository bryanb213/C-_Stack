using System;
using System.Collections.Generic;
namespace cards {
    class Program {
        public class Card {
            public string stringVal;
            public string suit;
            public int val;
            public Card (string sval, string suitt, int vall) {
                stringVal = sval;
                suit = suitt;
                val = vall;
            }
        }
        public class Deck {
            public List<Card> cards;
            public Deck () {
                BuildDeck ();
            }
            public List<Card> BuildDeck () {
                string[] cardVals = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen" };
                string[] suits = new string[] { "Hearts", "Spades", "Clubs", "Diamonds" };
                cards = new List<Card> ();
                for (int i = 0; i < suits.Length; i++) {
                    for (int j = 0; j < cardVals.Length; j++) {
                        cards.Add (new Card (cardVals[j], suits[i], i - 1));
                    }
                }
                return cards;
            }
            public Card TopMost () {
                return cards[0];
            }
            public List<Card> Shuffle () {
                Random rand = new Random ();
                for (int i = 0; i < cards.Count / 2; i++) {
                    Card temp = cards[0];
                    cards[i] = cards[rand.Next (cards.Count)];
                    cards[rand.Next (cards.Count)] = temp;
                }
                return cards;
            }

        }
        public class Player {
            public string name;
            public List<Card> hand;

            public Player () {
                
            }
            public List<Card> Draw (Card card) {

                hand.Add (card);
                return hand;
            }

        }
        static void Main (string[] args) {
            Deck Deck = new Deck ();
            System.Console.WriteLine (Deck.cards.Count);
            Player sam = new Player ();
            sam.Draw (Deck.TopMost ());
            sam.Draw (Deck.TopMost ());
           // System.Console.WriteLine ($"the  hand\n {sam.hand[0].stringVal}/n{sam.hand[1].stringVal}");
        }
    }
}