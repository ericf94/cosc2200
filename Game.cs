/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class is used to represent a game of Hearts.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartsGame
{
    public class Game
    {
        private Deck deck; //Deck used for game
        private List<Player> players; //Players in the game
        private List <Round> rounds; //Rounds in the game
        private Score gameScore; //Score of the game

        /// <summary>
        /// Constructor for Game class
        /// </summary>
        public Game()
        {
            deck = new Deck(); //Instantiate new deck to be used for the entire game

            //Instantiate new list of players for entirety of this game
            players = new List<Player> 
            {
                new HumanPlayer("Player 1", null, false), //Instantiate Human Player

                //Instantiate AI PLayers
                new AIPlayer("Player 2", null, false), 
                new AIPlayer("Player 3", null, false), 
                new AIPlayer("Player 4", null, false)
            };

            rounds = new List<Round>(); //Instantiate new list of rounds for the game

            Score gameScore = new Score(); //Instantiate new score for the game
        }

        /// <summary>
        /// Starts game
        /// </summary>
        public void PlayGame()
        {
            //Variables
            Round thisRound = new Round(deck, players, gameScore);//Instantiate round using deck, players, and gamescore

            //Methods
            ChooseDealer();//Determine Starting Dealer
            thisRound.PlayRound();//Play round
            CheckScore();//Check score
            
        }


        /// <summary>
        /// Checks game score and determines winner
        /// </summary>
        public void CheckScore()
        {
            //get score
            //Check if any of the player's score is greater than 100
                //if yes, end game
                //if no, PlayRound()

        }

        /// <summary>
        /// Selects who becomes the first dealer
        /// </summary>
        public void ChooseDealer()
        {

            //Shuffle deck
            deck.Shuffle();

            //Each player draws a card to determine dealer
            foreach (var player in players)
            {
                player.playersCards = deck.TakeCards(1);
            }

            //Output the card each player drew
            for(int playerNumber = 0; playerNumber < players.Count; playerNumber++)
            {
                Console.WriteLine(players[playerNumber].name + " drew the " + players[playerNumber].playersCards[0] + "\n");
                
            }

            //Determine dealer based on highest card drawn.. If there is a tie, draw again
            if (players[0].playersCards[0].rank > players[1].playersCards[0].rank && players[0].playersCards[0].rank > players[2].playersCards[0].rank && players[0].playersCards[0].rank > players[3].playersCards[0].rank)
            {
                players[0].isDealer = true;
                Console.WriteLine(players[0].name + " is the dealer" + "\n");

            }
            else if (players[1].playersCards[0].rank > players[0].playersCards[0].rank && players[1].playersCards[0].rank > players[2].playersCards[0].rank && players[1].playersCards[0].rank > players[3].playersCards[0].rank)
            {
                players[1].isDealer = true;
                Console.WriteLine(players[1].name + " is the dealer" + "\n");

            }
            else if (players[2].playersCards[0].rank > players[0].playersCards[0].rank && players[2].playersCards[0].rank > players[1].playersCards[0].rank && players[2].playersCards[0].rank > players[3].playersCards[0].rank)
            {
                players[2].isDealer = true;
                Console.WriteLine(players[2].name + " is the dealer" + "\n");

            }
            else if (players[3].playersCards[0].rank > players[0].playersCards[0].rank && players[3].playersCards[0].rank > players[1].playersCards[0].rank && players[3].playersCards[0].rank > players[2].playersCards[0].rank)
            {
                players[3].isDealer = true;
                Console.WriteLine(players[3].name + " is the dealer" + "\n");
            } 
            else
            {
                Console.WriteLine("There was a tie. Drawing again to determine dealer" + "\n");
                ChooseDealer();
            }


        }

    }
}
