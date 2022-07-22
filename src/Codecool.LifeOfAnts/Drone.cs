using System;

namespace Codecool.LifeOfAnts
{
    public class Drone : Ant
    {

        private bool _status;
        private int _counter;

        public Drone(Position position) : base(position)
        {
            _status = true;
        }

        public override void Act(int width, int antsNum)
        {
            if (position.X < width / 2)
            {
                position = new Position(position.X + 1, position.Y);
            }
            else if ((position.X > width / 2))
            {
                position = new Position(position.X - 1, position.Y);
            }

            if (position.Y < width / 2)
            {
                position = new Position(position.X, position.Y + 1);
            }
            else if ((position.Y > width / 2))
            {
                position = new Position(position.X, position.Y - 1);
            }
            else
            {

                if (Colony.Counter <= 0 && position.X == width / 2 && position.Y == width / 2)
                {
                    _status = false;
                    //Talk();
                    Colony.Counter = new Random().Next(50, 101);
                    _counter = Colony.Counter;
                }

                if (_status is false)
                {
                    position = new Position(position.X - 1, position.Y);
                    if (_counter - 10 >= Colony.Counter)
                    {
                        _status = true;
                    }
                }
                else
                {
                    Random r = new Random();
                    int rowOrCol = r.Next(0, 2) == 0 ? 0 : 1;
                    int[] values = new int[] { 0, width - 1 };
                    if (rowOrCol == 0)
                    {
                        position = new Position(values[r.Next(0, 2)], r.Next(0, width - 1));
                    }
                    else
                    {
                        position = new Position(r.Next(0, width - 1), values[r.Next(0, 2)]);
                    }

                }
            }
        }

        public void Talk(int width)
        {
            if (position.X == width / 2 && position.Y == width / 2)
            {
                if (_status)
                {
                    Console.WriteLine(":( I want sex!");
                }
            }
            else if (position.X == width / 2 - 1 && position.Y == width / 2)
            {
                if (_status is false)
                {
                    Console.WriteLine("YEAH PUSSY!");
                }

            }
        }
    }
}