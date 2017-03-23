using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                    double ii = double.Parse(res_s[2], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"));
                    DO_ch.Series[0].Points.Add(ii);


                    if (CO_ch.Series[0].Points.Count > 30)
                    {
                        CO_ch.Series[0].Points.RemoveAt(0);
                    }
                    ii = double.Parse(res_s[3], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"));
                    CO_ch.Series[0].Points.Add(ii);


                    if (PH_ch.Series[0].Points.Count > 30)
                    {
                        PH_ch.Series[0].Points.RemoveAt(0);
                    }
                    ii = double.Parse(res_s[0], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"));
                    PH_ch.Series[0].Points.Add(ii);


                    if (T_ch.Series[0].Points.Count > 30)
                    {
                        T_ch.Series[0].Points.RemoveAt(0);
                    }
                    ii = double.Parse(res_s[4], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"));
                    T_ch.Series[0].Points.Add(ii);


                    if (OPR_ch.Series[0].Points.Count > 30)
                    {
                        OPR_ch.Series[0].Points.RemoveAt(0);
                    }
                    ii = double.Parse(res_s[1], NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"));
                    OPR_ch.Series[0].Points.Add(ii);
                }
            }
            catch (Exception ex) {
                err_count++;
                if (max_err_count < err_count)
                {
                    setStatus("System ERROR. Going to shutdown.");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                P00.Visible = true;
                P01.Visible = true;
                P02.Visible = true;
                P03.Visible = true;
                P10.Visible = true;
                P11.Visible = true;
                P12.Visible = true;
                P13.Visible = true;

                P110.Visible = false;
                P111.Visible = false;
                P112.Visible = false;
                P113.Visible = false;

                _serialPort.Write("!0");
            }
            else
            {
                P00.Visible = false;
                P01.Visible = false;
                P02.Visible = false;
                P03.Visible = false;
                P10.Visible = false;
                P11.Visible = false;
                P12.Visible = false;
                P13.Visible = false;

                P110.Visible = true;
                P111.Visible = true;
                P112.Visible = true;
                P113.Visible = true;

                _serialPort.Write("!1");
            }
        }

        private void P110_Click(object sender, EventArgs e)
        {
            P_1.ForeColor = Color.BlueViolet;
            _serialPort.Write("<10>");
        }

        private void P111_Click(object sender, EventArgs e)
        {
            P_2.ForeColor = Color.BlueViolet;
            _serialPort.Write("<11>");
        }

        private void P112_Click(object sender, EventArgs e)
        {
            P_3.ForeColor = Color.BlueViolet;
            _serialPort.Write("<12>");
        }

        private void P113_Click(object sender, EventArgs e)
        {
            P_4.ForeColor = Color.BlueViolet;
            _serialPort.Write("<13>");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
