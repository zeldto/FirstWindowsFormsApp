using System.Diagnostics;
using System.Globalization;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace FirstWindowsFormsApp
{
    public partial class Form1 : Form
    {
        //Variables
        char ch = 'a';


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
            Trace.WriteLine(this.BackColor.ToString());
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            Trace.WriteLine(this.BackColor.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                this.Width += 20;
                this.Height += 15;
            }
            if (e.KeyChar == '-')
            {
                this.Width -= 20;
                this.Height -= 15;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Int64 testIntLong = Convert.ToInt64(textBox1.Text);

            // uint testInt = (uint)testIntLong;

            // int radius = 5;

            //double surface = Math.PI * radius * radius;
            //string surfaceArea = "Circle surface area= " + surface.ToString();

            //textBoxResult.AppendText("" + surfaceArea);

            bool textEqual = false;

            if (checkBoxStayConnected.Checked)
            {
                textBoxResult.Text = textBoxInputIPAddress.Text.Equals(textBoxPort.Text) ? "Strings are equal\r\n" : "Strings are not equal\r\n";
            }
            else
            {
                textBoxResult.Text = textBoxInputIPAddress.Text.Equals(textBoxPort.Text, StringComparison.InvariantCultureIgnoreCase) ? "Strings are equal\r\n" : "Strings are not equal\r\n";
            }


            int stringCompareResult;

            stringCompareResult = string.Compare(textBoxInputIPAddress.Text, textBoxPort.Text, checkBoxStayConnected.Checked);

            if (stringCompareResult > 0)
            {
                textBoxResult.AppendText(string.Format("{0} is after {1}", textBoxInputIPAddress.Text, textBoxPort.Text));
            }
            else if (stringCompareResult < 0)
            {
                textBoxResult.AppendText(string.Format("{0} is before {1}", textBoxInputIPAddress.Text, textBoxPort.Text));
            }
            else
            {
                textBoxResult.AppendText(string.Format("{0} is equal to {1}", textBoxInputIPAddress.Text, textBoxPort.Text));
            }


            if (textBoxInputIPAddress.Text.IndexOf(';') > 0)
            {
                string[] textSeparateParts = textBoxInputIPAddress.Text.Split(';');

                foreach (string part in textSeparateParts)
                {
                    textBoxResult.AppendText(part + "\r\n");
                }
            }


            //if (textBoxInput1.Text.Equals(textBoxInput2.Text,StringComparison.InvariantCultureIgnoreCase))
            //{
            //    textBoxResult.Text = "Strings are equal";
            //}
            //else
            //{
            //    textBoxResult.Text = "Strings are not equal";
            //}

        }

        private void comboBoxSignalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSignal.Items.Clear();
            //switch (comboBoxSignalType.Text)
            //{
            //    case "Analog":
            //        comboBoxSignal.Items.AddRange(analogSignals);

            //        break;
            //    case "Digital":
            //        comboBoxSignal.Items.AddRange(analogSignals);

            //        break;
            //    case "Fieldbus":
            //        comboBoxSignal.Items.AddRange(analogSignals);

            //        break;
            //    default:
            //        break;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.Show(this);
            this.Visible = false;
            aboutForm.FormClosed += new FormClosedEventHandler(aboutForm_FormClosed);
        }
        void aboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void checkBoxCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string sendToBackEnd(string command)
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(textBoxInputIPAddress.Text), Convert.ToInt32(textBoxPort.Text));
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(endpoint);
            textBoxResult.AppendText("Connected to server.");

            client.Send(Encoding.ASCII.GetBytes(command));


            byte[] buffer = new byte[1024];
            int bytesReceived = client.Receive(buffer);
            string recived = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
            textBoxResult.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived));
            client.Close();
            textBoxResult.AppendText("Disconnected from server.");
            return recived;
        }

        private void buttonReadConf_Click(object sender, EventArgs e)
        {
            string read_conf = sendToBackEnd("readconf");
        }

        private void buttonWriteConf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSensorName.Text))
            {
                
            }
        }

        private void buttonReadScaled_Click(object sender, EventArgs e)
        {
            string read_scaled = sendToBackEnd("readscaled");
        }

        private void buttonReadStatus_Click(object sender, EventArgs e)
        {
            string read_status = sendToBackEnd("readstatus");
        }

        private void buttonTimerStart_Click(object sender, EventArgs e)
        {
            
        }

        private void timerGraph_Tick(object sender, EventArgs e)
        {

        }
    }
}
