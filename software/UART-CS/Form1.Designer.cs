
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
            this.AccountLabel = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.BaudComboBox = new System.Windows.Forms.Label();
            this.PortComBoBox = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonLed = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUart = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxNhietdo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStartDC = new System.Windows.Forms.Button();
            this.labelHumi = new System.Windows.Forms.Label();
            this.textBoxHumi = new System.Windows.Forms.TextBox();
            this.buttonBuz = new System.Windows.Forms.Button();
            this.pictureBoxBuz = new System.Windows.Forms.PictureBox();
            this.pictureBoxDC = new System.Windows.Forms.PictureBox();
            this.pictureBoxTime = new System.Windows.Forms.PictureBox();
            this.pictureBoxNhietdo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhietdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(681, 8);
            this.AccountBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(102, 22);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountBox_KeyDown);
            // 
            // PassWordBox
            // 
            this.PassWordBox.Location = new System.Drawing.Point(681, 34);
            this.PassWordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassWordBox.Name = "PassWordBox";
            this.PassWordBox.Size = new System.Drawing.Size(102, 22);
            this.PassWordBox.TabIndex = 1;
            this.PassWordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWordBox_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(572, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "PassWord";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(681, 60);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(102, 30);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignUp.Location = new System.Drawing.Point(660, 99);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(137, 23);
            this.SignUp.TabIndex = 5;
            this.SignUp.Text = "Change Account";
            this.SignUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseClick);
            // 
            // AccountLabel
            // 
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AccountLabel.Location = new System.Drawing.Point(572, 9);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountLabel.Size = new System.Drawing.Size(103, 22);
            this.AccountLabel.TabIndex = 7;
            this.AccountLabel.Text = "Account";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(65, 7);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(113, 24);
            this.comboBoxPort.TabIndex = 8;
            this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(65, 30);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(113, 24);
            this.comboBoxBaud.TabIndex = 9;
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BaudComboBox.Location = new System.Drawing.Point(3, 32);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BaudComboBox.Size = new System.Drawing.Size(56, 22);
            this.BaudComboBox.TabIndex = 10;
            this.BaudComboBox.Text = "Baud";
            // 
            // PortComBoBox
            // 
            this.PortComBoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortComBoBox.Location = new System.Drawing.Point(3, 7);
            this.PortComBoBox.Name = "PortComBoBox";
            this.PortComBoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PortComBoBox.Size = new System.Drawing.Size(56, 22);
            this.PortComBoBox.TabIndex = 11;
            this.PortComBoBox.Text = "PORT";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 69);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(103, 53);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonLed
            // 
            this.buttonLed.Location = new System.Drawing.Point(122, 312);
            this.buttonLed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLed.Name = "buttonLed";
            this.buttonLed.Size = new System.Drawing.Size(97, 45);
            this.buttonLed.TabIndex = 14;
            this.buttonLed.Text = "Mở";
            this.buttonLed.UseVisualStyleBackColor = true;
            this.buttonLed.Click += new System.EventHandler(this.buttonLed_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 22);
            this.textBox1.TabIndex = 16;
            // 
            // buttonUart
            // 
            this.buttonUart.Location = new System.Drawing.Point(3, 320);
            this.buttonUart.Name = "buttonUart";
            this.buttonUart.Size = new System.Drawing.Size(65, 29);
            this.buttonUart.TabIndex = 17;
            this.buttonUart.Text = "Send";
            this.buttonUart.UseVisualStyleBackColor = true;
            this.buttonUart.Click += new System.EventHandler(this.buttonUart_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // textBoxNhietdo
            // 
            this.textBoxNhietdo.Location = new System.Drawing.Point(12, 151);
            this.textBoxNhietdo.Name = "textBoxNhietdo";
            this.textBoxNhietdo.Size = new System.Drawing.Size(56, 22);
            this.textBoxNhietdo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nhietdo";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTime.Location = new System.Drawing.Point(703, 227);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(85, 33);
            this.labelTime.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStartDC
            // 
            this.buttonStartDC.Location = new System.Drawing.Point(402, 315);
            this.buttonStartDC.Name = "buttonStartDC";
            this.buttonStartDC.Size = new System.Drawing.Size(107, 39);
            this.buttonStartDC.TabIndex = 23;
            this.buttonStartDC.Text = "StartDC";
            this.buttonStartDC.UseVisualStyleBackColor = true;
            this.buttonStartDC.Click += new System.EventHandler(this.buttonStartDC_Click);
            // 
            // labelHumi
            // 
            this.labelHumi.AutoSize = true;
            this.labelHumi.Location = new System.Drawing.Point(128, 131);
            this.labelHumi.Name = "labelHumi";
            this.labelHumi.Size = new System.Drawing.Size(49, 17);
            this.labelHumi.TabIndex = 27;
            this.labelHumi.Text = "Do am";
            // 
            // textBoxHumi
            // 
            this.textBoxHumi.Location = new System.Drawing.Point(122, 151);
            this.textBoxHumi.Name = "textBoxHumi";
            this.textBoxHumi.Size = new System.Drawing.Size(56, 22);
            this.textBoxHumi.TabIndex = 26;
            // 
            // buttonBuz
            // 
            this.buttonBuz.Location = new System.Drawing.Point(256, 312);
            this.buttonBuz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuz.Name = "buttonBuz";
            this.buttonBuz.Size = new System.Drawing.Size(95, 45);
            this.buttonBuz.TabIndex = 28;
            this.buttonBuz.Text = "On";
            this.buttonBuz.UseVisualStyleBackColor = true;
            this.buttonBuz.Click += new System.EventHandler(this.buttonBuz_Click);
            // 
            // pictureBoxBuz
            // 
            this.pictureBoxBuz.Location = new System.Drawing.Point(256, 250);
            this.pictureBoxBuz.Name = "pictureBoxBuz";
            this.pictureBoxBuz.Size = new System.Drawing.Size(95, 57);
            this.pictureBoxBuz.TabIndex = 29;
            this.pictureBoxBuz.TabStop = false;
            // 
            // pictureBoxDC
            // 
            this.pictureBoxDC.Location = new System.Drawing.Point(402, 250);
            this.pictureBoxDC.Name = "pictureBoxDC";
            this.pictureBoxDC.Size = new System.Drawing.Size(107, 57);
            this.pictureBoxDC.TabIndex = 25;
            this.pictureBoxDC.TabStop = false;
            // 
            // pictureBoxTime
            // 
            this.pictureBoxTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTime.Location = new System.Drawing.Point(652, 263);
            this.pictureBoxTime.Name = "pictureBoxTime";
            this.pictureBoxTime.Size = new System.Drawing.Size(145, 94);
            this.pictureBoxTime.TabIndex = 22;
            this.pictureBoxTime.TabStop = false;
            // 
            // pictureBoxNhietdo
            // 
            this.pictureBoxNhietdo.Location = new System.Drawing.Point(12, 179);
            this.pictureBoxNhietdo.Name = "pictureBoxNhietdo";
            this.pictureBoxNhietdo.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxNhietdo.TabIndex = 20;
            this.pictureBoxNhietdo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 57);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.pictureBoxBuz);
            this.Controls.Add(this.buttonBuz);
            this.Controls.Add(this.labelHumi);
            this.Controls.Add(this.textBoxHumi);
            this.Controls.Add(this.pictureBoxDC);
            this.Controls.Add(this.buttonStartDC);
            this.Controls.Add(this.pictureBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxNhietdo);
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
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassWordBox);
            this.Controls.Add(this.AccountBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Smart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhietdo)).EndInit();
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
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label BaudComboBox;
        private System.Windows.Forms.Label PortComBoBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonLed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUart;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxNhietdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNhietdo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.Button buttonStartDC;
        private System.Windows.Forms.PictureBox pictureBoxDC;
        private System.Windows.Forms.Label labelHumi;
        private System.Windows.Forms.TextBox textBoxHumi;
        private System.Windows.Forms.PictureBox pictureBoxBuz;
        private System.Windows.Forms.Button buttonBuz;
    }
}

