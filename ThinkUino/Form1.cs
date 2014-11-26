using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinkGearNET;
using System.Threading;
using System.IO;
using System.Net.Sockets;

namespace ThinkUino
{
    public partial class Form1 : Form
    {

        string ip = "192.168.43.63";
        bool check = false;

        private ThinkGearWrapper thinkGearWrapper = new ThinkGearWrapper(); //declare the thinkgear object
       


        private const string MINDPORT = "COM6"; //declare the Mindwave serial port

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHeadsetConnect_Click(object sender, EventArgs e)
        {
            if (thinkGearWrapper.Connect(MINDPORT, 57600, true)) //check if the Mindwave is connected
            {
                btnHeadsetConnect.Enabled = false; //disable connect button
                btnHeadsetDisconnect.Enabled = true; //enable disconnect button
                txtHeadsetDebug.AppendText("Headset connected." + Environment.NewLine);
                thinkGearWrapper.EnableBlinkDetection(true); //enable the eye blink on the eSense protocol
                thinkGearWrapper.ThinkGearChanged += new EventHandler<ThinkGearChangedEventArgs>(thinkGearWrapper_ThinkGearChanged); //capture the event when a new data is incoming
            }
            else
                txtHeadsetDebug.AppendText("Could not connect to headset" + Environment.NewLine);
        }

        void thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {


            BeginInvoke(new MethodInvoker(delegate //use the AsyncTask to update the UI
                {


                    if ((thinkGearWrapper.ThinkGearState.BlinkStrength > 30)) // check if the eye blink strength is above 30
                    {

                        txtHeadsetDebug.AppendText(System.Environment.NewLine + thinkGearWrapper.ThinkGearState.BlinkStrength.ToString());


                        if ((thinkGearWrapper.ThinkGearState.BlinkStrength > 60)) // check if the eye blink strength is above 60
                        {


                            sendBlink(thinkGearWrapper.ThinkGearState.BlinkStrength.ToString());


                            thinkGearWrapper.ThinkGearState.BlinkStrength = 0;//set the eye blink strength to zero
                        }
                    }

                    if (thinkGearWrapper.ThinkGearState.Attention > 30)//check if the Attention state is above 60
                    {
                        txtHeadsetDebug.AppendText(System.Environment.NewLine + thinkGearWrapper.ThinkGearState.Attention.ToString());

                        if (thinkGearWrapper.ThinkGearState.Attention > 60)//check if the Attention state is above 60
                        {

                            thinkGearWrapper.ThinkGearState.Attention = 0; //set the attention state to zero
                        }
                    }
                    lblAttention.Text = "Attention: " + thinkGearWrapper.ThinkGearState.Attention;
                    lblMeditation.Text = "Meditation: " + thinkGearWrapper.ThinkGearState.Meditation;
                }));
            Thread.Sleep(10); //wait ten milliseconds
        }

        private void btnHeadsetDisconnect_Click(object sender, EventArgs e)
        {

            thinkGearWrapper.Disconnect(); //close the headset connection
            txtHeadsetDebug.AppendText("Disconnected." + Environment.NewLine);
            btnHeadsetDisconnect.Enabled = false; //disable the headset disconnect button
            btnHeadsetConnect.Enabled = true; //enable the headset connect button
        }




        private void sendBlink(string blinkValue)
        {


            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect(ip, 7777);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
               
                String str = "";
                if (check)
                {
                    check = false;
                    str = "on";

                }
                else
                {
                    check = true;
                    str = "off";

                }


                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(bb[i]));

                tcpclnt.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendBlink(blink.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect(ip, 7777);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
              

                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes("close");
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(bb[i]));

                tcpclnt.Close();
            }

            catch (Exception ee)
            {
                Console.WriteLine("Error..... " + ee.StackTrace);
            }

        }

    }
}
