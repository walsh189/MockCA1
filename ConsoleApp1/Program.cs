using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            List<Player> allPlayers = new List<Player>();
            allPlayers.Add(player1);
            allPlayers.Add(player2);
            allPlayers.Add(player3);
            allPlayers.Add(player4);
            allPlayers.Add(player5);

            Display(allPlayers);
            GetScores(allPlayers);
            DisplayPlayerDetails(allPlayers);

            allPlayers.Sort();
            allPlayers.Reverse();
            DisplayPlayerDetails(allPlayers);

            Console.WriteLine($"The highest score is {Player.HighScore}");
        }

        private static void GetScores(List<Player> allPlayers)
        {
            Console.WriteLine("Please enter number of player you wish to add score for");
            string response = Console.ReadLine();
            int playerNumber = int.Parse(response);

            while (playerNumber != 0)
            {
                //determine player selected
                Player selectedPlayer = allPlayers.ElementAt(playerNumber - 1);//using -1 as index starts at 0

                //increase score for that player
                selectedPlayer.IncreaseScore(1);

                //display results
                Display(allPlayers);

                //ask for another player or 0 to quit
                Console.WriteLine("Please enter number of player you wish to add score for");
                response = Console.ReadLine();
                playerNumber = int.Parse(response);
            }//end of while loop
        }

        private static void Display(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");

            foreach (Player player in players)
            {
                Console.Write("{0,-10}", player.Score);
            }

            Console.WriteLine();//add a new line at the end of scores
        }

        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"ID"}\t{"Name"}\t{"Score"}");
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
