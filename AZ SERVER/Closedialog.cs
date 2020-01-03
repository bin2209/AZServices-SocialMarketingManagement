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
    public partial class Closedialog : Form
    {
        public Closedialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Formmain frm = new Formmain();
            Login login = new Login();
            this.Close();
            System.Windows.Forms.Application.ExitThread();
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
