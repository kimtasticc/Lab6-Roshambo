using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Roshambo
{
    public class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            var random = new Random();
            Roshambo RandomRoshambo = (Roshambo)random.Next(1, 4);

            this.RoshamboMove = RandomRoshambo;
            return RandomRoshambo;
        }
    }
}
