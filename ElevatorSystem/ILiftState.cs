using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal interface ILiftState
    {
        void MovingUp(Lift lift);
        void MovingDown(Lift lift);
    }
}
