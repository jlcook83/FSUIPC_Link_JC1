using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSUIPC;
using SerialPortLib;


namespace FSUIPC_Link_JC1
{
    public partial class Form1 : Form
    {

        private Offset<short> trimInput = new Offset<short>(0x0BC0);
        private Offset<short> trimIndicator = new Offset<short>(0x0BC2);

        SerialPortInput serialPort = new SerialPortInput();
        string[] portNames;

        byte[] bufferIn = new byte[100];
        string varIn, valIn;

        private delegate void SetTextDeleg(string text);
        private void si_DataReceived(string data) { textBoxDataIn.Text = data.Trim(); }

        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 100;
            this.timer2.Interval = 50;
            this.trimRptTimerDown.Interval = 50;
            this.trimRptTimerUp.Interval = 50;

            portNames = SerialPort.GetPortNames();

            foreach (string port in portNames)
            {
                listComPorts.Items.Add(port);
            }

            serialPort.ConnectionStatusChanged += delegate (object sender, ConnectionStatusChangedEventArgs args)
            {
                Console.WriteLine("Connected = {0}", args.Connected);
                textBox1.Text = "Connected = " + args.Connected.ToString();
            };



            //     _____           _       __   ____    
            //    / ___/___  _____(_)___ _/ /  /  _/___ 
            //    \__ \/ _ \/ ___/ / __ `/ /   / // __ \
            //   ___/ /  __/ /  / / /_/ / /  _/ // / / /
            //  /____/\___/_/  /_/\__,_/_/  /___/_/ /_/ 
            //  =======================================                                        
            // Serial message recieved 
            //
            serialPort.MessageReceived += delegate (object sender, MessageReceivedEventArgs args)
            {
                // Debugging
                Console.WriteLine("Received message: {0}\n Length: {1}", BitConverter.ToString(args.Data),args.Data.Length);

                // Storing recieved bytes into input buffer
                int i;
                for(i = 0; i < args.Data.Length; i++)
                {
                    bufferIn[i] = args.Data[i];
                    Console.Write(bufferIn[i]);
                }
                bufferIn[i + 1] = (byte)'\n';
                Console.WriteLine();

                // simple protocol    >[VariableName],[Value];  example: >trim,-50;
                if (bufferIn[0] == '>')
                {
                    Console.WriteLine("Start recieved");

                    char[] buffVar = new char[50];
                    char[] buffVal = new char[50];

                    // get var name
                    int j;
                    for (j = 0; j <= i; j++)
                    {
                        //Console.WriteLine(bufferIn[j + 1]);
                        if (bufferIn[j+1] != (byte)',')
                        {
                            buffVar[j] = (char)bufferIn[j + 1];
                            Console.Write(buffVar[j]);
                        }
                        else break;
                    }
                    //buffVar[j + 1] = '\0';
                    Console.WriteLine();

                    // get value
                    int k;
                    for (k = j+1; k < i; k++)
                    {
                        if (bufferIn[k + 1] != (byte)';')
                        {
                            buffVal[k-1-j] = (char)bufferIn[k+1];
                            Console.Write(buffVal[k-j-1]);
                        }
                        else break;
                    }
                    //buffVal[k - j] = '\0';
                    Console.WriteLine();


                    varIn =  new string(buffVar);
                    valIn =  new string(buffVal);

                    // Debugging and deligate testing
                    string data = varIn;

                    // Can't send to UI thread directly from this non-UI thread, so using deligate magic here
                    // Used for more debugging - messages sent to text box in delegate
                    this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });



                    if(varIn.Contains("Trim_Position"))
                    {
                        Console.WriteLine("Rcv Trim");
                        try
                        {
                            Int16 _val = Convert.ToInt16(valIn);
                            if (_val > 16383) _val = 16383;
                            if (_val < -16383) _val = -16383;
                            trimInput.Value = _val;
                        }
                        catch { }
                    }
                    





                }

                






                
            };


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
                if (FSUIPCConnection.IsOpen)
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

        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            serialPort.SetPort(listComPorts.SelectedItem.ToString(), 115200);
            serialPort.Connect();
        }


    }
}
