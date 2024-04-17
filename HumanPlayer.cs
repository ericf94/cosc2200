/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is used to represent the human player.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartsGame
{
    public class HumanPlayer : Player
    { 

        public HumanPlayer(string name, List<Card> playersCards, bool isDealer) : base(name, playersCards, isDealer)
        {

        }

        public override void TakeTurn()
        {

        }
    }
}
