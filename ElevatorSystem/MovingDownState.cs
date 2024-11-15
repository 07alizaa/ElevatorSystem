﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class MovingDownState : ILiftState
    {
        public void MovingDown(Lift lift)
        {
            if (lift.Elevator.Top == 0 || lift.Elevator.Bottom < lift.formSize)
            {
                lift.Elevator.Top += lift.liftSpeed + 10;
            }
            else
            {
                // Once it reaches the bottom, transition to StoppedState
                lift.SetState(new IdleState());
                lift.Elevator.Top = lift.formSize - lift.Elevator.Height;
                lift.btnUp.BackColor = Color.White;
                lift.LiftTime.Stop();  // Stop the timer when it reaches the bottom

                lift.OpenGroundFloorDoors();
                lift.Display.Text = "Arrived at Floor: G";

                lift.btnUp.Enabled = true;  // Re-enable the 1st floor button
                lift.btnDown.Enabled = true;  // Enable other controls
            }
        }

        public void MovingUp(Lift lift)
        {
            /* Do Nothing */
        }
    }
}