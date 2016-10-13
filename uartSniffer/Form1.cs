using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

/*
 * 
 * 
 * 
 * ("UART-Sniffer") Is an C# WinForm Application for Q2D Solutions & SICS,
 * while working with CC2538 ARM Development Kit & TI SmartEB06 Boards
 * 
 * // Build by me to provide an easy way to Debug 2 UART Devices at once
 *
 * 
 * 
 * 
 * 
 * ---! Default Baudrate in this project is 115200 - enable the others in the code
 * ---! Handshake, Stopbits & Parity are disabled by default.... enable them in the code if you need them
 * 
 * 
 * 
 * 
 */
namespace uartSniffer
{
    public partial class Form1 : Form
    {   
        //serial-COM 1 init
        SerialPort ComPort = new SerialPort();
        //initiera serialCom variabler och preFunctions
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

        //serial-COM 2 init
        SerialPort ComPort2 = new SerialPort();
        //initiera serialCom variabler och preFunctions
        internal delegate void SerialDataReceivedEventHandlerDelegate2(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate2(object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler2;
        delegate void SetTextCallback2(string text2);
        string InputData2 = String.Empty;



        public Form1()
        {
            InitializeComponent();
            
            SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

            SerialPinChangedEventHandler2 = new SerialPinChangedEventHandler(PinChanged2);
            ComPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_2);

            checkBox_pause1.Enabled = false;
            checkBox_pause2.Enabled = false;

            knapp_hamtaPortar_Click(null,null);


            // lägg till fördefinierade värden
            /*
            comboBox2_BaudRate2.Items.Add(115200);
            comboBox2_BaudRate2.Items.ToString();
            //get first item print in text
            comboBox2_BaudRate2.Text = comboBox2_BaudRate2.Items[0].ToString();


            comboBox2_DataBits2.Items.Add(8);
            //get the first item print it in the text 
            comboBox2_DataBits2.Text = comboBox2_DataBits2.Items[0].ToString();
             * */
        }



        private void knapp_hamtaPortar_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            //Com Ports Array
            ArrayComPortsNames = SerialPort.GetPortNames();
            // append fix
            comboBox1_port1.Items.Clear();
            comboBox2_port2.Items.Clear();
            do
            {
                try
                {
                    index += 1;
                    comboBox1_port1.Items.Add(ArrayComPortsNames[index]);
                    comboBox2_port2.Items.Add(ArrayComPortsNames[index]);
                    //MessageBox.Show("INFO:\n" + ArrayComPortsNames[index]);
                }
                catch
                {

                    //MessageBox.Show("Hittade endast 1 eller inga COM anslutningar", "Hämta enheter");
                    return;
                }

            } while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
           
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }

            comboBox1_port1.Text = ArrayComPortsNames[0];

            //Baud Rate
            //i vårt fall vill vi använda Baud Rate 115200 - nr10
            //cboBaudRate.Items.Add(300);
            //cboBaudRate.Items.Add(600);
            //cboBaudRate.Items.Add(1200);
            //cboBaudRate.Items.Add(2400);
            //cboBaudRate.Items.Add(9600);
            //cboBaudRate.Items.Add(14400);
            //cboBaudRate.Items.Add(19200);
            //cboBaudRate.Items.Add(38400);
            //cboBaudRate.Items.Add(57600);
            comboBox1_BaudRate1.Items.Add(115200);
            comboBox1_BaudRate1.Items.ToString();
            //Lägg till baudrate värde till combobox
            comboBox1_BaudRate1.Text = comboBox1_BaudRate1.Items[0].ToString();


            //Data Bits
            //cboDataBits.Items.Add(7);
            comboBox1_DataBits1.Items.Add(8);
            //get the first item print it in the text 
            comboBox1_DataBits1.Text = comboBox1_DataBits1.Items[0].ToString();

            ////Stop Bits
            //cboStopBits.Items.Add("One");
            //cboStopBits.Items.Add("OnePointFive");
            //cboStopBits.Items.Add("Two");
            ////get the first item print in the text
            //cboStopBits.Text = cboStopBits.Items[0].ToString();


            ////Parity 
            //cboParity.Items.Add("None");
            //cboParity.Items.Add("Even");
            //cboParity.Items.Add("Mark");
            //cboParity.Items.Add("Odd");
            //cboParity.Items.Add("Space");
            ////Hämta första värdet
            //cboParity.Text = cboParity.Items[0].ToString();


            ////Handshake
            //cboHandShaking.Items.Add("None");
            //cboHandShaking.Items.Add("XOnXOff");
            //cboHandShaking.Items.Add("RequestToSend");
            //cboHandShaking.Items.Add("RequestToSendXOnXOff");
            ////Hämta första värdet
            //cboHandShaking.Text = cboHandShaking.Items[0].ToString();




            // combo 2 Implement fix
            if (ArrayComPortsNames.Length >= 2)
            {
                comboBox2_port2.Text = ArrayComPortsNames[1];
                comboBox2_BaudRate2.Items.Add(115200);
                comboBox2_BaudRate2.Items.ToString();
                comboBox2_BaudRate2.Text = comboBox2_BaudRate2.Items[0].ToString();
                comboBox2_DataBits2.Items.Add(8);
                comboBox2_DataBits2.Text = comboBox2_DataBits2.Items[0].ToString();
                // !obs ingen handshake osv...!
            }


            /*
              Om endast en hittas
             */
            if (comboBox2_port2.Text.Length == 0)
            {
                //MessageBox.Show("Endast en Enhet hittades");
            }


            // kör/lyssna så fort vi är anslutna via kabel
            //knapp_portLyssnare_Click(null, null);


        }

        private void knapp_portLyssnare_Click(object sender, EventArgs e)
        {
            if (knapp_portLyssnare.Text == "Feed Stängd")
            {
                checkBox_pause1.Checked = false;
                checkBox_pause2.Checked = false;
                try
                {
                    
                    knapp_portLyssnare.Text = "Feed Öppen";
                    knapp_portLyssnare.ForeColor = Color.Green;
                    checkBox_pause1.Enabled = true;
                    checkBox_pause2.Enabled = true;

                    ComPort.PortName = Convert.ToString(comboBox1_port1.Text);
                    ComPort.BaudRate = Convert.ToInt32(comboBox1_BaudRate1.Text);
                    ComPort.DataBits = Convert.ToInt16(comboBox1_DataBits1.Text);
                    //ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                    //ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                    //ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                    ComPort.Open();
                    progressBar_1.Value = 100;

                    
                    if (comboBox2_port2.Text.Length == 0)
                    {
                        //MessageBox.Show(" combo2 är TOM");
                    }
                    else {
                        ComPort2.PortName = Convert.ToString(comboBox2_port2.Text);
                        ComPort2.BaudRate = Convert.ToInt32(comboBox2_BaudRate2.Text);
                        ComPort2.DataBits = Convert.ToInt16(comboBox2_DataBits2.Text);
                        //ComPort2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                        //ComPort2.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                        //ComPort2.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                        ComPort2.Open();
                        progressBar_2.Value = 100;
                    }

                }
                catch
                {
                    //
                    // Ifall Brädan kopplas bort / saknas / tappar connection
                    //MessageBox.Show("Välj en Anslutning");
                    comboBox2_port2.Text = "";
                    comboBox2_BaudRate2.Text = "";
                    comboBox2_DataBits2.Text = "";

                    return;
                }

            }
            else if (knapp_portLyssnare.Text == "Feed Öppen")
            {
                knapp_portLyssnare.Text = "Feed Stängd";
                knapp_portLyssnare.ForeColor = Color.Red;
                progressBar_1.Value = 0;
                progressBar_2.Value = 0;
                ComPort.Close();
                ComPort2.Close();
                checkBox_pause1.Enabled = false;
                checkBox_pause2.Enabled = false;
                
            }
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPort.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void port_DataReceived_2(object sender, SerialDataReceivedEventArgs e)
        {
            InputData2 = ComPort2.ReadExisting();
            if (InputData2 != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback2(SetText2), new object[] { InputData2 });
            }
        }


        private void SetText(string text)
        {
            //this.textbox_output.Text += text;
            textbox_output.AppendText(text);


        }

        private void SetText2(string text2)
        {
            //this.textbox_output.Text += text;
            textbox2_output2.AppendText(text2);
            

        }


        internal void PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            /*SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;
            
            SerialPinChange1 = e.EventType;
            lblCTSStatus.BackColor = Color.Green;
            lblDSRStatus.BackColor = Color.Green;
            lblRIStatus.BackColor = Color.Green;
            lblBreakStatus.BackColor = Color.Green;
            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    lblBreakStatus.BackColor = Color.Red;
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = ComPort.CtsHolding;
                    //  MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = ComPort.CDHolding;
                    lblCTSStatus.BackColor = Color.Red;
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = ComPort.DsrHolding;
                    lblDSRStatus.BackColor = Color.Red;
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    lblRIStatus.BackColor = Color.Red;
                    //MessageBox.Show("Ring Detected");
                    break;
            }*/
        }

        internal void PinChanged2(object sender, SerialPinChangedEventArgs e)
        {
            /*SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;
            
            SerialPinChange1 = e.EventType;
            lblCTSStatus.BackColor = Color.Green;
            lblDSRStatus.BackColor = Color.Green;
            lblRIStatus.BackColor = Color.Green;
            lblBreakStatus.BackColor = Color.Green;
            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    lblBreakStatus.BackColor = Color.Red;
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = ComPort.CtsHolding;
                    //  MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = ComPort.CDHolding;
                    lblCTSStatus.BackColor = Color.Red;
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = ComPort.DsrHolding;
                    lblDSRStatus.BackColor = Color.Red;
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    lblRIStatus.BackColor = Color.Red;
                    //MessageBox.Show("Ring Detected");
                    break;
            }*/
        }

        private void knapp_rensaBox1_Click(object sender, EventArgs e)
        {
            textbox_output.ResetText();
        }

        private void textbox_output_TextChanged(object sender, EventArgs e)
        {
            textbox_output.ScrollToCaret();
        }

        private void textbox2_output2_TextChanged(object sender, EventArgs e)
        {
            textbox2_output2.ScrollToCaret();
        }

        private void knapp_rensaBox2_Click(object sender, EventArgs e)
        {
            textbox2_output2.ResetText();
        }


        // PAUSE device 1
        private void checkBox_pause1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_pause1.Checked)
            {
                ComPort.Close();
            }
            else
            {
                ComPort.Open();
            }
        }

        // PAUSE device 1
        private void checkBox_pause2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_pause2.Checked)
            {
                ComPort2.Close();
            }
            else {
                ComPort2.Open();
            }
        }

        

        private void knapp_reset_Click(object sender, EventArgs e)
        {
            comboBox1_port1.ResetText();
            comboBox1_BaudRate1.ResetText();
            comboBox1_DataBits1.ResetText();

            comboBox2_port2.ResetText();
            comboBox2_BaudRate2.ResetText();
            comboBox2_DataBits2.ResetText();

            textbox_output.ResetText();
            textbox2_output2.ResetText();
        }

        
    }
}
