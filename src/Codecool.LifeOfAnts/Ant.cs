using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.LifeOfAnts
{
    public abstract class Ant
    {
        public Position position { get; set; }

        public Ant(Position pos)
        {
            position = pos;
        }

        public abstract void Act(int width, int antsNum);
    }
}
