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
            //isMovingUp = false;
            //isMovingDown = true;
            //lift.SetState(new MovingDownState());
            //lift.LiftTime.Start();
            //btnDown.Enabled = false;
            //dataEvents("Lift is going down");
            //btnColorU.BackColor = Color.Gray; 
            //btnColorD.BackColor = Color.Red;
            if (isOpening)
            {
                isOpening = false;
                isClosing = true;
                doorTime.Start();
                btnOpen.Enabled = false;
                doorTime.Tick += onDoorC;
                dataEvents("Lift is going down");

            }
            else
            {
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
        }
        public void lifttimer_Tick(object sender, EventArgs e)
        {
            lift.MovingUp();
            lift.MovingDown();
            //LiftStopTop();
            //if (isMovingUp)
            //{
            //    btnDown.BackColor = Color.LightBlue;
            //    if (Elevator.Top > 0)
            //    {
            //        Elevator.Top -= liftSpeed;
            //    }
            //    else
            //    {
            //        LiftTime.Stop();
            //        Elevator.Top = 0;
            //        btnUp.Enabled = true;
            //    }
            //}
            //if (isMovingDown)
            //{
            //    btnDown.BackColor = Color.Gray;
            //    btnUp.BackColor = Color.LightGreen;
            //    if (Elevator.Bottom < this.ClientSize.Height)
            //    {
            //        Elevator.Top += liftSpeed;
            //    }
            //    else
            //    {
            //        LiftTime.Stop();
            //        btnDown.Enabled = true;
            //    }
            //}
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