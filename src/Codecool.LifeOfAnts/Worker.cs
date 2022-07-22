using System;

namespace Codecool.LifeOfAnts
{
    public class Worker : Ant
    {
        public Worker(Position position) : base(position)
        {

        }

        public override void Act(int width, int antsNum)
        {
            Random r = new Random();
            int enumLength = Enum.GetNames(typeof(Direction)).Length;
            Direction direction = (Direction)r.Next(enumLength);
            switch (direction)
            {
                case Direction.North:
                    if (position.X > 0 && (position.X - 1 != width / 2 || position.Y != width / 2))
                    {
                        position = new Position(position.X - 1, position.Y);
                    }
                    break;
                case Direction.South:
                    if (position.X < width - 1 && (position.X + 1 != width / 2 || position.Y != width / 2))
                    {
                        position = new Position(position.X + 1, position.Y);
                    }
                    break;
                case Direction.East:
                    if (position.Y < width - 1 && (position.X != width / 2 || position.Y + 1 != width / 2))
                    {
                        position = new Position(position.X, position.Y + 1);
                    }
                    break;
                case Direction.West:
                    if (position.Y > 0 && (position.X != width / 2 || position.Y - 1 != width / 2))
                    {
                        position = new Position(position.X, position.Y - 1);
                    }
                    break;
            }




        }
    }
}