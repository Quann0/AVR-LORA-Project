
namespace UART_CS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.PassWordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.BaudComboBox = new System.Windows.Forms.Label();
            this.PortComBoBox = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonLed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUart = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxNhietdo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(658, 8);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(125, 22);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountBox_KeyDown);
            // 
            // PassWordBox
            // 
            this.PassWordBox.Location = new System.Drawing.Point(658, 34);
            this.PassWordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.Size = new System.Drawing.Size(125, 22);
            this.PassWordBox.TabIndex = 1;
            this.PassWordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWordBox_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(562, 37);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "PassWord";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(628, 73);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(71, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignUp.Location = new System.Drawing.Point(718, 78);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(65, 23);
            this.SignUp.TabIndex = 5;
            this.SignUp.Text = "SignUp";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "DoiTaiKhoan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountLabel
            // 
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AccountLabel.Location = new System.Drawing.Point(562, 9);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountLabel.Size = new System.Drawing.Size(90, 22);
            this.AccountLabel.TabIndex = 7;
            this.AccountLabel.Text = "Account";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.comboBoxPort.Location = new System.Drawing.Point(108, 7);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(151, 24);
            this.comboBoxPort.TabIndex = 8;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(108, 40);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(151, 24);
            this.comboBoxBaud.TabIndex = 9;
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BaudComboBox.Location = new System.Drawing.Point(12, 41);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BaudComboBox.Size = new System.Drawing.Size(81, 22);
            this.BaudComboBox.TabIndex = 10;
            this.BaudComboBox.Text = "Baud";
            // 
            // PortComBoBox
            // 
            this.PortComBoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortComBoBox.Location = new System.Drawing.Point(3, 7);
            this.PortComBoBox.Name = "PortComBoBox";
            this.PortComBoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PortComBoBox.Size = new System.Drawing.Size(90, 22);
            this.PortComBoBox.TabIndex = 11;
            this.PortComBoBox.Text = "PORT";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(274, 1);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(125, 63);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonLed
            // 
            this.buttonLed.Location = new System.Drawing.Point(45, 178);
            this.buttonLed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLed.Name = "buttonLed";
            this.buttonLed.Size = new System.Drawing.Size(107, 45);
            this.buttonLed.TabIndex = 14;
            this.buttonLed.Text = "Đóng";
            this.buttonLed.UseVisualStyleBackColor = true;
            this.buttonLed.Click += new System.EventHandler(this.buttonLed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 74);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 16;
            // 
            // buttonUart
            // 
            this.buttonUart.Location = new System.Drawing.Point(261, 138);
            this.buttonUart.Name = "buttonUart";
            this.buttonUart.Size = new System.Drawing.Size(104, 23);
            this.buttonUart.TabIndex = 17;
            this.buttonUart.Text = "Truyendata";
            this.buttonUart.UseVisualStyleBackColor = true;
            this.buttonUart.Click += new System.EventHandler(this.buttonUart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxNhietdo
            // 
            this.textBoxNhietdo.Location = new System.Drawing.Point(499, 121);
            this.textBoxNhietdo.Name = "textBoxNhietdo";
            this.textBoxNhietdo.Size = new System.Drawing.Size(58, 22);
            this.textBoxNhietdo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhietdo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNhietdo);
            this.Controls.Add(this.buttonUart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLed);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.PortComBoBox);
            this.Controls.Add(this.BaudComboBox);
            this.Controls.Add(this.comboBoxBaud);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.AccountBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "`q";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.TextBox PassWordBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label BaudComboBox;
        private System.Windows.Forms.Label PortComBoBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonLed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUart;
        private System.IO.Ports.SerialPort serialPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxNhietdo;
        private System.Windows.Forms.Label label1;
    }
}

