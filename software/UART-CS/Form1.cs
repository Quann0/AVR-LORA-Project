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
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;


namespace UART_CS
{

    public partial class Form1 : Form
    {
        class Account
        {
            public Account () { }
            ~ Account() { }
            private string tk { set; get; }
            private string mk { set; get; }
            public Account(string _tk, string _mk)
            {
                tk = _tk;
                mk = _mk;
            }
        }
        public Form1()
        {
            
            InitializeComponent();
            Init_Control();
            LoadImage();
            
        }
        public void Init_Control() 
        {
            List<string> baudList = new List<string>{"600","1200","2400","4800","9600","14400","19200","38400","56000","57600","115200"};
            comboBoxBaud.Items.AddRange(baudList.ToArray());
            comboBoxPort.Text = "";
            comboBoxPort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBaud.Text = "";
            comboBoxBaud.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBaud.DropDownHeight = comboBoxBaud.ItemHeight * 8;
            textBox1.Multiline = true;
            textBox1.AcceptsReturn = true;
            textBox1.MaxLength = 32;
            timer1.Start();
        }
        public void LoadImage()
        {
            try 
            {
                pictureBoxTime.Image = new Bitmap(Application.StartupPath + "\\Image\\gif\\original.gif");
                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Image\\gif\\original1.gif");
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\1.png");
                pictureBoxDC.Image = new Bitmap(Application.StartupPath + "\\Image\\dongco\\a.jpg");
                pictureBoxBuz.Image = new Bitmap(Application.StartupPath + "\\Image\\3.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxTime.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxDC.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxBuz.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxHumid.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception) { MessageBox.Show("Bug in picture"); }
            
        }
        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.AddJsonFile(Application.StartupPath + "\\login.json");
                IConfigurationRoot configurationRoot = configurationBuilder.Build();


                if (AccountBox.Text == configurationRoot.GetSection("tk").Value && PassWordBox.Text == configurationRoot.GetSection("mk").Value)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Enabled = true;
                }
                else MessageBox.Show("Đăng Nhập Thất Bại", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) 
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PassWordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(sender, e);
            }
        }

        private void AccountBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(sender, e);
            }
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
                    serialPort.Write("ledOff~");
                }
                else if (buttonLed.Text == "OFF")
                {
                    serialPort.Write("ledOn~");
                }
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\"+Led.ToString()+".png");
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
                    MessageBox.Show("Vui lòng mở cổng COM", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    serialPort.Write(textBox1.Text + "~");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Mở Cổng COM", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
	        
        }
        string kq = "";

        private void SignUp_MouseClick(object sender, MouseEventArgs e)
        {
            Form f = new Form();
            Button button = new Button() { Location = new Point(45, 181), Text = "OK" };
            List<Label> label = new List<Label>
            {
                new Label { Location = new Point(45, 21),Text = "TaiKhoan" },
                new Label { Location = new Point(45, 51), Text = "matkhau" },
                new Label {Location = new Point(45, 81), Text = "Nhaplaimk" }
            };
            List<TextBox> textBoxes = new List<TextBox>
            {
                new TextBox{Location = new Point(120, 21)},
                new TextBox{Location = new Point(120, 51)},
                new TextBox{Location = new Point(120, 81)}
            };
            f.Controls.AddRange(textBoxes.ToArray());
            f.Controls.Add(button);
            foreach (var item in label)
            {
                f.Controls.Add(item);
            }
            void button_Click(object sender1, EventArgs e1)
            {
                if (textBoxes[1].Text == textBoxes[2].Text)
                {
                    Account account = new Account(textBoxes[0].Text.ToString(), textBoxes[1].Text.ToString());
                    string json = JsonConvert.SerializeObject(account);
                    var s = Application.StartupPath + "\\login.json";
                    System.IO.File.WriteAllText(s, json);
                    MessageBox.Show("Tao tai khoan thanh cong");
                    f.Close();
                }
                else MessageBox.Show("Vui long nhap lai mat khau", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button.Click += button_Click;
            f.ShowDialog();
        }
        public int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Enabled = true;
            labelTime.Text = DateTime.Now.ToString("dd/MM/yyy\nHH:mm:ss");
            i++;
            if (i > 4) 
            {
                buttonStartDC.Text = (buttonStartDC.Text == "ComingSoon...") ? "ComingSoon." : (buttonStartDC.Text == "ComingSoon.") ? "ComingSoon.." : "ComingSoon...";
                i = 0;
            }
            //textBox1.Enabled = false;
        }
        public string dataPort = "";
        public int compare = 0;
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                dataPort = serialPort.ReadChar().ToString();
                dataPort += serialPort.ReadChar().ToString();
                dataPort += serialPort.ReadChar().ToString();
                dataPort += serialPort.ReadChar().ToString();
            }));
            kq += dataPort;          
            if (kq.Length >3)
            {
                string kq1 = kq.ToString();
                compare = Convert.ToInt32(kq1.Substring(0,2));
                compare = (compare == 0) ? 0 : (compare > 0 && compare <= 10) ? 10 : (compare > 10 && compare <= 30) ? 30 : (compare > 30 && compare <= 40) ? 40 : (compare > 40 && compare <= 44) ? 44 : (compare > 44 && compare <= 55) ? 55 : (compare > 55 && compare <= 60) ? 60 : (compare > 60 && compare < 70) ? 70 : 100;
                pictureBoxNhietdo.Image = new Bitmap(Application.StartupPath + "\\Image\\nhietdo-doam\\"+compare.ToString()+".jpg");
                pictureBoxHumid.Image = new Bitmap(Application.StartupPath + "\\Image\\nhietdo-doam\\kisspng-humidity-computer-icons-moisture-object-5abe54104c2479.6291987115224228003119.jpg");
                pictureBoxNhietdo.SizeMode = PictureBoxSizeMode.Zoom;
                Invoke(new MethodInvoker(() => textBoxNhietdo.Text = kq1.ToString().Substring(0,2) + ","+ kq1.ToString().Substring(2, 1)));
                Invoke(new MethodInvoker(() => textBoxHumi.Text = kq1.ToString().Substring(3,2) +","+ kq1.ToString().Substring(5)+"%"));
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
            if(comboBoxPort.Items.Count > 5) 
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
                    serialPort.Write("buzOff~");
                }
                else if (buttonBuz.Text == "OFF")
                {
                    serialPort.Write("buzOn~");
                }
                pictureBoxBuz.Image = new Bitmap(Application.StartupPath + "\\Image\\" + Buz.ToString() + ".jpg");
            }
            else MessageBox.Show("Vui long ket noi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            textBoxHumi.Enabled = false;
            textBoxNhietdo.Enabled = false;
            buttonStartDC.Enabled = false;
            
        }

        private void labelEditBaud_Click(object sender, EventArgs e)
        {
            comboBoxBaud.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void buttonClearString_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}