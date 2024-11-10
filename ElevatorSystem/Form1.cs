using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class Form1 : Form
    {
        private readonly EmergencyAlarm _emergencyAlarm;
        bool isMovingUp = false;
        bool isMovingDown = false;
        int liftSpeed = 10;
        bool isClosing = false;
        bool isOpening = false;
        int doorSpeed = 10;
        private Lift lift;

        // private int maxLiftHeight = 100;

        int doorMaxOpenWidth;
        int doorMaxCLoseWidth;
        string alarmSoundPath = @"C:\Users\simkh\Downloads\mixkit-vintage-warning-alarm-990.wav";


        DataTable dt = new DataTable();
        DBContext db = new DBContext();
        public Form1()
        {
            InitializeComponent();
            btnLiftCallU.Click += btnLiftCallU_Click;
            btnLiftCallU.Click += btnLiftCallU_Click;
            //Elevator.Top =(this.ClientSize.Height-Elevator.Height);
            lift = new Lift(Elevator, btnUp, btnDown, this.ClientSize.Height, liftSpeed, LiftTime, doorTime, doorLeftU);
            doorMaxOpenWidth = Elevator.Width / 2 - 50;
            doorMaxCLoseWidth = Elevator.Width / 2;
            _emergencyAlarm = new EmergencyAlarm(alarmSoundPath);
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Events";

            dt.Columns.Add("LogTime");
            dt.Columns.Add("EventDescription");

        }
        private void dataEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");
            dt.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);
            db.InsertLogsIntoDB(dt);
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isClosing = false;
            doorTime.Start();
            btnClose.Enabled = false;
            dataEvents("Lift is opening...");
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            isOpening = false;
            isClosing = true;

            doorTime.Start();
            btnOpen.Enabled = false;
            dataEvents("Lift is closing...");
        }
        public void btnUp_Click(object sender, EventArgs e)
        {
            //isMovingUp = true;
            //isMovingDown = false;
            //lift.SetState(new MovingUpState());
            //lift.LiftTime.Start();
            //btnUp.Enabled = false;
            //dataEvents("Lift is going up");
            //btnColorU.BackColor = Color.Green;
            //btnColorD.BackColor = Color.Gray;

            if (isOpening)
            {
                isOpening = false;
                isClosing = true;
                doorTime.Start();
                btnOpen.Enabled = false;
                doorTime.Tick += onDoorC;
                dataEvents("Lift is going up");

            }
            else
            {
                MoveLiftUp();
            }

        }

        private void onDoorC(object sender, EventArgs e)
        {
            if (!isOpening && !isClosing)
            {
                MoveLiftUp();
                doorTime.Tick -= onDoorC;
            }
            else
            {
                MoveLiftUp();

            }
        }

        private void MoveLiftUp()
        {
            isMovingUp = true;
            isMovingDown = false;
            lift.SetState(new MovingUpState());
            lift.LiftTime.Start();
            btnUp.Enabled = true;

            btnColorU.BackColor = Color.Green;
            btnColorD.BackColor = Color.Gray;
        }

        public void btnDown_Click(object sender, EventArgs e)
        {
            // First, check if lift is already moving
            if (isMovingDown) return;

            // If doors are open at upper floor, close them first
            if (Elevator.Top == doorLeftU.Location.Y && doorLeftU.Left <= Elevator.Width + doorMaxCLoseWidth / 2 - 90)
            {
                // Clear any existing handlers
                doorTime.Tick -= OnUpperDoorsClosedDown;

                // Close the doors
                isOpening = false;
                isClosing = true;
                doorTime.Start();
                btnOpen.Enabled = false;
                btnClose.Enabled = false;

                // Add handler for door closing completion
                doorTime.Tick += OnUpperDoorsClosedDown;
                dataEvents("Closing upper doors before moving down");
            }
            else
            {
                // If doors are already closed or lift is at ground floor, start moving down
                MoveLiftDown();
            }
        }

        private void OnUpperDoorsClosedDown(object sender, EventArgs e)
        {
            if (!isClosing) return;

            if (doorLeftU.Left < Elevator.Width + doorMaxCLoseWidth / 2 - 90)
            {
                doorLeftU.Left += doorSpeed;
                doorRightU.Left -= doorSpeed;  // Changed from Right to Left
            }
            else
            {
                // Doors are fully closed
                doorTime.Stop();
                doorTime.Tick -= OnUpperDoorsClosedDown;
                isClosing = false;
                btnOpen.Enabled = true;

                MoveLiftDown();
            }
        }

        private void MoveLiftDown()
        {
            isMovingUp = false;
            isMovingDown = true;
            lift.SetState(new MovingDownState());
            lift.LiftTime.Start();
            btnDown.Enabled = false;
            btnColorU.BackColor = Color.Gray;
            btnColorD.BackColor = Color.Red;
            dataEvents("Lift is moving down");
        }
        public void lifttimer_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
            lift.MovingDown();
            
        }
        private void door_timer_Tick(object sender, EventArgs e)
        {
            if (Elevator.Top != doorLeftU.Location.Y)
            //if(Elevator.Top==(this.ClientSize.Height-Elevator.Height))
            {
                // When the elevator is not on the top floor
                if (isOpening)
                {
                    if (doorLeftG.Left > doorMaxOpenWidth + 20)
                    {
                        doorLeftG.Left -= doorSpeed;
                        doorRightG.Left += doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btnClose.Enabled = true;
                        btnOpen.Enabled = false;
                    }
                }
                if (isClosing)
                {
                    if (doorLeftG.Left < Elevator.Width + doorMaxOpenWidth / 2 - 60)  // Adjusted condition for closing
                    {
                        doorLeftG.Left += doorSpeed;
                        doorRightG.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btnOpen.Enabled = true;
                        //btnClose.Enabled = false;
                    }
                }
            }
            else //if(Elevator.Top==0)
            {
                // When the elevator is on the top floor
                if (isOpening)
                {
                    if (doorLeftU.Left > doorMaxOpenWidth + 40)
                    {
                        doorLeftU.Left -= doorSpeed;
                        doorRightU.Left += doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btnClose.Enabled = true;
                        btnOpen.Enabled = false;
                    }
                }
                if (isClosing)
                {
                    if (doorLeftU.Left < Elevator.Width + doorMaxCLoseWidth / 2 - 90)  // Adjusted condition for closing
                    {
                        doorLeftU.Left += doorSpeed;
                        doorRightU.Left -= doorSpeed;
                    }
                    else
                    {
                        doorTime.Stop();
                        btnOpen.Enabled = true;
                        //btnClose.Enabled = false;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.loadLogsFormDB(dt, dataGridView1);  // Ensure loadLogsFormDB exists in DBClass
        }

        private void btn_DeleteLog_Click(object sender, EventArgs e)
        {
            db.DeleteLogFromDB(dt);  // Ensure DeleteLogFromDB exists in DBClass
            dataGridView1.Rows.Clear();
        }

        //private void LiftStopTop()
        //{
        //    isOpening = true;
        //    isClosing = false;
        //    doorTime.Start();
        //    btnClose.Enabled = false;
        //    lift.MovingUp();
        //    if(isClosing)
        //    {
        //        isOpening = true;
        //        isClosing=false;
        //        doorTime.Start();
        //    }
        //}

        // Replace your existing btnLiftCallU_Click with this one
        private void btnLiftCallU_Click(object sender, EventArgs e)
        {
            if (!isMovingUp)
            {
                // Check if lift is at ground floor
                if (Elevator.Top == (this.ClientSize.Height - Elevator.Height))
                {
                    // Check if doors are open
                    if (doorLeftG.Left <= doorMaxOpenWidth + 20)
                    {
                        // Remove any existing event handlers first
                        doorTime.Tick -= OnGroundDoorsClosed;

                        isOpening = false;
                        isClosing = true;
                        doorTime.Start();
                        btnOpen.Enabled = false;
                        btnClose.Enabled = false;

                        // Add the event handler for door closing completion
                        doorTime.Tick += OnGroundDoorsClosed;
                        dataEvents("Ground floor doors closing before moving up");
                    }
                    else
                    {
                        // Doors are already closed, start moving up
                        StartUpwardMovement();
                    }
                }
                else
                {
                    StartUpwardMovement();
                }
            }
        }

        private void OnGroundDoorsClosed(object sender, EventArgs e)
        {
            if (isClosing)
            {
                if (doorLeftG.Left < Elevator.Width + doorMaxCLoseWidth / 2 - 60)
                {
                    doorLeftG.Left += doorSpeed;
                    doorRightG.Left -= doorSpeed;
                }
                else
                {
                    // Doors are fully closed
                    doorTime.Stop();
                    doorTime.Tick -= OnGroundDoorsClosed;
                    isClosing = false;
                    btnOpen.Enabled = true;

                    // Start moving up
                    StartUpwardMovement();
                    dataEvents("Ground floor doors closed, starting upward movement");
                }
            }
        }

        private void StartUpwardMovement()
        {
            // Remove any existing event handler first
            lift.LiftTime.Tick -= OnLiftReachedTop;

            isMovingUp = true;
            isMovingDown = false;
            lift.SetState(new MovingUpState());
            lift.LiftTime.Start();
            btnUp.Enabled = true;
            btnColorU.BackColor = Color.Green;
            btnColorD.BackColor = Color.Gray;

            // Add the event handler for reaching top floor
            lift.LiftTime.Tick += OnLiftReachedTop;
            dataEvents("Lift is moving up");
        }

        private void OnLiftReachedTop(object sender, EventArgs e)
        {
            if (Elevator.Top == doorLeftU.Location.Y)
            {
                lift.LiftTime.Stop();
                lift.LiftTime.Tick -= OnLiftReachedTop;

                // Remove any existing event handler first
                doorTime.Tick -= OnDoorOpenAtUpperFloor;

                isOpening = true;
                isClosing = false;
                doorTime.Start();
                btnClose.Enabled = false;

                // Add the event handler for door opening
                doorTime.Tick += OnDoorOpenAtUpperFloor;
                dataEvents("Lift arrived at upper floor, opening doors");
            }
        }

        private void OnDoorOpenAtUpperFloor(object sender, EventArgs e)
        {
            if (isOpening)
            {
                if (doorLeftU.Left > doorMaxOpenWidth + 40)
                {
                    doorLeftU.Left -= doorSpeed;
                    doorRightU.Left += doorSpeed;  // Changed from Right to Left
                }
                else
                {
                    doorTime.Stop();
                    doorTime.Tick -= OnDoorOpenAtUpperFloor;
                    isOpening = false;
                    btnClose.Enabled = true;
                    btnOpen.Enabled = false;
                    dataEvents("Upper floor doors fully opened");
                }
            }
        }

        private void btnCallLiftD_Click(object sender, EventArgs e)
        {
            // Check if the lift is not already moving down
            if (!isMovingDown)
            {
                // Check if the lift is at the upper floor
                if (Elevator.Top == doorLeftU.Location.Y)
                {
                    // If upper floor doors are open, close them first
                    if (doorLeftU.Left < Elevator.Width + doorMaxCLoseWidth / 2 - 90)
                    {
                        isOpening = false;
                        isClosing = true;
                        doorTime.Start();
                        btnOpen.Enabled = false;

                        // Add event handler to start downward movement after doors close
                        doorTime.Tick += OnUpperDoorsClosed;
                        dataEvents("Closing upper floor doors before moving down");
                        return;
                    }
                }

                // If doors are already closed, start moving down immediately
                StartDownwardMovement();
            }
        }

        private void OnUpperDoorsClosed(object sender, EventArgs e)
        {
            // Check if doors are fully closed
            if (doorLeftU.Left >= Elevator.Width + doorMaxCLoseWidth / 2 - 90)
            {
                doorTime.Stop();
                doorTime.Tick -= OnUpperDoorsClosed;
                isClosing = false;

                // Start moving down
                StartDownwardMovement();
            }
        }

        private void StartDownwardMovement()
        {
            // Set the lift to move down
            isMovingUp = false;
            isMovingDown = true;
            lift.SetState(new MovingDownState());
            lift.LiftTime.Start();
            btnDown.Enabled = false;
            btnColorU.BackColor = Color.Gray;
            btnColorD.BackColor = Color.Red;

            // Add event handler to open ground floor doors when lift arrives
            lift.LiftTime.Tick += OnLiftReachedGround;
            dataEvents("Lift is moving down");
        }

        private void OnLiftReachedGround(object sender, EventArgs e)
        {
            // Check if lift has reached ground floor
            if (Elevator.Top == (this.ClientSize.Height - Elevator.Height))
            {
                lift.LiftTime.Tick -= OnLiftReachedGround;

                // Open ground floor doors
                isOpening = true;
                isClosing = false;
                doorTime.Start();
                btnClose.Enabled = false;
                doorTime.Tick += OnDoorOpenAtGroundFloor;
                dataEvents("Lift arrived at ground floor, opening doors");
            }
        }

        private void OnDoorOpenAtGroundFloor(object sender, EventArgs e)
        {
            if (doorLeftG.Left > doorMaxOpenWidth + 20)
            {
                doorLeftG.Left -= doorSpeed;
                doorRightG.Left += doorSpeed;
            }
            else
            {
                doorTime.Stop();
                doorTime.Tick -= OnDoorOpenAtGroundFloor;
                btnClose.Enabled = true;
                btnOpen.Enabled = false;
                dataEvents("Ground floor doors opened");
            }
        }

        
        private void EmergencyAlarm_Click(object sender, EventArgs e)
        {
            if (!_emergencyAlarm.IsActive)
            {
                _emergencyAlarm.Activate();
                dataEvents("alaram is ringing");
            }
            else
            {
                _emergencyAlarm.Deactivate();
                dataEvents("alaram s");
            }

        }
    }
}