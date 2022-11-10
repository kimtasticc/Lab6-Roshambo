using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Roshambo
{
    public class RockPlayer : Player
    {
        
        
        public override Roshambo GenerateRoshambo()
        {
            return this.RoshamboMove = Roshambo.Rock;
        }
    }
}
