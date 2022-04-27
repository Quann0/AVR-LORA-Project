using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
        }
        public void LoadImage()
        {
            try 
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\QUAN\source\repos\UART-CS\UART-CS\Image\1.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception) { MessageBox.Show("Bug in picture"); }
            
        }
        private void Login_Click(object sender, EventArgs e)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(@"C:\Users\QUAN\source\repos\UART-CS\UART-CS\login.json");
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
                    var s = @"C:\Users\QUAN\source\repos\UART-CS\UART-CS\login.json";
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

            Led = (Led < 2) ? 2 : 1;
            buttonLed.Text = (buttonLed.Text == "Đóng") ? "Mở" : "Đóng";
            pictureBox1.Image = new Bitmap($@"C:\Users\QUAN\source\repos\UART-CS\UART-CS\Image\{Led.ToString()}.png");
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
            buttonConnect.Text = (buttonConnect.Text == "Connect") ? "Disconnect" : "Connect";
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                
            }
            else
            {
                serialPort.Open();
            }
        }

        private void buttonUart_Click(object sender, EventArgs e)
        {
            serialPort.Write(textBox1.Text);

        }
    }
}

