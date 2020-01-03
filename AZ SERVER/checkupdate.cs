using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZ_SERVER
{
    public partial class checkupdate : Form
    {
        public checkupdate()
        {
            InitializeComponent();
            namever.Hide();
            Versions.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void checkupdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void checkupdate_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);

        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();    
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.update.Increment(1);
            if (update.Value == 100)
            {
                timer1.Stop();
              
                namever.Show();
                Versions.Show();
                MessageBox.Show("This update is the latest version!");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
