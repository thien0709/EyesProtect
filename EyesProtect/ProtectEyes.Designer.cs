
namespace EyesProtect
{
    partial class ProtectEyes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtectEyes));
            this.countdownTime = new System.Windows.Forms.Label();
            this.breakTime = new System.Windows.Forms.Timer(this.components);
            this.tittle = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.loopTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countdownTime
            // 
            this.countdownTime.Font = new System.Drawing.Font("JetBrainsMono NF", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.countdownTime.Location = new System.Drawing.Point(320, 268);
            this.countdownTime.Name = "countdownTime";
            this.countdownTime.Size = new System.Drawing.Size(188, 78);
            this.countdownTime.TabIndex = 0;
            this.countdownTime.Text = "5";
            this.countdownTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breakTime
            // 
            this.breakTime.Interval = 1000;
            this.breakTime.Tick += new System.EventHandler(this.breakTime_Tick);
            // 
            // tittle
            // 
            this.tittle.Font = new System.Drawing.Font("JetBrainsMono NF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.tittle.Location = new System.Drawing.Point(81, 60);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(667, 146);
            this.tittle.TabIndex = 1;
            this.tittle.Text = "Finish What You Start";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // loopTime
            // 
            this.loopTime.Interval = 1000;
            this.loopTime.Tick += new System.EventHandler(this.loopTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrainsMono NF", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ctrl + Shift + Q : Close";
            // 
            // ProtectEyes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(229)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.countdownTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProtectEyes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countdownTime;
        private System.Windows.Forms.Timer breakTime;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Timer loopTime;
        private System.Windows.Forms.Label label1;
    }
}

