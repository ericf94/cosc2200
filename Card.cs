/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is used to represent a playing card.
 * Note: This class was adapted from Alaadin Addas' CardDisplayTake3 from another course for this project.
 */
using Hearts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HeartsGame
{
    /// <summary>
    /// Card class to represent a card in the deck
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Assign enums for Suits
        /// </summary>
        public enum Suits
        {
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4,
        }

        //Assign enums for Ranks
        public enum Ranks
        {
            Two = 1,
            Three = 2,
            Four = 3,
            Five = 4,
            Six = 5,
            Seven = 6,
            Eight = 7,
            Nine = 8,
            Ten = 9,
            Jack = 10,
            Queen = 11,
            King = 12,
            Ace = 13,
        }

        /// <summary>
        /// Declare Suit and Rank as variables with get and set methods
        /// </summary>
        public Guid ID { get; set; }
        public Suits suit { get; set; }
        public Ranks rank { get; set; }
        public Boolean isFlipped { get; set; }
        public BitmapImage cardImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="card"></param>
        /// <param name="isFlipped"></param>
        public Card(Suits suit, Ranks rank, Boolean isFlipped)
        {
            //Lets create some sort of ID to uniquely identify the cards.
            this.ID = Guid.NewGuid();
            //set card suit
            this.suit = suit;
            //set card rank
            this.rank = rank;
            //set is flipped or not
            this.isFlipped = isFlipped;
            this.cardImage = GetCardImagePath(suit, rank, isFlipped);
        }

        public Card(Suits suit, Ranks rank)
        {
            //Lets create some sort of ID to uniquely identify the cards.
            this.ID = Guid.NewGuid();
            //set card suit
            this.suit = suit;
            //set card rank
            this.rank = rank;
            //set is flipped or not
            this.isFlipped = false;
            this.cardImage = GetCardImagePath(suit, rank, isFlipped);
        }

        /// <summary>
        /// No parameter constructor
        /// </summary>
        public Card()
        {

        }
        
        // equal to operator
        public static bool operator == (Card op1, Card op2)
        {
            return (op1.rank == op2.rank);
        }

        // not equal to operator
        public static bool operator !=(Card op1, Card op2)
        {
            return (op1.rank != op2.rank);
        }

        // greater than operator
        public static bool operator > (Card op1, Card op2)
        {
            return (op1.rank > op2.rank);
        }

        // less than operator
        public static bool operator <(Card op1, Card op2)
        {
            return (op1.rank < op2.rank);
        }

        /*
        /// <summary>
        /// Override String method to return card as String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.rank + " of " + this.suit;
        }
        */

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Gets the image card path using the helper class method getimagepath
        /// </summary>
        //This method utilizes the Helper class method GetImage to get the path of the the image.

        public const string PLAYING_CARDS_PATH = @"\images\cards";
        public BitmapImage GetCardImagePath(Suits suit, Ranks rank, Boolean isFlipped)
        {
            if (isFlipped == true)
            {

                return Helper.GetImage(PLAYING_CARDS_PATH + "//back.bmp");
            }
            else
            {

                return Helper.GetImage(PLAYING_CARDS_PATH + "//" + suit.ToString() + (int)rank + ".svg");
            }

        }

        public override string ToString()
        {
            return suit.ToString() + (int)rank + ".png";
        }

    }
}
