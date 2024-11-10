using ElevatorSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class MovingUpState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            /* Do Nothing */
        }

        public void MovingUp(Lift lift)
        {
            if (lift.Elevator.Top > lift.doorLeftU.Location.Y)
            {
                lift.Elevator.Top -= lift.liftSpeed;
            }
            else
            {
                // Once it reaches the top, transition to StoppedState
                lift.SetState(new IdleState());
                lift.Elevator.Top = lift.doorLeftU.Location.Y;
                lift.btnUp.BackColor = Color.White;
                lift.LiftTime.Stop();  // Stop the timer when it reaches the top

                lift.OpenTopFloorDoors();
                lift.Display.Text = "Arrived at Floor: 1";


                lift.btnDown.Enabled = true;  // Re-enable the G button
                lift.btnUp.Enabled = true;  // Enable other controls


            }
        }
    }
}
