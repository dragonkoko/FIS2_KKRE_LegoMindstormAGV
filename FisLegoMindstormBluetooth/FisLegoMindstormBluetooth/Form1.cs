using EV3MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace FisLegoMindstormBluetooth
{
    public partial class Form1 : Form
    {

        EV3Messenger messenger;

        public Form1()
        {
            InitializeComponent();
            messenger = new EV3Messenger();
            fillSerialPortSelectedBoxWithAvailablePorts();
            updateFormGUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectedBoxWithAvailablePorts();
        }

        private void fillSerialPortSelectedBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            comPorts_listbox.Items.Clear();
            foreach (string port in ports)
            {
                comPorts_listbox.Items.Add(port);
            }
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            messenger.Disconnect();

            updateFormGUI();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (comPorts_listbox.SelectedIndex > -1)
            {
                string port = comPorts_listbox.SelectedItem.ToString().ToUpper();
                if (messenger.Connect(port))
                {
                    Thread newThread = new Thread(this.StatusChecker);
                    newThread.Start();
                    updateFormGUI();
                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'\n" + "make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("connect plox");
            }

        }

        private void StatusChecker()
        {
            while (true)
            {
                string newText = Convert.ToString(messenger.ReadMessage()); // running on worker thread
                this.Invoke((MethodInvoker)delegate
                {
                    if (newText.Contains("start")) { 
                        status_label.Text = "Running"; // runs on UI thread
                    } else if (newText.Contains("stop"))
                    {
                        status_label.Text = "Idle";
                    }
                });
                Thread.Sleep(10);
            }
        }

        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refresh_button.Enabled = false;
                connect_button.Enabled = false;

                disconnect_button.Enabled = true;
            }
            else
            {
                refresh_button.Enabled = true;
                connect_button.Enabled = true;

                disconnect_button.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "stop");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void startDriving_button_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("MESSAGE", "start");

        }
    }
}


