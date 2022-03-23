using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_UI_Creation
{
    public partial class Form1 : Form
    {
        
        string nl = "\r\n";
        int aleft = 1;
       

        public Form1()
        {
            InitializeComponent();
            ID.Text = "ID";
            Status.Text = "Status";
            result.Text = "Actual Result";
            statusvalue.Text = "No selection";
          
        }

        private void menuItem3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }
        public void Form1_Load(object Form)
        {
           
        }

        private void menuItem3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            statusvalue.Text = "RUN TEST ";
            activitylog("Press RUN TEST");
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            statusvalue.Text = "CLEAR RESULTS ";
            statusvalue.ForeColor = Color.Black;
           activitylog("Press CLEAR RESULTS  ");
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            statusvalue.ForeColor = Color.Black;
            idvalue.Text = "Selection 1";
            statusvalue.Text = "Completed ";
            statusvalue.ForeColor = Color.Green;
            resultvalue.Text = "Send message: OK" + nl +"Receive Ack: OK " + nl + "Receive message: OK" + nl + "All mandatory fields: OK" + nl + "Validating fields: OK";
            activitylog("Select Selection 1");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusvalue.ForeColor = Color.Black;
            statusvalue.Text = "CANCEL";
            activitylog("Press CANCEL");
         
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            idvalue.Text = "Selection 2";
            statusvalue.Text = "Not Executed  ";
            statusvalue.ForeColor = Color.Black;
            activitylog("Select Selection 2 ");


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            idvalue.Text = "Selection 3";
            statusvalue.Text = "Failed";
            statusvalue.ForeColor = Color.Red;
            resultvalue.Text = "Send message: OK" + nl + "Receive Ack: OK " + nl + "Receive message: OK" + nl + "All mandatory fields: Missing 2 fields" + nl + "Validating fields: " + nl + "Field ID 1 contains invalid info." + nl + "Field ID 2 is missing. " + nl + "Field ID 5 is missing. ";
            activitylog("Select Selection 3");
        }
        public  void activitylog(string text)
        {
           
            Label lbl = new Label();
            panel3.Controls.Add(lbl);
            lbl.Top = aleft * 5;
            lbl.Size = new Size(50,15);
            lbl.ForeColor = Color.Black;
            lbl.Text = text+ nl ;
            lbl.Left = 10;
            lbl.AutoSize = true;

            aleft = aleft + 2;
            Label lbl2 = new Label();
            panel3.Controls.Add(lbl2);
            panel3.AutoScroll = true;
            lbl2.Top = aleft * 5;
            lbl2.Size = new Size(50, 15);
            lbl2.ForeColor = Color.Black;
            lbl2.Text = "";
            lbl2.Left = 10;
            lbl2.AutoSize = true;
            aleft = aleft + 2;
            panel3.Enabled = false;


            return;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
