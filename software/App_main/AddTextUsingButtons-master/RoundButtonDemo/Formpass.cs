using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_CS;

namespace RoundButtonDemo
{
    public partial class Formpass : Form
    {
        //public static int check = 0;
        public string pass = "23112001";
        public Formpass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // ActiveControl.Focus();
            txtPassword.Text += btn.Text;
            //SendKeys.Send(btn.Text);
        }

        private void button_WOC12_Click(object sender, EventArgs e)
        {
            txtPassword.Text = ""; // txtPassword.Clear();
        }
        public void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == pass)
            {
               // check = 1;
                MessageBox.Show("Đăng nhập thành công");
                this.Close();
            }

        }
    }
}
