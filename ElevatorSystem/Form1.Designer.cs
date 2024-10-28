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
            this.doorTime = new System.Windows.Forms.Timer(this.components);
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(954, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(694, 463);
            this.dataGridView1.TabIndex = 10;
            // 
            // DeleteLog
            // 
            this.DeleteLog.BackColor = System.Drawing.Color.Firebrick;
            this.DeleteLog.Location = new System.Drawing.Point(954, 547);
            this.DeleteLog.Name = "DeleteLog";
            this.DeleteLog.Size = new System.Drawing.Size(135, 63);
            this.DeleteLog.TabIndex = 11;
            this.DeleteLog.Text = "ClearData";
            this.DeleteLog.UseVisualStyleBackColor = false;
            this.DeleteLog.Click += new System.EventHandler(this.btn_DeleteLog_Click);
            // 
            // doorTime
            // 
            this.doorTime.Tick += new System.EventHandler(this.door_timer_Tick);
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
            this.EmergencyAlarm.Location = new System.Drawing.Point(759, 547);
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
            this.btnClose.Location = new System.Drawing.Point(813, 448);
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
            this.btnOpen.Location = new System.Drawing.Point(679, 448);
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
            this.btnDown.Location = new System.Drawing.Point(742, 296);
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
            this.btnUp.Location = new System.Drawing.Point(742, 158);
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
            this.Elevator.Location = new System.Drawing.Point(185, 477);
            this.Elevator.Name = "Elevator";
            this.Elevator.Size = new System.Drawing.Size(279, 319);
            this.Elevator.TabIndex = 1;
            this.Elevator.TabStop = false;
            // 
            // liftPanel
            // 
            this.liftPanel.BackgroundImage = global::ElevatorSystem.Properties.Resources.Pannel1;
            this.liftPanel.Location = new System.Drawing.Point(663, 30);
            this.liftPanel.Name = "liftPanel";
            this.liftPanel.Size = new System.Drawing.Size(277, 733);
            this.liftPanel.TabIndex = 0;
            this.liftPanel.TabStop = false;
            // 
            // LogHistoryView
            // 
            this.LogHistoryView.AutoSize = true;
            this.LogHistoryView.BackColor = System.Drawing.Color.IndianRed;
            this.LogHistoryView.Font = new System.Drawing.Font("Britannic Bold", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogHistoryView.Location = new System.Drawing.Point(956, 30);
            this.LogHistoryView.Name = "LogHistoryView";
            this.LogHistoryView.Size = new System.Drawing.Size(230, 48);
            this.LogHistoryView.TabIndex = 15;
            this.LogHistoryView.Text = "Lift History";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(470, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(470, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1717, 832);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Text = "Form1";
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
        private System.Windows.Forms.Timer doorTime;
        private System.Windows.Forms.Button EmergencyAlarm;
        private System.Windows.Forms.Timer LiftTime;
        private System.Windows.Forms.Label LogHistoryView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

