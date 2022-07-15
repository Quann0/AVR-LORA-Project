
namespace UART_CS
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumid = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuz = new System.Windows.Forms.PictureBox();
            this.pictureBoxDC = new System.Windows.Forms.PictureBox();
            this.pictureBoxNhietdo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhietdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.IntegralHeight = false;
            this.comboBoxPort.Location = new System.Drawing.Point(59, 5);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(113, 24);
            this.comboBoxPort.TabIndex = 8;
            this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(59, 30);
            this.comboBoxBaud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(113, 24);
            this.comboBoxBaud.TabIndex = 9;
            // 
            // BaudComboBox
            // 
            this.BaudComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BaudComboBox.Location = new System.Drawing.Point(-10, 32);
            this.BaudComboBox.Name = "BaudComboBox";
            this.BaudComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BaudComboBox.Size = new System.Drawing.Size(66, 22);
            this.BaudComboBox.TabIndex = 10;
            this.BaudComboBox.Text = "BAUD";
            // 
            // PortComBoBox
            // 
            this.PortComBoBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortComBoBox.Location = new System.Drawing.Point(-4, 7);
            this.PortComBoBox.Name = "PortComBoBox";
            this.PortComBoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PortComBoBox.Size = new System.Drawing.Size(56, 22);
            this.PortComBoBox.TabIndex = 11;
            this.PortComBoBox.Text = "PORT";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.Bisque;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonConnect.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonConnect.Location = new System.Drawing.Point(12, 67);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(117, 63);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonLed
            // 
            this.buttonLed.Location = new System.Drawing.Point(195, 254);
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
            this.textBox1.Location = new System.Drawing.Point(3, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 57);
            this.textBox1.TabIndex = 16;
            // 
            // buttonUart
            // 
            this.buttonUart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonUart.Location = new System.Drawing.Point(3, 255);
            this.buttonUart.Name = "buttonUart";
            this.buttonUart.Size = new System.Drawing.Size(112, 39);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Temperature";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTime.Location = new System.Drawing.Point(280, 5);
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
            this.buttonStartDC.Location = new System.Drawing.Point(435, 260);
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
            this.labelHumiTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHumiTag.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHumiTag.Location = new System.Drawing.Point(338, 66);
            this.labelHumiTag.Name = "labelHumiTag";
            this.labelHumiTag.Size = new System.Drawing.Size(75, 20);
            this.labelHumiTag.TabIndex = 27;
            this.labelHumiTag.Text = "Humidity";
            // 
            // buttonBuz
            // 
            this.buttonBuz.Location = new System.Drawing.Point(318, 254);
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
            this.labelEditBaud.Location = new System.Drawing.Point(178, 37);
            this.labelEditBaud.Name = "labelEditBaud";
            this.labelEditBaud.Size = new System.Drawing.Size(80, 23);
            this.labelEditBaud.TabIndex = 30;
            this.labelEditBaud.Text = "Custom";
            this.labelEditBaud.Click += new System.EventHandler(this.labelEditBaud_Click);
            // 
            // buttonClearString
            // 
            this.buttonClearString.BackColor = System.Drawing.Color.Red;
            this.buttonClearString.ForeColor = System.Drawing.Color.Black;
            this.buttonClearString.Location = new System.Drawing.Point(111, 255);
            this.buttonClearString.Name = "buttonClearString";
            this.buttonClearString.Size = new System.Drawing.Size(78, 39);
            this.buttonClearString.TabIndex = 31;
            this.buttonClearString.Text = "Clear";
            this.buttonClearString.UseVisualStyleBackColor = false;
            this.buttonClearString.Click += new System.EventHandler(this.buttonClearString_Click);
            // 
            // textBoxHumi
            // 
            this.textBoxHumi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxHumi.Location = new System.Drawing.Point(340, 89);
            this.textBoxHumi.Multiline = true;
            this.textBoxHumi.Name = "textBoxHumi";
            this.textBoxHumi.Size = new System.Drawing.Size(73, 33);
            this.textBoxHumi.TabIndex = 32;
            // 
            // textBoxNhietdo
            // 
            this.textBoxNhietdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhietdo.Location = new System.Drawing.Point(241, 90);
            this.textBoxNhietdo.Multiline = true;
            this.textBoxNhietdo.Name = "textBoxNhietdo";
            this.textBoxNhietdo.Size = new System.Drawing.Size(73, 32);
            this.textBoxNhietdo.TabIndex = 33;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(450, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 63);
            this.button1.TabIndex = 36;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(44, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 37;
            this.label2.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxHumid
            // 
            this.pictureBoxHumid.Location = new System.Drawing.Point(340, 128);
            this.pictureBoxHumid.Name = "pictureBoxHumid";
            this.pictureBoxHumid.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxHumid.TabIndex = 35;
            this.pictureBoxHumid.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(425, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 108);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxBuz
            // 
            this.pictureBoxBuz.Location = new System.Drawing.Point(318, 192);
            this.pictureBoxBuz.Name = "pictureBoxBuz";
            this.pictureBoxBuz.Size = new System.Drawing.Size(95, 57);
            this.pictureBoxBuz.TabIndex = 29;
            this.pictureBoxBuz.TabStop = false;
            // 
            // pictureBoxDC
            // 
            this.pictureBoxDC.Location = new System.Drawing.Point(435, 192);
            this.pictureBoxDC.Name = "pictureBoxDC";
            this.pictureBoxDC.Size = new System.Drawing.Size(122, 57);
            this.pictureBoxDC.TabIndex = 25;
            this.pictureBoxDC.TabStop = false;
            // 
            // pictureBoxNhietdo
            // 
            this.pictureBoxNhietdo.Location = new System.Drawing.Point(241, 128);
            this.pictureBoxNhietdo.Name = "pictureBoxNhietdo";
            this.pictureBoxNhietdo.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxNhietdo.TabIndex = 20;
            this.pictureBoxNhietdo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 57);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(569, 306);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Dashboard";
            this.Text = "Smart Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhietdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

