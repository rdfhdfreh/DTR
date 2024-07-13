using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTR
{
    
    public partial class Loginpage : Form
    {
        
        private System.Windows.Forms.Timer timer;
        public Loginpage()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick); 
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Landingpage landing = new Landingpage();
            landing.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registerpage regform = new Registerpage();
            regform.Show();
            this.Hide();
        }
    }
}
