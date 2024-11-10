namespace ElevatorSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteLog = new System.Windows.Forms.Button();
            this.LiftTime = new System.Windows.Forms.Timer(this.components);
            this.EmergencyAlarm = new System.Windows.Forms.Button();
            this.doorRightU = new System.Windows.Forms.PictureBox();
            this.doorLeftU = new System.Windows.Forms.PictureBox();
            this.doorRightG = new System.Windows.Forms.PictureBox();
            this.doorLeftG = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.Elevator = new System.Windows.Forms.PictureBox();
            this.liftPanel = new System.Windows.Forms.PictureBox();
            this.LogHistoryView = new System.Windows.Forms.Label();
            this.btnLiftCallD = new System.Windows.Forms.Button();
            this.btnLiftCallU = new System.Windows.Forms.Button();
            this.btnColorU = new System.Windows.Forms.Button();
            this.btnColorD = new System.Windows.Forms.Button();
            this.displayFloor = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Label();
            this.OpenTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(997, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(694, 458);
            this.dataGridView1.TabIndex = 10;
            // 
            // DeleteLog
            // 
            this.DeleteLog.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteLog.Location = new System.Drawing.Point(997, 527);
            this.DeleteLog.Name = "DeleteLog";
            this.DeleteLog.Size = new System.Drawing.Size(176, 63);
            this.DeleteLog.TabIndex = 11;
            this.DeleteLog.Text = "ClearData";
            this.DeleteLog.UseVisualStyleBackColor = false;
            this.DeleteLog.Click += new System.EventHandler(this.btn_DeleteLog_Click);
            // 
            // LiftTime
            // 
            this.LiftTime.Interval = 50;
            this.LiftTime.Tick += new System.EventHandler(this.lifttimer_Tick);
            // 
            // EmergencyAlarm
            // 
            this.EmergencyAlarm.BackgroundImage = global::ElevatorSystem.Properties.Resources.siren;
            this.EmergencyAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmergencyAlarm.Location = new System.Drawing.Point(759, 624);
            this.EmergencyAlarm.Name = "EmergencyAlarm";
            this.EmergencyAlarm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmergencyAlarm.Size = new System.Drawing.Size(80, 69);
            this.EmergencyAlarm.TabIndex = 14;
            this.EmergencyAlarm.UseVisualStyleBackColor = true;
            this.EmergencyAlarm.Click += new System.EventHandler(this.EmergencyAlarm_Click);
            // 
            // doorRightU
            // 
            this.doorRightU.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doorRightU.BackgroundImage = global::ElevatorSystem.Properties.Resources.Right;
            this.doorRightU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRightU.Location = new System.Drawing.Point(328, 47);
            this.doorRightU.Name = "doorRightU";
            this.doorRightU.Size = new System.Drawing.Size(136, 319);
            this.doorRightU.TabIndex = 9;
            this.doorRightU.TabStop = false;
            // 
            // doorLeftU
            // 
            this.doorLeftU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doorLeftU.BackgroundImage = global::ElevatorSystem.Properties.Resources.left;
            this.doorLeftU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeftU.Location = new System.Drawing.Point(185, 47);
            this.doorLeftU.Name = "doorLeftU";
            this.doorLeftU.Size = new System.Drawing.Size(150, 319);
            this.doorLeftU.TabIndex = 8;
            this.doorLeftU.TabStop = false;
            // 
            // doorRightG
            // 
            this.doorRightG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doorRightG.BackgroundImage = global::ElevatorSystem.Properties.Resources.Right;
            this.doorRightG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorRightG.Location = new System.Drawing.Point(328, 477);
            this.doorRightG.Name = "doorRightG";
            this.doorRightG.Size = new System.Drawing.Size(136, 319);
            this.doorRightG.TabIndex = 7;
            this.doorRightG.TabStop = false;
            // 
            // doorLeftG
            // 
            this.doorLeftG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.doorLeftG.BackgroundImage = global::ElevatorSystem.Properties.Resources.left1;
            this.doorLeftG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorLeftG.Location = new System.Drawing.Point(185, 477);
            this.doorLeftG.Name = "doorLeftG";
            this.doorLeftG.Size = new System.Drawing.Size(150, 319);
            this.doorLeftG.TabIndex = 6;
            this.doorLeftG.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.BackgroundImage = global::ElevatorSystem.Properties.Resources.Close_btn;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(815, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 70);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::ElevatorSystem.Properties.Resources.Open_btn;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(695, 520);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 70);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "\r\n";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.DimGray;
            this.btnDown.BackgroundImage = global::ElevatorSystem.Properties.Resources.Downbtn_removebg_preview;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(745, 401);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(112, 95);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.DimGray;
            this.btnUp.BackgroundImage = global::ElevatorSystem.Properties.Resources.UpButton_removebg_preview;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(745, 267);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(112, 99);
            this.btnUp.TabIndex = 2;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Elevator
            // 
            this.Elevator.BackgroundImage = global::ElevatorSystem.Properties.Resources.Elevator_room2;
            this.Elevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Elevator.Location = new System.Drawing.Point(185, 484);
            this.Elevator.Name = "Elevator";
            this.Elevator.Size = new System.Drawing.Size(279, 312);
            this.Elevator.TabIndex = 1;
            this.Elevator.TabStop = false;
            // 
            // liftPanel
            // 
            this.liftPanel.BackgroundImage = global::ElevatorSystem.Properties.Resources.Pannel1;
            this.liftPanel.Location = new System.Drawing.Point(671, 47);
            this.liftPanel.Name = "liftPanel";
            this.liftPanel.Size = new System.Drawing.Size(282, 733);
            this.liftPanel.TabIndex = 0;
            this.liftPanel.TabStop = false;
            // 
            // LogHistoryView
            // 
            this.LogHistoryView.AutoSize = true;
            this.LogHistoryView.BackColor = System.Drawing.Color.Gold;
            this.LogHistoryView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogHistoryView.Location = new System.Drawing.Point(1002, 30);
            this.LogHistoryView.Name = "LogHistoryView";
            this.LogHistoryView.Size = new System.Drawing.Size(251, 50);
            this.LogHistoryView.TabIndex = 15;
            this.LogHistoryView.Text = "Lift History";
            // 
            // btnLiftCallD
            // 
            this.btnLiftCallD.BackColor = System.Drawing.Color.DimGray;
            this.btnLiftCallD.BackgroundImage = global::ElevatorSystem.Properties.Resources.Downbtn_removebg_preview;
            this.btnLiftCallD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLiftCallD.Location = new System.Drawing.Point(520, 569);
            this.btnLiftCallD.Name = "btnLiftCallD";
            this.btnLiftCallD.Size = new System.Drawing.Size(58, 55);
            this.btnLiftCallD.TabIndex = 16;
            this.btnLiftCallD.UseVisualStyleBackColor = false;
            this.btnLiftCallD.Click += new System.EventHandler(this.btnCallLiftD_Click);
            // 
            // btnLiftCallU
            // 
            this.btnLiftCallU.BackColor = System.Drawing.Color.Gray;
            this.btnLiftCallU.BackgroundImage = global::ElevatorSystem.Properties.Resources.UpButton_removebg_preview;
            this.btnLiftCallU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLiftCallU.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLiftCallU.Location = new System.Drawing.Point(520, 224);
            this.btnLiftCallU.Name = "btnLiftCallU";
            this.btnLiftCallU.Size = new System.Drawing.Size(58, 56);
            this.btnLiftCallU.TabIndex = 17;
            this.btnLiftCallU.UseVisualStyleBackColor = false;
            this.btnLiftCallU.Click += new System.EventHandler(this.btnLiftCallU_Click);
            // 
            // btnColorU
            // 
            this.btnColorU.BackColor = System.Drawing.Color.Black;
            this.btnColorU.Location = new System.Drawing.Point(293, 30);
            this.btnColorU.Name = "btnColorU";
            this.btnColorU.Size = new System.Drawing.Size(76, 19);
            this.btnColorU.TabIndex = 18;
            this.btnColorU.UseVisualStyleBackColor = false;
            // 
            // btnColorD
            // 
            this.btnColorD.BackColor = System.Drawing.Color.Black;
            this.btnColorD.Location = new System.Drawing.Point(293, 459);
            this.btnColorD.Name = "btnColorD";
            this.btnColorD.Size = new System.Drawing.Size(76, 19);
            this.btnColorD.TabIndex = 19;
            this.btnColorD.UseVisualStyleBackColor = false;
            // 
            // displayFloor
            // 
            this.displayFloor.AutoSize = true;
            this.displayFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFloor.Location = new System.Drawing.Point(709, 99);
            this.displayFloor.Name = "displayFloor";
            this.displayFloor.Size = new System.Drawing.Size(0, 79);
            this.displayFloor.TabIndex = 20;
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(584, 99);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(305, 50);
            this.display.TabIndex = 21;
            this.display.Text = "Current Floor";
            // 
            // OpenTimer
            // 
            this.OpenTimer.Tick += new System.EventHandler(this.OpenTimer_Tick);
            // 
            // CloseTimer
            // 
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1828, 827);
            this.Controls.Add(this.display);
            this.Controls.Add(this.displayFloor);
            this.Controls.Add(this.btnColorD);
            this.Controls.Add(this.btnColorU);
            this.Controls.Add(this.btnLiftCallU);
            this.Controls.Add(this.btnLiftCallD);
            this.Controls.Add(this.LogHistoryView);
            this.Controls.Add(this.EmergencyAlarm);
            this.Controls.Add(this.DeleteLog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doorRightU);
            this.Controls.Add(this.doorLeftU);
            this.Controls.Add(this.doorRightG);
            this.Controls.Add(this.doorLeftG);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.Elevator);
            this.Controls.Add(this.liftPanel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorRightG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorLeftG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox liftPanel;
        private System.Windows.Forms.PictureBox Elevator;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox doorLeftG;
        private System.Windows.Forms.PictureBox doorRightG;
        private System.Windows.Forms.PictureBox doorLeftU;
        private System.Windows.Forms.PictureBox doorRightU;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteLog;
        private System.Windows.Forms.Button EmergencyAlarm;
        private System.Windows.Forms.Timer LiftTime;
        private System.Windows.Forms.Label LogHistoryView;
        private System.Windows.Forms.Button btnLiftCallD;
        private System.Windows.Forms.Button btnLiftCallU;
        private System.Windows.Forms.Button btnColorU;
        private System.Windows.Forms.Button btnColorD;
        private System.Windows.Forms.Label displayFloor;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Timer OpenTimer;
        private System.Windows.Forms.Timer CloseTimer;
    }
}

