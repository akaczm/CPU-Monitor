using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using OpenHardwareMonitor.Hardware;
using System.Threading;

namespace CPU_Monitor
{
    public partial class sensorList2 : Form
    {

        SerialPort port = new SerialPort();
        ISensor sensor1;
        ISensor sensor2;
        IHardware hardware1;
        IHardware hardware2;
        AsusAura asusAura;
        Color GPUColor;
        Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true
        };
        int value1, value2;

        public sensorList2()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(Form1_Resize);
            Init();
            intervalBox.Items.Add(500);
            intervalBox.Items.Add(1000);
            intervalBox.Items.Add(1500);
            intervalBox.Items.Add(2000);
            intervalBox.Items.Add(5000);
        }

        private void Init()
        {
            c.Open();
            notifyIcon1.Visible = false;
            hardwareList.DataSource = c.Hardware;
            hardwareList.DisplayMember = "name";
            asusAura = new AsusAura();
            asusAura.Init();
            GPUColor = Color.FromArgb(0x78FF0000);
            try
            {
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.DataBits = 8;
                port.Handshake = Handshake.None;
                port.RtsEnable = true;
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    comPort.Items.Add(port);
                }
                port.BaudRate = 9600;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.PortName = comPort.Text;
                    port.Open();
                    timer1.Interval = Convert.ToInt32(intervalBox.Text);
                    if (timer1.Interval < 500)
                    {
                        timer1.Interval = 500;
                    }
                    timer1.Enabled = true;
                    connectButton.Text = "Disconnect";
                }
                else
                {
                    timer1.Enabled = false;
                    port.Write("DIS*");
                    port.Close();
                    connectButton.Text = "Connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void setIntervalBtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(intervalBox.Text);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void hardwareList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IHardware curItem = (IHardware)hardwareList.SelectedItem;

            sensorGridView.DataSource = curItem.Sensors;
        }

        private void setSensor1Btn_Click(object sender, EventArgs e)
        {
            hardware1 = (IHardware)hardwareList.SelectedItem;
            sensor1 = (ISensor) sensorGridView.SelectedRows[0].DataBoundItem;
            selSensor1Label.Text = sensor1.Name + sensor1.SensorType;
        }

        private void setSensor2Btn_Click(object sender, EventArgs e)
        {
            hardware2 = (IHardware)hardwareList.SelectedItem;
            sensor2 = (ISensor)sensorGridView.SelectedRows[0].DataBoundItem;
            selSensor2Label.Text = sensor2.Name + sensor2.SensorType;
        }

        private void openColorPicker_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.FullOpen = true;
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                GPUColor = colorDialog1.Color;
                asusAura.SetGPUColorRGB(GPUColor);
            }
        }

        private void auraValueM_CheckedChanged(object sender, EventArgs e)
        {
            asusAura.SetGPUColorRGB(GPUColor);
            asusAura.SetPulse(auraValueM.Checked);
        }

        private void Status()
        {
            string hard1 = "ERR";
            string hard2 = "ERR";
            foreach (var hardware in c.Hardware)
            {
                hardware.Update();
            }

            if (hardware1.HardwareType == HardwareType.GpuNvidia)
            {
                hard1 = "GPU";
            }
            else if (hardware1.HardwareType == HardwareType.CPU)
            {
                hard1 = "CPU";
            }
            if (hardware2.HardwareType == HardwareType.GpuNvidia)
            {
                hard2 = "GPU";
            }
            else if (hardware2.HardwareType == HardwareType.CPU)
            {
                hard2 = "CPU";
            }
            string type1 = sensor1.SensorType.ToString();
            string type2 = sensor2.SensorType.ToString();
            value1 = (int) sensor1.Value.GetValueOrDefault();
            value2 = (int) sensor2.Value.GetValueOrDefault();

            port.Write("ID1*" + hard1 + "*" + type1 + "*" + value1 + "*" + "ID2*" + hard2 + "*" + type2 + "*" + value2 + "*");
        }
    }
}