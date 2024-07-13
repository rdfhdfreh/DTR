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
    public partial class Registerpage : Form
    {
        public Registerpage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginpage login = new Loginpage();
            login.Show();
            this.Hide();
        }

        private void Registerpage_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rgstrbtn_Click(object sender, EventArgs e)
        {
            Loginpage login = new Loginpage();
            login.Show();
            this.Hide();
        }
    }
}
