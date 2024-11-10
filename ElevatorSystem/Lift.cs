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
        public PictureBox doorLeftU;
        public Form1 form;
       

        public int topFloorY;
        public int groundFloorY;
        public Timer opentimer;
        public Timer closetimer;
        public Label Display;
        public Lift(Form1 form,PictureBox Elevator, Button btnUp, Button btnDown, int formSize, int liftSpeed,Timer LiftTime, PictureBox doorLeftU, int topFloorY, int groundFloorY, Timer OpenTimer, Timer CloseTimer, Label display)
        {
            this.form = form;
            this.Elevator = Elevator;
            this.btnUp = btnUp;
            this.btnDown = btnDown;
            this.formSize = formSize;
            this.liftSpeed = liftSpeed;
            this.LiftTime = LiftTime;
            this.doorLeftU = doorLeftU;
            this.topFloorY = topFloorY;
            this.groundFloorY = groundFloorY;
            this.opentimer = OpenTimer;
            this.closetimer = CloseTimer;
            this.Display = display;
         

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

        public void OpenGroundFloorDoors()
        {
            opentimer.Start(); // Opens the ground floor door
        }

        public void CloseGroundFloorDoors()
        {
            closetimer.Start(); // Closes the ground floor door
        }

        public void OpenTopFloorDoors()
        {
            opentimer.Start(); // Opens the top floor door
        }

        public void CloseTopFloorDoors()
        {
            closetimer.Start(); // Closes the top floor door
        }

    }
}
