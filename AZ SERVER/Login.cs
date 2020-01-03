using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AZ_SERVER
{
  
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass, key;
        
            user = "admin";
            pass = "admin";
            key = "ADMIN";

            if (username.Text == "")
            {
                MessageBox.Show("Please type username!");
            } else if(password.Text == "")
            {
                MessageBox.Show("Please type password!");
            } else if (keymember.Text == "")
            {
                MessageBox.Show("Please type key member!");
            } else if (term.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Please agree terms and conditions  ");
            } 
            else if ((username.Text == user) && (password.Text == pass))
            {
                if (keymember.Text == key)
                {
                    Thread.Sleep(1000);
                    MessageBox.Show("Wellcome "+username.Text+". Logged in successfully!");
                    Formmain.username = username.Text;
                    Formmain formmain = new Formmain();
                    Login login = new Login();
                    formmain.Show();
                    this.Hide();
                  




                } else
                {
                    MessageBox.Show("Key member incorect!");
                    keymember.Clear();
                }
            }
            else
            {
                MessageBox.Show("The username or password that you've entered is incorrect. ");
                username.Clear();
                password.Clear();
                keymember.Clear();
            }
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
