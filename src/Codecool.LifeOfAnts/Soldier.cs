using System;

namespace Codecool.LifeOfAnts
{
    public class Soldier : Ant
    {
        private int _steps = 0;

        public Soldier(Position position) : base(position)
        {

        }

        public override void Act(int width, int antsNum)
        {
            switch (_steps)
            {
                case 0:
                    if (position.X > 0 && (position.X - 1 != width / 2 || position.Y != width / 2))
                    {
                        position = new Position(position.X - 1, position.Y);
                    }
                    _steps++;
                    break;
                case 1:
                    if (position.Y < width - 1 && (position.X != width / 2 || position.Y + 1 != width / 2))
                    {
                        position = new Position(position.X, position.Y + 1);
                    }
                    _steps++;
                    break;
                case 2:
                    if (position.X < width - 1 && (position.X + 1 != width / 2 || position.Y != width / 2))
                    {
                        position = new Position(position.X + 1, position.Y);
                    }
                    _steps++;
                    break;
                case 3:
                    if (position.Y > 0 && (position.X != width / 2 || position.Y - 1 != width / 2))
                    {
                        position = new Position(position.X, position.Y - 1);
                    }
                    _steps = 0;
                    break;
            }
        }
    }
}