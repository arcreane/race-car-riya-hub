using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_race
{
    public enum CAR_PARTS
    {
        ENGINE,
        RIGHT_FRONT,
        LEFT_FRONT,
        RIGHT_REAR,
        LEFT_REAR,
        STEERING_WHEEL,
        BRAKES
    }

    public class Parts
    {
        public CAR_PARTS m_carparts;
        
        internal void ApplyEffect(Player p_player)
        {
            switch (m_carparts)
            {
                case CAR_PARTS.ENGINE:
                    break;
                case CAR_PARTS.RIGHT_FRONT:
                    break;
                case CAR_PARTS.LEFT_FRONT:
                    break;
                case CAR_PARTS.RIGHT_REAR:
                    break;
                case CAR_PARTS.LEFT_REAR:
                    break;
                case CAR_PARTS.STEERING_WHEEL:
                    break;
                case CAR_PARTS.BRAKES:
                    break;
                default:
                    break;
            }

        }
    }
}
