using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Handle_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            Control container = target.Parent;

            // If the container is output
            if (container.Name == "outputGroup")
            {
                // Do output stuff
                inputs.Visible = true;
            }
            // else if is input
            else
            {
                // Do input stuff
                // Such as send command to shinybow and hide thyself
                inputs.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
