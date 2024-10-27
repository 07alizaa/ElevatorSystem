using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    internal class Lift
    {
        public ILiftState _CurrentState;

        public PictureBox Elevator;
        public Button btnUp;
        public Button btnDown;
        public int FormSize;
        public int LiftSpeed;
        public Timer LiftTimerUp;
        public Timer LiftTimerDown;

        public Lift(PictureBox Elevator, Button btn_1, Button btn_G, int formSize, int liftSpeed, Timer liftTimerUp, Timer liftTimerDown)
        {
            Elevator = Elevator;
            btnUp = btn_1;
            btnDown = btn_G;
            FormSize = formSize;
            LiftSpeed = liftSpeed;
            LiftTimerUp = liftTimerUp;
            LiftTimerDown = liftTimerDown;
            _CurrentState = new IdleState();
        }

        public void SetState(ILiftState state)
        {
            _CurrentState = state;
        }

        public void MovingUp()
        {
            _CurrentState.MovingUp(this);
        }

        public void MovingDown()
        {
            _CurrentState.MovingDown(this);
        }


    }
}
