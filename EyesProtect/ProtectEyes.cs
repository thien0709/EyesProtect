using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyesProtect
{
    public partial class ProtectEyes : Form
    {
        private int countDown = 5;
        private int timeClose = 2;
        private int loopTimer = 20*60;
        public ProtectEyes()
        {
            InitializeComponent();
            breakTime.Start();
        }

        private void breakTime_Tick(object sender, EventArgs e)
        {
            countDown--;
            countdownTime.Text = countDown.ToString();

            if (countDown == 0)
            {
                this.BackColor = Color.FromArgb(239, 149, 149);
                tittle.Text = "Keep Going";
                breakTime.Stop();
                timeClose = 2;
                timerClose.Start();
            }
           
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            timeClose--;
            if(timeClose == 0)
            {
                this.Visible =false;
                loopTimer = 20*60;
                loopTime.Start();
            }

        }

        private void loopTime_Tick(object sender, EventArgs e)
        {
            loopTimer--;
            if(loopTimer == 0)
            {
                this.Visible = true;
                countDown = 25;
                this.BackColor = Color.FromArgb(242, 239, 229);
                tittle.Text = "Rest Your Eyes";
                countdownTime.Text = "25";
                breakTime.Start();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.Q)
            {
                this.Close();
            }
        }
    }
}
