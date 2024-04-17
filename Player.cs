/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is an abstract class for player's in the game of hearts.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartsGame
{
    /// <summary>
    /// an abstract class that will be used for the player and the AIs
    /// </summary>
    public abstract class Player
    {
        //player name
        public string name { get; set; }

        //the cards a player has in their hand
        public List<Card> playersCards { get; set; }

        //represents if player is dealer
        public bool isDealer { get; set; }

        //represents if it is player's turn
        //public bool isTurn { get; set; }

        //default Constructor
        public Player(string name, List<Card> playersCards, bool isDealer)
        {
            this.name = name;
            this.playersCards = playersCards;
            this.isDealer = isDealer;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void TakeTurn()
        {

        }

    }
}
