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
//using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;


namespace UART_CS
{

    public partial class Form1 : Form
    {
        class Account
        {
            public string tk { set; get; }
            public string mk { set; get; }
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
            comboBoxPort.Text = "COM1";
            comboBoxBaud.Text = "9600";
            timer1.Start();
        }
        public void LoadImage()
        {
            try 
            {
                pictureBoxTime.Image = new Bitmap(Application.StartupPath + "\\Image\\gif\\original.gif");
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\1.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxTime.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception) { MessageBox.Show("Bug in picture"); }
            
        }
        private void Login_Click(object sender, EventArgs e)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(Application.StartupPath + "\\login.json");
            IConfigurationRoot configurationRoot = configurationBuilder.Build();


            if (AccountBox.Text == configurationRoot.GetSection("tk").Value && PassWordBox.Text == configurationRoot.GetSection("mk").Value)
                MessageBox.Show("Đăng nhập thành công");
            else MessageBox.Show("Đăng Nhập Thất Bại", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Button button = new Button();
            List<Label> label = new List<Label> { new Label { }, new Label { }, new Label() };

            f.Controls.Add(button);
            foreach (var item in label)
            {
                f.Controls.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                buttonLed.Text = (buttonLed.Text == "Đóng") ? "Mở" : "Đóng";
                if (buttonLed.Text == "Mở")
                {
                    serialPort.Write("1");
                }
                else if (buttonLed.Text == "Đóng")
                {
                    serialPort.Write("2");
                }
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\"+Led.ToString()+".png");
            }
            else MessageBox.Show("Vui long ket noi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
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
                buttonConnect.Text = (buttonConnect.Text == "Connect") ? "Disconnect" : "Connect";
            }
            catch(Exception) 
            {
                MessageBox.Show("Vui lòng mở cổng COM", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void buttonUart_Click(object sender, EventArgs e)
        {
	        if(serialPort.IsOpen)
		    {
			    serialPort.Write(textBox1.Text);
		    }
            else
		    {
			    MessageBox.Show("Vui Lòng Mở Cổng COM");
		    }

        }
        string kq = "";

        private void SignUp_MouseClick(object sender, MouseEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dataPort = serialPort.ReadExisting();
            //MessageBox.Show(serialPort1.ReadByte().ToString());
            kq += dataPort;
            if (kq.Length == 2)
            {
                string kq1 = kq;
                var compare = Convert.ToInt32(kq1);
                compare = (compare == 0) ? 0 : (compare > 0 && compare <= 10) ? 10 : (compare > 10 && compare <= 30) ? 30 : (compare > 30 && compare <= 40) ? 40 : (compare > 40 && compare <= 44) ? 44 : (compare > 44 && compare <= 55) ? 55 : (compare > 55 && compare <= 60) ? 60 : (compare > 60 && compare < 70) ? 70 : 100;
                pictureBoxNhietdo.Image = new Bitmap(Application.StartupPath + "\\Image\\gif\\nhietdo\\"+compare.ToString()+".jpg");
                pictureBoxNhietdo.SizeMode = PictureBoxSizeMode.Zoom;
                Invoke(new MethodInvoker(() => textBoxNhietdo.Text = kq1.ToString() + "oC"));
                kq = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
        }
    }
}

