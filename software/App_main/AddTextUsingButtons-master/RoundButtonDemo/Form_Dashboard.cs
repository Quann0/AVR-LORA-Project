using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoundButtonDemo;

namespace UART_CS
{

    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {

            InitializeComponent();
            Init_Control();
            LoadImage();

        }
        public void Init_Control()
        {
            List<string> baudList = new List<string> { "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
            comboBoxBaud.Items.AddRange(baudList.ToArray());
            comboBoxPort.Text = "";
            comboBoxPort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBaud.Text = "";
            comboBoxBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBaud.DropDownHeight = comboBoxBaud.ItemHeight * 8;
            textBox1.Multiline = true;
            textBox1.AcceptsReturn = true;
            textBox1.MaxLength = 32;
            buttonConnect.Text = "Connect";
            timer1.Start();
        }
        public void LoadImage()
        {
            try
            {
                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Image\\gif\\original1.gif");
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\1.png");
                pictureBoxDC.Image = new Bitmap(Application.StartupPath + "\\Image\\dongco\\a.jpg");
                pictureBoxBuz.Image = new Bitmap(Application.StartupPath + "\\Image\\3.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxDC.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxBuz.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxHumid.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception) { MessageBox.Show("Bug in picture"); }

        }
        public int Led = 1;
        private void buttonLed_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                Led = (Led < 2) ? 2 : 1;
                buttonLed.Text = (buttonLed.Text == "OFF") ? "ON" : "OFF";
                if (buttonLed.Text == "ON")
                {
                    serialPort.WriteLine("ledOff");
                }
                else if (buttonLed.Text == "OFF")
                {
                    serialPort.WriteLine("ledOn");
                }
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\" + Led.ToString() + ".png");
            }
            else MessageBox.Show("Vui long ket noi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {

            if (comboBoxPort.Text != "" && comboBoxBaud.Text != "")
            {
                buttonConnect.Text = (buttonConnect.Text == "Connect") ? "Disconnect" : "Connect";
                if (buttonConnect.Text == "Disconnect")
                {
                    serialPort.PortName = comboBoxPort.Text;
                    serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    comboBoxPort.Enabled = false;
                    comboBoxBaud.Enabled = false;
                }
                else
                {
                    comboBoxPort.Enabled = true;
                    comboBoxBaud.Enabled = true;
                }

                try
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    else
                    {
                        serialPort.Open();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Loi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng mở cổng COM", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        public string leftString = "";
        public string rightString = "";
        private void buttonUart_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Không kí tự nào được tìm thấy!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    serialPort.WriteLine(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Mở Cổng COM", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        string kq = "";
        public int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dd/MM/yyy\nHH:mm:ss");
            i++;
            if (i > 4)
            {
                buttonStartDC.Text = (buttonStartDC.Text == "ComingSoon...") ? "ComingSoon." : (buttonStartDC.Text == "ComingSoon.") ? "ComingSoon.." : "ComingSoon...";
                i = 0;
            }
            notifyIcon1.Text = "T   " + textBoxNhietdo.Text + "\nH   " + textBoxHumi.Text;
            if (buttonBuz.Text == "OFF") notifyIcon1.Text += "\n" + "BUZ ON";
            else notifyIcon1.Text += "\n" + "Buz OFF";
            if (buttonLed.Text == "OFF") notifyIcon1.Text += "\n" + "LED ON";
            else notifyIcon1.Text += "\n" + "LED OFF";
        }
        public string dataPort = "";
        public int compare = 0;
        public int humi = 0;
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            for (int i = 0; i < 4; i++) dataPort += serialPort.ReadChar().ToString();
            kq += dataPort;
            if (kq.Length > 5)
            {
                string kq1 = kq.ToString();
                compare = Convert.ToInt32(kq1.Substring(0, 2));
                humi = Convert.ToInt32(kq1.Substring(3, 2));
                if (compare > 30 | humi > 90)
                {
                    pictureBox3.Image = new Bitmap(Application.StartupPath + "\\Image\\6fee010c2f54dbad9672029af47e274f-removebg-preview.png");
                    if (compare > 30 && humi > 90) Invoke(new MethodInvoker(() => label2.Text = "Warning!!!"));
                    else
                    {
                        if (compare > 30)
                            Invoke(new MethodInvoker(() => label2.Text = "Warning Temp"));
                        if (humi > 90) Invoke(new MethodInvoker(() => label2.Text = "Warning Humi"));
                    }
                }
                else 
                { 
                    pictureBox3.Image = null;
                    Invoke(new MethodInvoker(() => label2.Text = ""));
                }
                compare = (compare == 0) ? 0 : (compare > 0 && compare <= 10) ? 10 : (compare > 10 && compare <= 30) ? 30 : (compare > 30 && compare <= 40) ? 40 : (compare > 40 && compare <= 44) ? 44 : (compare > 44 && compare <= 55) ? 55 : (compare > 55 && compare <= 60) ? 60 : (compare > 60 && compare < 70) ? 70 : 100;
                pictureBoxNhietdo.Image = new Bitmap(Application.StartupPath + "\\Image\\nhietdo-doam\\" + compare.ToString() + ".jpg");
                pictureBoxHumid.Image = new Bitmap(Application.StartupPath + "\\Image\\nhietdo-doam\\kisspng-humidity-computer-icons-moisture-object-5abe54104c2479.6291987115224228003119.jpg");
                pictureBoxNhietdo.SizeMode = PictureBoxSizeMode.Zoom;
                Invoke(new MethodInvoker(() => textBoxNhietdo.Text = kq1.ToString().Substring(0, 2) + "." + kq1.ToString().Substring(2, 1) + "°C"));
                Invoke(new MethodInvoker(() => textBoxHumi.Text = kq1.ToString().Substring(3, 2) + "." + kq1.ToString().Substring(5) + "%"));
                kq = "";
                dataPort = "";
            }
        }
        public string DC = "a";
        private void buttonStartDC_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                DC = (DC == "a") ? "b" : "a";
                buttonStartDC.Text = (buttonStartDC.Text == "StartDC") ? "StopDC" : "StartDC";
                if (buttonStartDC.Text == "StartDC")
                {
                    serialPort.Write("a");
                }
                else if (buttonStartDC.Text == "StopDC")
                {
                    serialPort.Write("a");
                }
                pictureBoxDC.Image = new Bitmap(Application.StartupPath + "\\Image\\dongco\\" + DC + ".jpg");
            }
            else MessageBox.Show("Vui long ket noi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboBoxPort_DropDown(object sender, EventArgs e)
        {
            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxPort.Items.Count > 5)
            {
                comboBoxPort.DropDownHeight = comboBoxPort.ItemHeight * 6;
            }
        }
        public int Buz = 3;
        private void buttonBuz_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                Buz = (Buz < 4) ? 4 : 3;
                buttonBuz.Text = (buttonBuz.Text == "OFF") ? "ON" : "OFF";
                if (buttonBuz.Text == "ON")
                {
                    serialPort.WriteLine("buzOff");
                }
                else if (buttonBuz.Text == "OFF")
                {
                    serialPort.WriteLine("buzOn");
                }
                pictureBoxBuz.Image = new Bitmap(Application.StartupPath + "\\Image\\" + Buz.ToString() + ".jpg");
            }
            else MessageBox.Show("Vui long ket noi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;
            textBoxHumi.Enabled = false;
            textBoxNhietdo.Enabled = false;
            buttonStartDC.Enabled = false;
            comboBoxBaud.Enabled = false;
            comboBoxBaud.Enabled = true;
            comboBoxPort.Enabled = false;
            comboBoxPort.Enabled = true;
            this.MaximizeBox = false;
            label2.Text = "";
        }


        private void labelEditBaud_Click(object sender, EventArgs e)
        {
            comboBoxBaud.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void buttonClearString_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            this.Controls.Clear();
            InitializeComponent();
            Init_Control();
            LoadImage();
            Form1_Load(sender, e);
            notifyIcon1.Visible = false;
        }
    }
}