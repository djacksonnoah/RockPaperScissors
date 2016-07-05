using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        Random random = new Random();
        int favoriteMove;

        public StubbornAI()
        {
            favoriteMove = random.Next(0, 2);
        }

       // public StubbornAI(int favoriteMove)
       // {
       //     favoriteMove = favoriteMove;
       // }
        public int NextMove()
        {
            return favoriteMove;
        }

        public void SaveResult(int myMove, int otherMove)
        {

        }
    }
}
