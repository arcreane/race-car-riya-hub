using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_race
{
    public class Track
    {
        private Cycle1[] cycle1;
        

        public Track()
        {
            cycle1 = new Cycle1[Program.Number_of_cycle];
            for (int i = 0; i < Program.Number_of_cycle; i++)
            {
                cycle1[i] = new Cycle1(this, i); 
            }
        }

        public void Track1(Player p_player, int p_cyclenum)
        {
            p_player.ChooseCar();
            cycle1[p_cyclenum].Startcycle(p_player);
        }
    }
}
