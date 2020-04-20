using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_race
{
  
    public class Fastcar
    {
        
        int speedf = 28;
        int total_distance;

        public void StartMoving()
        {
            total_distance = speedf * 60;
            Console.WriteLine("The distance travelled by fast car in 1 minute: " + total_distance + " metres ");
            
        }
    }

}

