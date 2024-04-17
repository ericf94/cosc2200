/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is used to represent an AI player in the game of Hearts.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartsGame
{
    public class AIPlayer : Player
    {
        public AIPlayer(string name, List<Card> playersCards, bool isDealer) : base(name, playersCards, isDealer)
        {

        }

        public override void TakeTurn()
        {

        }
    }
}
