using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace DeadlinkChecker
{
    public partial class LinkForm : Form
    {
        public LinkForm()
        {
            InitializeComponent();
        }

        private void LinkForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  

            Ping ping = new Ping();
            PingReply reply = ping.Send(textBoxIP.Text, 1000);
            if (reply.Status == IPStatus.Success)
            {
                LogBox.Items.Add("Address: {0} " + reply.Address.ToString());
                LogBox.Items.Add("RoundTrip time: {0} " + reply.RoundtripTime);
                LogBox.Items.Add("Time to live: {0} " + reply.Options.Ttl);
                LogBox.Items.Add("Don't fragment: {0} "+ reply.Options.DontFragment);
                LogBox.Items.Add("Buffer size: {0} " + reply.Buffer.Length);




            }

            lblChgStatus.Text = reply.Status.ToString();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
