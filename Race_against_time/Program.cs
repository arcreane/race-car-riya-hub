using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Car_race
{
    class Program
    {
        public const int Number_of_cycle = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("RACE AGAINST TIME");
            Console.WriteLine();

            Track trackexecute = new Track();
            Player trackrunner = new Player(trackexecute);

            trackrunner.StartTrack();

            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
