using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSUIPC;


namespace FSUIPC_Link_JC1
{
    public partial class Form1 : Form
    {

        private Offset<short> trimInput = new Offset<short>(0x0BC0);
        private Offset<short> trimIndicator = new Offset<short>(0x0BC2);


        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 100;
            this.timer2.Interval = 50;
            this.trimRptTimerDown.Interval = 50;
            this.trimRptTimerUp.Interval = 50;


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (FSUIPCConnection.IsOpen)
            {
                timer1.Stop();
                FSUIPCConnection.Close();
                this.textBox1.Text = "Not Connected";
                this.btnConnect.Text = "Connect";
            }
            else
            {
                try
                {
                    FSUIPCConnection.Open();
                }
                catch (FSUIPCException ex)
                {
                    // Error occured so alert the user
                    MessageBox.Show("Connection Failed. " + ex.Message);
                }
                if(FSUIPCConnection.IsOpen)
                {
                    this.timer1.Start();
                    this.textBox1.Text = "Connected";
                    this.btnConnect.Text = "Disconnect";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            heartbeat();
            FSUIPCConnection.Process();

            vTrimIndicator.Value = trimIndicator.Value;
            vTrimInput.Value = trimInput.Value;




        }

        private void heartbeat()
        {
            this.rdoHearbeat.Checked = true;
            this.timer2.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            this.rdoHearbeat.Checked = false;
            this.timer2.Stop();
        }

        private void vTrimInput_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void vTrimInput_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTrimDown_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTrimUp_Click(object sender, EventArgs e)
        {
            

        }

        private void btnTrimDown_MouseDown(object sender, MouseEventArgs e)
        {
            if ((trimInput.Value - 100) > -16383)
            {
                trimInput.Value -= 100;
            }
            else trimInput.Value = -16383;

            trimRptTimerDown.Start();
        }

        private void trimRptTimerDown_Tick(object sender, EventArgs e)
        {
            if ((trimInput.Value - 100) > -16383)
            {
                trimInput.Value -= 100;
            }
            else trimInput.Value = -16383;
        }

        private void btnTrimDown_MouseUp(object sender, MouseEventArgs e)
        {
            trimRptTimerDown.Stop();
        }

        private void btnTrimDown_MouseLeave(object sender, EventArgs e)
        {
            trimRptTimerDown.Stop();
        }

        private void btnTrimUp_MouseDown(object sender, MouseEventArgs e)
        {
            if ((trimInput.Value + 100) < 16383)
            {
                trimInput.Value += 100;
            }
            else trimInput.Value = 16383;

            trimRptTimerUp.Start();
        }

        private void btnTrimUp_MouseUp(object sender, MouseEventArgs e)
        {
            trimRptTimerUp.Stop();
        }

        private void btnTrimUp_MouseLeave(object sender, EventArgs e)
        {
            trimRptTimerUp.Stop();
        }

        private void trimRptTimerUp_Tick(object sender, EventArgs e)
        {
            if ((trimInput.Value + 100) < 16383)
            {
                trimInput.Value += 100;
            }
            else trimInput.Value = 16383;
        }
    }
}
