using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AZ_SERVER
{
    
    public partial class Formmain : Form
    {
        

        public static string username = string.Empty;

        string data_exname, data_extype, data_export, data_exapi, data_exversion;
        
        public Formmain()
        {
            InitializeComponent();
            if ((data_exname!=null)&& (data_extype != null) && (data_export != null) && (data_exapi != null) && (data_exversion != null)) {
            exname.Text = data_exname;
            extype.Text = data_extype;
            export.Text = data_export;
            exapi.Text = data_exapi;
            exversion.Text = data_exversion;
            }
            //  exname.Text = dataexname;
            //   extype.Text = dataextype;
            //  export.Text = dataexport;
            // exapi.Text = dataexapi;
            // exversion.Text = dataexversion;

            
            status1.Hide();
            status2.Hide();
            checkconnect1.Hide();
            checkconnect2.Hide();
            if (!string.IsNullOrEmpty(username))
            {
                this.curentuser.Text = "User: " + username;
            }

            string i4server = Environment.MachineName;
            string i4user = Environment.UserName;
            string i4ver = Environment.OSVersion.Version.ToString();
            string i4os = Environment.OSVersion.ToString();
            string i4osp = Environment.OSVersion.Platform.ToString();
            int i4process = Environment.ProcessorCount;
           
            i4servername.Text = ("Server: " + i4server); 
            i4username.Text = ("Username: " + i4user);
            i4version.Text = ("Version: " + i4ver);
            i4osystem.Text = ("O.S: " + i4os);
            i4osplatform.Text = ("O.S.P: " + i4osp);
            i4processor.Text = ("Processor: " + i4process);
          


            DriveInfo[] allDrives = DriveInfo.GetDrives();
          foreach (DriveInfo c in allDrives)
            {
               
                if (c.IsReady == true)
                {


                    disk.Text = ("| Disk:" +c.Name+ " used "+ c.TotalFreeSpace/1024/1024/1024 + "/" + c.TotalSize/1024/1024/1024+" GB");
               }
          }

        }

      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formmain_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nAME1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transferTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Excel File|*.xlsx";
            ofd.Title = "Save Data User";
          //ofd.ShowDialog();
            if (ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
            
                fileoutput.Text = ofd.FileName;
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK!");
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exname.Clear();
          //  extype.Clear();
            exapi.Clear();
           // exversion.Clear();
            export.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pgdomain.Clear();
            pghostname.Clear();
            pgpassword.Clear();
            pgport.Clear();
            pgusername.Clear();
            pgvolume.Clear();
            pgdirectory.Clear();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.connect1.Start();
            status1.Show();            
            checkconnect1.Show();         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            statistics statistic = new statistics();
            statistic.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("All saved!");
        }

        private void i4osplatform_Click(object sender, EventArgs e)
        {

        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formmain frm = new Formmain();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;
        private void Formmain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
     
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supportBuyPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socialmedia ssmedia = new socialmedia();
            ssmedia.Show();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportbug rpbug = new reportbug();
            rpbug.Show();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
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

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter plugin key!");
        }

        private void googleMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter plugin key!");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter plugin key!");
        }

        private void zaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter plugin key!");
        }

        private void i4servername_Click(object sender, EventArgs e)
        {

        }

        private void gettingHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkupdate cupdate = new checkupdate();
            cupdate.Show();
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            MessageBox.Show("All saved!");
        }

        private void status1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.connect2.Start();
            status2.Show();
            checkconnect2.Show();
        }

        private void checkconnect1_Click(object sender, EventArgs e)
        {

        }

        private void connect1_Tick(object sender, EventArgs e)
        {
            this.checkconnect1.Increment(1);
            if (checkconnect1.Value == 100)
            {
                connect1.Stop();
                status1.Hide();
                checkconnect1.Hide();
                
            }
        }

        private void connect2_Tick(object sender, EventArgs e)
        {
            this.checkconnect2.Increment(1);
            if (checkconnect2.Value == 100)
            {
                connect2.Stop();
                status2.Hide();
                checkconnect2.Hide();

            }
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Closedialog closeandexit = new Closedialog();
            closeandexit.ShowDialog();

        }

        private void exname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
              data_exname = exname.Text;
              data_extype = extype.Text;
              data_export = export.Text;
              data_exapi = exapi.Text;
              data_exversion = exversion.Text;
            Thread.Sleep(1000);
            MessageBox.Show("All saved!");
        }
    }
}
