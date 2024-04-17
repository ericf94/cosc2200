/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is used to represent a single round in the game of hearts
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HeartsGame
{
    /// <summary>
    /// A class for the round within a game.
    /// </summary>
    public class Round
    {
        private Deck deck;
        private List<Player> players;
        private Score roundScore;


        //Constructor
        public Round(Deck deck, List<Player> players, Score roundScore)
        {
            this.deck = deck;
            this.players = players;
            this.roundScore = roundScore;
        }

        /// <summary>
        /// Start and play a new round
        /// </summary>
        public void PlayRound()
        {
            //
            Console.WriteLine("New round initiating...");

            //Reset deck
            deck.Reset();

            //Shuffle Deck
            deck.Shuffle();

            //Deal Cards to Players
            DealCards();

            //Start round of moves to be made starting with player to the left of dealer



            //End round 
        }

        /// <summary>
        /// Deals 13 cards to players in the player list
        /// </summary>
        private void DealCards()
        {
            //Deal 13 cards to each player

            foreach (var player in players)
            {
                for (int i = 0; i < 13; i++)
                {
                    player.playersCards.Add(deck.TakeCard());
                }
            }

            // Rotate through players until each player has 13 cards
            /*for (int i = 0; i < 13; i++)
            {
                foreach (var player in players)
                {
                    player.playersCards.Add(deck.TakeCard());
                }
            }*/

            // Sort each player's hand by rank and suit
            foreach (var player in players)
            {
                player.playersCards = Sort(player.playersCards);

                foreach (Card card in player.playersCards)
                {
                    card.cardImage = card.GetCardImagePath(card.suit, card.rank, false);

                }
            }

            


            //card1.Source = players[0].playersCards[0].cardImage;
            //card2.Source = players[0].playersCards[1].cardImage;
            //card3.Source = players[0].playersCards[2].cardImage;


            /*
            //Output each player's hand
            foreach (var player in players)
            {
                Console.WriteLine( "\n" + player.name + " has been dealt the following cards:");

                foreach (var card in player.playersCards)
                {
                    Console.WriteLine(card.ToString());
                }
            }
            */
        }

        /// <summary>
        /// Sorts the list of cards by suit and rank
        /// </summary>
        /// <param name="listOfCards"></param>
        /// <returns></returns>
        public List<Card> Sort(List<Card> listOfCards)
        {
            List<Card> sorted = listOfCards.GroupBy(s => s.suit).
                OrderByDescending(r => r.Count()).SelectMany(g => g.OrderByDescending(r => r.rank)).ToList();

            return sorted;
        }
        
        public void TakeTurns()
        {
            /*//Start round of moves to be made starting with player to the left of dealer
            for (int i = 0; i < 13; i++)
            {
                foreach (var player in players)
                {
                    player.TakeTurn();
                }
            }*/
        }
    }
}
