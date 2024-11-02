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
        public int formSize;
        public int liftSpeed;
        public Timer LiftTime;
        public Timer doorTime;
        public PictureBox doorLeftU;

        public Lift(PictureBox Elevator, Button btnUp, Button btnDown, int formSize, int liftSpeed,Timer LiftTime,Timer doorTime, PictureBox doorLeftU)
        {
            this.Elevator = Elevator;
            this.btnUp = btnUp;
            this.btnDown = btnDown;
            this.formSize = formSize;
            this.liftSpeed = liftSpeed;
            this.LiftTime = LiftTime;
            this.doorTime = doorTime;
            this.doorLeftU = doorLeftU;
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
