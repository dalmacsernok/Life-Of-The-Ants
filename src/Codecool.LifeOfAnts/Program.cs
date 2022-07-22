using System;
using System.Threading;

namespace Codecool.LifeOfAnts
{
    /// <summary>
    ///     Simulation main class
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        public static void Main()
        {
            Colony colony = new Colony(10);
            colony.GenerateAnts(3, 2, 2);
            while (true)
            {
                //Thread.Sleep(1000);
                //Console.Clear();
                
                string input = Console.ReadLine();
                if (input.ToUpper() == "Q" || input.ToUpper() == "EXIT")
                {
                    Environment.Exit(0);
                }
                colony.Update();
                colony.Display();
            }
        }
    }
}
