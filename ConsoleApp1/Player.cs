using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player : IComparable
    {
        public int ID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }

        public static int HighScore { get; private set; }

        public Player(int id, string playerName, int score)
        {
            ID = id;
            PlayerName = playerName;
            Score = score;
        }

        public void IncreaseScore(int valueToAdd)
        {
            if (Score < 100)
                Score += valueToAdd;

            if (Score > HighScore)
                HighScore = Score;
        }

        public override string ToString()
        {
            return $"{ID}\t{PlayerName}\t{Score}"; 
        }

        public int CompareTo(object obj)
        {
            //get a reference to the next object in the list/array/collection
            Player objectThatIAmComparingTo = (Player)obj;

            //indicate what field I want to compare
            int returnValue = this.Score.CompareTo(objectThatIAmComparingTo.Score);

            //return
            return returnValue;


            //Player a = this;
            //Player b = (Player)obj;

            //int playerA_Score = a.Score;
            //int playerB_Score = b.Score;


            //int returnValue;

            //if (playerA_Score > playerB_Score)
            //    returnValue = 1;
            //else if (playerA_Score < playerB_Score)
            //    returnValue = -1;
            //else returnValue = 0;

            //return returnValue;



        }
    }
}
