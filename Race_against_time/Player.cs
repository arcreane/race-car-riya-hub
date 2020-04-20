using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_race
{
    public class Player
    {
        private Track m_track1;
        
        private Fastcar m_fastcar;
        
        bool type_car = true;

        public Player(Track p_track1, Fastcar p_fastcar)
        {
            m_track1 = p_track1;
            m_fastcar = p_fastcar;
        }

        public Player(Track trackexecute)
        {
        }

        public void StartTrack()
        {
            m_track1.Track1(this, 0);
        }

        public void ChooseCar()
        {
            while (type_car)
            {
                Console.WriteLine("Choose the Car type: (Fastcar/Slowcar) ");
                Console.WriteLine();
                String Confirmed = Console.ReadLine();

                if (Confirmed.ToString() == "fastcar")
                {
                    Console.WriteLine();
                    Console.WriteLine("Game has started with Fastcar");
                    type_car = true;
                    Confirmed = Console.ReadLine();

                }
                else if (Confirmed.ToString() == "slowcar")
                {
                    Console.WriteLine();
                    Console.WriteLine("Game has started with Slowcar");
                    type_car = true;
                    Confirmed = Console.ReadLine();
                }
                else
                    Console.WriteLine("Please choose a car to begin the race.");
                type_car = false;
                Console.ReadLine();
            }
        }

            public void Distance(Fastcar p_fastcar)
            {
            m_fastcar.StartMoving();
            }
        



    }
}
