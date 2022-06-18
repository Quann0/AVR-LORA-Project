
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStartDC = new System.Windows.Forms.Button();
            this.labelHumiTag = new System.Windows.Forms.Label();
            this.buttonBuz = new System.Windows.Forms.Button();
            this.labelEditBaud = new System.Windows.Forms.Label();
            this.buttonClearString = new System.Windows.Forms.Button();
            this.textBoxHumi = new System.Windows.Forms.TextBox();
            this.textBoxNhietdo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuz = new System.Windows.Forms.PictureBox();
            this.pictureBoxDC = new System.Windows.Forms.PictureBox();
            this.pictureBoxTime = new System.Windows.Forms.PictureBox();
            this.pictureBoxNhietdo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhietdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumid)).BeginInit();
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
            this.comboBoxPort.IntegralHeight = false;
            this.comboBoxPort.Location = new System.Drawing.Point(75, 5);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(113, 24);
            this.comboBoxPort.TabIndex = 8;
            this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(75, 30);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(113, 24);
            this.comboBoxBaud.TabIndex = 9;
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BaudComboBox.Location = new System.Drawing.Point(6, 32);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BaudComboBox.Size = new System.Drawing.Size(66, 22);
            this.BaudComboBox.TabIndex = 10;
            this.BaudComboBox.Text = "BAUD";
            // 
            // PortComBoBox
            // 
            this.PortComBoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortComBoBox.Location = new System.Drawing.Point(12, 7);
            this.PortComBoBox.Name = "PortComBoBox";
            this.PortComBoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PortComBoBox.Size = new System.Drawing.Size(56, 22);
            this.PortComBoBox.TabIndex = 11;
            this.PortComBoBox.Text = "PORT";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonConnect.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonConnect.Location = new System.Drawing.Point(12, 67);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(112, 63);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonLed
            // 
            this.buttonLed.Location = new System.Drawing.Point(195, 319);
            this.buttonLed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLed.Name = "buttonLed";
            this.buttonLed.Size = new System.Drawing.Size(97, 45);
            this.buttonLed.TabIndex = 14;
            this.buttonLed.Text = "ON";
            this.buttonLed.UseVisualStyleBackColor = true;
            this.buttonLed.Click += new System.EventHandler(this.buttonLed_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(3, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 57);
            this.textBox1.TabIndex = 16;
            // 
            // buttonUart
            // 
            this.buttonUart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUart.Location = new System.Drawing.Point(3, 320);
            this.buttonUart.Name = "buttonUart";
            this.buttonUart.Size = new System.Drawing.Size(112, 37);
            this.buttonUart.TabIndex = 17;
            this.buttonUart.Text = "Send";
            this.buttonUart.UseVisualStyleBackColor = false;
            this.buttonUart.Click += new System.EventHandler(this.buttonUart_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(248, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Temperature";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTime.Location = new System.Drawing.Point(325, 7);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(107, 44);
            this.labelTime.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStartDC
            // 
            this.buttonStartDC.Location = new System.Drawing.Point(456, 322);
            this.buttonStartDC.Name = "buttonStartDC";
            this.buttonStartDC.Size = new System.Drawing.Size(122, 39);
            this.buttonStartDC.TabIndex = 23;
            this.buttonStartDC.Text = "Coming soon..";
            this.buttonStartDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStartDC.UseVisualStyleBackColor = true;
            this.buttonStartDC.Click += new System.EventHandler(this.buttonStartDC_Click);
            // 
            // labelHumiTag
            // 
            this.labelHumiTag.AutoSize = true;
            this.labelHumiTag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHumiTag.Location = new System.Drawing.Point(351, 70);
            this.labelHumiTag.Name = "labelHumiTag";
            this.labelHumiTag.Size = new System.Drawing.Size(62, 17);
            this.labelHumiTag.TabIndex = 27;
            this.labelHumiTag.Text = "Humidity";
            // 
            // buttonBuz
            // 
            this.buttonBuz.Location = new System.Drawing.Point(329, 319);
            this.buttonBuz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuz.Name = "buttonBuz";
            this.buttonBuz.Size = new System.Drawing.Size(95, 45);
            this.buttonBuz.TabIndex = 28;
            this.buttonBuz.Text = "On";
            this.buttonBuz.UseVisualStyleBackColor = true;
            this.buttonBuz.Click += new System.EventHandler(this.buttonBuz_Click);
            // 
            // labelEditBaud
            // 
            this.labelEditBaud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEditBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEditBaud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEditBaud.Location = new System.Drawing.Point(194, 37);
            this.labelEditBaud.Name = "labelEditBaud";
            this.labelEditBaud.Size = new System.Drawing.Size(79, 21);
            this.labelEditBaud.TabIndex = 30;
            this.labelEditBaud.Text = "Custom";
            this.labelEditBaud.Click += new System.EventHandler(this.labelEditBaud_Click);
            // 
            // buttonClearString
            // 
            this.buttonClearString.BackColor = System.Drawing.Color.Red;
            this.buttonClearString.ForeColor = System.Drawing.Color.Black;
            this.buttonClearString.Location = new System.Drawing.Point(111, 320);
            this.buttonClearString.Name = "buttonClearString";
            this.buttonClearString.Size = new System.Drawing.Size(78, 39);
            this.buttonClearString.TabIndex = 31;
            this.buttonClearString.Text = "Clear";
            this.buttonClearString.UseVisualStyleBackColor = false;
            this.buttonClearString.Click += new System.EventHandler(this.buttonClearString_Click);
            // 
            // textBoxHumi
            // 
            this.textBoxHumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxHumi.Location = new System.Drawing.Point(354, 89);
            this.textBoxHumi.Multiline = true;
            this.textBoxHumi.Name = "textBoxHumi";
            this.textBoxHumi.Size = new System.Drawing.Size(59, 41);
            this.textBoxHumi.TabIndex = 32;
            // 
            // textBoxNhietdo
            // 
            this.textBoxNhietdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhietdo.Location = new System.Drawing.Point(251, 90);
            this.textBoxNhietdo.Multiline = true;
            this.textBoxNhietdo.Name = "textBoxNhietdo";
            this.textBoxNhietdo.Size = new System.Drawing.Size(61, 41);
            this.textBoxNhietdo.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(434, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 98);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxBuz
            // 
            this.pictureBoxBuz.Location = new System.Drawing.Point(329, 257);
            this.pictureBoxBuz.Name = "pictureBoxBuz";
            this.pictureBoxBuz.Size = new System.Drawing.Size(95, 57);
            this.pictureBoxBuz.TabIndex = 29;
            this.pictureBoxBuz.TabStop = false;
            // 
            // pictureBoxDC
            // 
            this.pictureBoxDC.Location = new System.Drawing.Point(456, 257);
            this.pictureBoxDC.Name = "pictureBoxDC";
            this.pictureBoxDC.Size = new System.Drawing.Size(122, 57);
            this.pictureBoxDC.TabIndex = 25;
            this.pictureBoxDC.TabStop = false;
            // 
            // pictureBoxTime
            // 
            this.pictureBoxTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTime.Location = new System.Drawing.Point(584, 257);
            this.pictureBoxTime.Name = "pictureBoxTime";
            this.pictureBoxTime.Size = new System.Drawing.Size(139, 101);
            this.pictureBoxTime.TabIndex = 22;
            this.pictureBoxTime.TabStop = false;
            // 
            // pictureBoxNhietdo
            // 
            this.pictureBoxNhietdo.Location = new System.Drawing.Point(251, 137);
            this.pictureBoxNhietdo.Name = "pictureBoxNhietdo";
            this.pictureBoxNhietdo.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxNhietdo.TabIndex = 20;
            this.pictureBoxNhietdo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 57);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxHumid
            // 
            this.pictureBoxHumid.Location = new System.Drawing.Point(340, 136);
            this.pictureBoxHumid.Name = "pictureBoxHumid";
            this.pictureBoxHumid.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxHumid.TabIndex = 35;
            this.pictureBoxHumid.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.pictureBoxHumid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxNhietdo);
            this.Controls.Add(this.textBoxHumi);
            this.Controls.Add(this.buttonClearString);
            this.Controls.Add(this.labelEditBaud);
            this.Controls.Add(this.pictureBoxBuz);
            this.Controls.Add(this.buttonBuz);
            this.Controls.Add(this.labelHumiTag);
            this.Controls.Add(this.pictureBoxDC);
            this.Controls.Add(this.buttonStartDC);
            this.Controls.Add(this.pictureBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxNhietdo);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Smart Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhietdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumid)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label BaudComboBox;
        private System.Windows.Forms.Label PortComBoBox;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonLed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUart;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNhietdo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.Button buttonStartDC;
        private System.Windows.Forms.PictureBox pictureBoxDC;
        private System.Windows.Forms.Label labelHumiTag;
        private System.Windows.Forms.PictureBox pictureBoxBuz;
        private System.Windows.Forms.Button buttonBuz;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelEditBaud;
        private System.Windows.Forms.Button buttonClearString;
        private System.Windows.Forms.TextBox textBoxHumi;
        private System.Windows.Forms.TextBox textBoxNhietdo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxHumid;
    }
}

