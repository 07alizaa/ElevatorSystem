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
            lift = new Lift(this,Elevator, btnUp, btnDown, this.ClientSize.Height, liftSpeed, LiftTime,doorLeftU,0,0, OpenTimer, CloseTimer, display);
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
            OpenTimer.Start();
            btnClose.Enabled = false;
            dataEvents("Lift is opening...");
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            isOpening = false;
            isClosing = true;

            CloseTimer.Start();
           // btnOpen.Enabled = false;
            dataEvents("Lift is closing...");
        }
        public void btnUp_Click(object sender, EventArgs e)
        {
            
            lift.SetState(new MovingUpState());
            lift.LiftTime.Start();
            dataEvents("Lift is going up");
            display.Text = "Current Floor: 1";
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
            lift.SetState(new MovingDownState());
            lift.LiftTime.Start();
            dataEvents("Lift moving down");
            display.Text = "Current Floor: G";


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

        // method to open ground floor
        public void OpenGroundFloorDoor()
        {
            if (doorLeftG.Left > doorMaxOpenWidth + 20)
            {
                doorLeftG.Left -= doorSpeed;
                doorRightG.Left += doorSpeed;
            }
            else
            {
                OpenTimer.Stop();
                btnClose.Enabled = true;
                btnLiftCallU.Enabled = false;
                btnLiftCallD.Enabled = false;
                btnUp.Enabled = false;
                btnDown.Enabled = false;
            }
        }

        // method to close ground floor
        public void CloseGroundFloorDoor()
        {
            if (doorLeftG.Right < Elevator.Width + doorMaxOpenWidth)
            {
                doorLeftG.Left += doorSpeed;
                doorRightG.Left -= doorSpeed;
            }
            else
            {
                CloseTimer.Stop();
                btnLiftCallU.Enabled = true;
                btnLiftCallD.Enabled = true;
                btnUp.Enabled = true;
                btnDown.Enabled = true;
            }
        }

        public void OpenTopFloorDoors()
        {
            if (doorLeftU.Left > doorMaxOpenWidth + 40)
            {
                doorLeftU.Left -= doorSpeed;
                doorRightU.Left += doorSpeed;
            }
            else
            {
                OpenTimer.Stop();
                btnClose.Enabled = true;
                btnLiftCallU.Enabled = false;
                btnLiftCallD.Enabled = false;
                btnUp.Enabled = false;
                btnDown.Enabled = false;
            }
        }

        // Method to handle door closing for the top floor
        public void CloseTopFloorDoors()
        {
            if (doorLeftU.Right < Elevator.Width + doorMaxCLoseWidth / 3)
            {
                doorLeftU.Left += doorSpeed;
                doorRightU.Left -= doorSpeed;
            }
            else
            {
                CloseTimer.Stop();
                btnLiftCallU.Enabled = true;
                btnLiftCallD.Enabled = true;
                btnUp.Enabled = true;
                btnDown.Enabled = true;
                btnOpen.Enabled = true;
            }
        }
        //private void door_timer_Tick(object sender, EventArgs e)
        //{

        //    // ground floor
        //    if (Elevator.Top != doorLeftU.Location.Y)
            
        //    {
        //        // When the elevator is not on the top floor
        //        if (isOpening)
        //        {
        //            OpenGroundFloorDoor();
        //        }
        //        if (isClosing)
        //        {

        //            CloseGroundFloorDoor();
        //        }
        //    }

        //    //top floor
        //    else
        //    {
                
        //        if (isOpening)
        //        {

        //            OpenTopFloorDoors();
               
        //        }
        //        if (isClosing)
        //        {

        //            CloseTopFloorDoors();
                    
        //        }
        //    }
        //}

      

        private void Form1_Load(object sender, EventArgs e)
        {
            db.loadLogsFormDB(dt, dataGridView1);  // Ensure loadLogsFormDB exists in DBClass
        }

        private void btn_DeleteLog_Click(object sender, EventArgs e)
        {
            db.DeleteLogFromDB(dt);  // Ensure DeleteLogFromDB exists in DBClass
            dataGridView1.Rows.Clear();
        }

       

        private void btnCallLiftD_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingDownState());
            lift.LiftTime.Start();
            dataEvents("Lift moving down");
            display.Text = "Current Floor: G";
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

        private void btnLiftCallU_Click(object sender, EventArgs e)
        {
            lift.SetState(new MovingUpState());
            lift.LiftTime.Start();
            dataEvents("Lift is going up");
            display.Text = "Current Floor: 1";
        }

        private void OpenTimer_Tick(object sender, EventArgs e)
        {
            // Checks which floor the elevator is at and open the correct door
            if (Elevator.Top == doorLeftU.Location.Y) // Top floor
            {
                OpenTopFloorDoors();
               
            }
            else if (Elevator.Top != doorLeftU.Location.Y) // Ground floor
            {
                OpenGroundFloorDoor();
            }
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            // Checks which floor the elevator is at and close the correct door
            if (Elevator.Top == doorLeftU.Location.Y) // Top floor
            {
                CloseTopFloorDoors();
            }
            else if (Elevator.Top != doorLeftU.Location.Y) // Ground floor
            {
                CloseGroundFloorDoor();
            }
        }

    }
}