using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Roshambo
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RoshamboMove { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}