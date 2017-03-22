using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaponics
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        bool _connected = false;

        private delegate void RecvDeleg(string text);

        string data;
        string[] res_s;
        float[] res;

        int err_count = 0;
        int max_err_count = 3;

        bool work = true;

        public Form1()
        {
            InitializeComponent();

            scan();
        }
        
        private void scan()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portBox.Items.Add(port);
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                try
                {
                    _serialPort = new SerialPort(portBox.SelectedItem.ToString(),
                                                9600,
                                                Parity.None,
                                                8,
                                                StopBits.One);
                    _serialPort.Handshake = Handshake.None;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                    _serialPort.Open();
                    _serialPort.WriteLine("<!>");
                }
                catch (Exception err)
                {
                    _connected = false;
                    disp("Error while connecting");

                    connect_btn.Image = Properties.Resources.power_plug_off;
                    return;
                }
                _connected = true;
                setStatus("Controller connected");

                connect_btn.Image = Properties.Resources.power_plug;
                return;
            }
            else
            {
                try
                {
                    _serialPort.Close();
                }
                catch (Exception err)
                {
                    disp("Error while disconnecting");
                    connect_btn.Image = Properties.Resources.power_plug_off;
                    return;
                }
                _connected = false;
                setStatus("Controller disconnected. IDLE");

                connect_btn.Image = Properties.Resources.power_plug_off;
                return;
            }
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            delay(10);
            string data = _serialPort.ReadLine();
            this.BeginInvoke(new RecvDeleg(si_DataReceived),
                             new object[] { data });
        }

        private void si_DataReceived(string input)
        {
            try
            {
                if (input.Length > 0)
                {
                    setStatus("Connection OK. Reading data packs.");

                    input = input.Substring(1, input.Length - 4);
                    res_s = input.Split('#');

                    PH_L.Text = res_s[0];
                    OPR_L.Text = res_s[1];
                    DO_L.Text = res_s[2];
                    CO_L.Text = res_s[3];
                    RTD_L.Text = res_s[4];

                    if (DO_ch.Series[0].Points.Count > 30)
                    {
                        DO_ch.Series[0].Points.RemoveAt(0);
                    }
                    DO_ch.Series[0].Points.Add(Double.Parse(res_s[2]));


                    if (CO_ch.Series[0].Points.Count > 30)
                    {
                        CO_ch.Series[0].Points.RemoveAt(0);
                    }
                    CO_ch.Series[0].Points.Add(Double.Parse(res_s[3]));


                    if (PH_ch.Series[0].Points.Count > 30)
                    {
                        PH_ch.Series[0].Points.RemoveAt(0);
                    }
                    PH_ch.Series[0].Points.Add(Double.Parse(res_s[0]));


                    if (T_ch.Series[0].Points.Count > 30)
                    {
                        T_ch.Series[0].Points.RemoveAt(0);
                    }
                    T_ch.Series[0].Points.Add(Double.Parse(res_s[4]));


                    if (OPR_ch.Series[0].Points.Count > 30)
                    {
                        OPR_ch.Series[0].Points.RemoveAt(0);
                    }
                    OPR_ch.Series[0].Points.Add(Double.Parse(res_s[1]));
                }
            }
            catch (Exception ex) {
                err_count++;
                if (max_err_count < err_count)
                {
                    setStatus("System ERROR. Going to shutdown.");
                    delay(4000);
                    work = false;
                    return;
                }
            }
        }

        private void P10_Click(object sender, EventArgs e)
        {
            P_1.ForeColor = Color.BlueViolet;
            _serialPort.Write("<10>");
        }

        private void P11_Click(object sender, EventArgs e)
        {
            P_2.ForeColor = Color.BlueViolet;
            _serialPort.Write("<11>");
        }

        private void P12_Click(object sender, EventArgs e)
        {
            P_3.ForeColor = Color.BlueViolet;
            _serialPort.Write("<12>");
        }

        private void P13_Click(object sender, EventArgs e)
        {
            P_4.ForeColor = Color.BlueViolet;
            _serialPort.Write("<13>");
        }

        private void P00_Click(object sender, EventArgs e)
        {
            P_1.ForeColor = Color.Red;
            _serialPort.Write("<00>");
        }

        private void P01_Click(object sender, EventArgs e)
        {
            P_2.ForeColor = Color.Red;
            _serialPort.Write("<01>");
        }

        private void P02_Click(object sender, EventArgs e)
        {
            P_3.ForeColor = Color.Red;
            _serialPort.Write("<02>");
        }

        private void P03_Click(object sender, EventArgs e)
        {
            P_4.ForeColor = Color.Red;
            _serialPort.Write("<03>");
        }


        public void delay(int t)
        {
            Thread.Sleep(t);
        }
        public void disp(string s)
        {
            statusL.Text = s;
        }
        public void setStatus(string s)
        {
            statusL.Text = "Status: " + s;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
