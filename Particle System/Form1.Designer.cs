namespace Particle_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblDirectionValue = new System.Windows.Forms.Label();
            this.lblSpreadingValue = new System.Windows.Forms.Label();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.lblLifeValue = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.tbLife = new System.Windows.Forms.TrackBar();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lblRadiusPortalValue = new System.Windows.Forms.Label();
            this.lblRadiusPortal = new System.Windows.Forms.Label();
            this.tbRadiusPortal = new System.Windows.Forms.TrackBar();
            this.lblDirectionPortalValue = new System.Windows.Forms.Label();
            this.lblDirectionPortal = new System.Windows.Forms.Label();
            this.tbDirectionPortal = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadiusPortal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirectionPortal)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(700, 400);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(718, 33);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(171, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDirection.Scroll += new System.EventHandler(this.TbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(718, 12);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(81, 15);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "Направление";
            // 
            // lblDirectionValue
            // 
            this.lblDirectionValue.AutoSize = true;
            this.lblDirectionValue.Location = new System.Drawing.Point(860, 12);
            this.lblDirectionValue.Name = "lblDirectionValue";
            this.lblDirectionValue.Size = new System.Drawing.Size(0, 15);
            this.lblDirectionValue.TabIndex = 3;
            // 
            // lblSpreadingValue
            // 
            this.lblSpreadingValue.AutoSize = true;
            this.lblSpreadingValue.Location = new System.Drawing.Point(860, 63);
            this.lblSpreadingValue.Name = "lblSpreadingValue";
            this.lblSpreadingValue.Size = new System.Drawing.Size(0, 15);
            this.lblSpreadingValue.TabIndex = 6;
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(718, 63);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(52, 15);
            this.lblSpreading.TabIndex = 5;
            this.lblSpreading.Text = "Разброс";
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(718, 84);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(171, 45);
            this.tbSpreading.TabIndex = 4;
            this.tbSpreading.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSpreading.Scroll += new System.EventHandler(this.TbSpreading_Scroll);
            // 
            // lblLifeValue
            // 
            this.lblLifeValue.AutoSize = true;
            this.lblLifeValue.Location = new System.Drawing.Point(860, 165);
            this.lblLifeValue.Name = "lblLifeValue";
            this.lblLifeValue.Size = new System.Drawing.Size(0, 15);
            this.lblLifeValue.TabIndex = 12;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(718, 165);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(80, 15);
            this.lblLife.TabIndex = 11;
            this.lblLife.Text = "Время жизни";
            // 
            // tbLife
            // 
            this.tbLife.Location = new System.Drawing.Point(718, 186);
            this.tbLife.Maximum = 160;
            this.tbLife.Minimum = 40;
            this.tbLife.Name = "tbLife";
            this.tbLife.Size = new System.Drawing.Size(171, 45);
            this.tbLife.TabIndex = 10;
            this.tbLife.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbLife.Value = 40;
            this.tbLife.Scroll += new System.EventHandler(this.TbLife_Scroll);
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Location = new System.Drawing.Point(860, 114);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(0, 15);
            this.lblSpeedValue.TabIndex = 9;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(718, 114);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(59, 15);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Скорость";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(718, 135);
            this.tbSpeed.Maximum = 50;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(171, 45);
            this.tbSpeed.TabIndex = 7;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.TbSpeed_Scroll);
            // 
            // lblRadiusPortalValue
            // 
            this.lblRadiusPortalValue.AutoSize = true;
            this.lblRadiusPortalValue.Location = new System.Drawing.Point(860, 216);
            this.lblRadiusPortalValue.Name = "lblRadiusPortalValue";
            this.lblRadiusPortalValue.Size = new System.Drawing.Size(0, 15);
            this.lblRadiusPortalValue.TabIndex = 18;
            // 
            // lblRadiusPortal
            // 
            this.lblRadiusPortal.AutoSize = true;
            this.lblRadiusPortal.Location = new System.Drawing.Point(718, 216);
            this.lblRadiusPortal.Name = "lblRadiusPortal";
            this.lblRadiusPortal.Size = new System.Drawing.Size(93, 15);
            this.lblRadiusPortal.TabIndex = 17;
            this.lblRadiusPortal.Text = "Радиус портала";
            // 
            // tbRadiusPortal
            // 
            this.tbRadiusPortal.Location = new System.Drawing.Point(718, 237);
            this.tbRadiusPortal.Maximum = 80;
            this.tbRadiusPortal.Minimum = 20;
            this.tbRadiusPortal.Name = "tbRadiusPortal";
            this.tbRadiusPortal.Size = new System.Drawing.Size(171, 45);
            this.tbRadiusPortal.TabIndex = 16;
            this.tbRadiusPortal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRadiusPortal.Value = 20;
            this.tbRadiusPortal.Scroll += new System.EventHandler(this.TbRadiusPortal_Scroll);
            // 
            // lblDirectionPortalValue
            // 
            this.lblDirectionPortalValue.AutoSize = true;
            this.lblDirectionPortalValue.Location = new System.Drawing.Point(860, 267);
            this.lblDirectionPortalValue.Name = "lblDirectionPortalValue";
            this.lblDirectionPortalValue.Size = new System.Drawing.Size(0, 15);
            this.lblDirectionPortalValue.TabIndex = 22;
            // 
            // lblDirectionPortal
            // 
            this.lblDirectionPortal.AutoSize = true;
            this.lblDirectionPortal.Location = new System.Drawing.Point(718, 267);
            this.lblDirectionPortal.Name = "lblDirectionPortal";
            this.lblDirectionPortal.Size = new System.Drawing.Size(129, 15);
            this.lblDirectionPortal.TabIndex = 21;
            this.lblDirectionPortal.Text = "Направление портала";
            // 
            // tbDirectionPortal
            // 
            this.tbDirectionPortal.Location = new System.Drawing.Point(718, 288);
            this.tbDirectionPortal.Maximum = 359;
            this.tbDirectionPortal.Name = "tbDirectionPortal";
            this.tbDirectionPortal.Size = new System.Drawing.Size(171, 45);
            this.tbDirectionPortal.TabIndex = 20;
            this.tbDirectionPortal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDirectionPortal.Value = 20;
            this.tbDirectionPortal.Scroll += new System.EventHandler(this.TbDirectionPortal_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 424);
            this.Controls.Add(this.lblDirectionPortalValue);
            this.Controls.Add(this.lblDirectionPortal);
            this.Controls.Add(this.tbDirectionPortal);
            this.Controls.Add(this.lblRadiusPortalValue);
            this.Controls.Add(this.lblRadiusPortal);
            this.Controls.Add(this.tbRadiusPortal);
            this.Controls.Add(this.lblLifeValue);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.tbLife);
            this.Controls.Add(this.lblSpeedValue);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lblSpreadingValue);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lblDirectionValue);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Система частиц";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRadiusPortal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirectionPortal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblDirectionValue;
        private System.Windows.Forms.Label lblSpreadingValue;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label lblLifeValue;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.TrackBar tbLife;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lblRadiusPortalValue;
        private System.Windows.Forms.Label lblRadiusPortal;
        private System.Windows.Forms.TrackBar tbRadiusPortal;
        private System.Windows.Forms.Label lblDirectionPortalValue;
        private System.Windows.Forms.Label lblDirectionPortal;
        private System.Windows.Forms.TrackBar tbDirectionPortal;
    }
}
