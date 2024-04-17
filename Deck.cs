/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is used to represent a deck of playing cards.
 * Note: This class was adapted from Alaadin Addas' CardDisplayTake3 from another course for this project.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartsGame
{
    /// <summary>
    /// The deck class for the deck used throughout a game
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// The constructor calls the Reset method to create a new deck of cards
        /// </summary>
        public Deck()
        {
            Reset();
        }

        public List<Card> Cards { get; set; }

        /// <summary>
        /// Resets the deck to a new deck of cards
        /// </summary>
        public void Reset()
        {
            // LINQ query used to return list of cards using Card class enums
            Cards = Enumerable.Range(1, 4).SelectMany(s => Enumerable.Range(1, 13).Select(r => new Card()
            {
                suit = (Card.Suits)s, //cast to Suits enum
                rank = (Card.Ranks)r // cast to Ranks enum
            }
                ) //close Select satement for new card
            ).ToList(); //close SelectMany statement for new card and convert to list
        }
        /// <summary>
        /// Shuffles Deck
        /// </summary>
        public void Shuffle()
        {
            //Shuffles list card of objects
            Cards = Cards.OrderBy(r => Guid.NewGuid()).ToList();
        }

        /// <summary>
        /// Removes a card from the deck and returns it
        /// </summary>
        /// <returns>The card taken from the deck </returns>
        public Card TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }

        /// <summary>
        /// Removes a number of cards from the deck and returns them
        /// </summary>
        /// <param name="numberOfCards"></param>
        /// <returns> The cards taken from the deck </returns>
        public List<Card> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);

            //var takeCards = cards as Card[] ?? cards.ToArray();
            var takeCards = cards as List<Card> ?? cards.ToList();
            Cards.RemoveAll(takeCards.Contains);

            return takeCards;
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
    }
}
