using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_race
{
    public class Cycle1
    {
        private Player m_player;
        private Fastcar m_fastcar;
        private int m_time;
        private Track m_track;

        public Cycle1(Track p_track, int p_time)
        {
            m_time = p_time;
            m_track = p_track;
        }

        public Cycle1(Track p_track, int p_time, Player p_player)
         : this(p_track, p_time)
        {
            m_player = p_player;
        }

        virtual public void Startcycle(Player p_player)
        {
            Console.WriteLine("The Race begins now...");
            Console.WriteLine();
            m_time = 60;
            
            for (int i = 0; i < m_time; i++)
            {
                Console.WriteLine("Time : " + i + " seconds");
                Console.WriteLine();
            }
            m_player.Distance(m_fastcar);
        }

        public void Timecalc(Fastcar p_fastcar)
        {
            m_fastcar = p_fastcar;
            
        }
        

    }

}
