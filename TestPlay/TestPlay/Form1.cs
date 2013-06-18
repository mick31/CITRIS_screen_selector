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
    public partial class ScreenSelector : Form
    {
        int currentOutput;
        int currentInput;

        public ScreenSelector()
        {
            InitializeComponent();
        }

        private void Handle_Click(object sender, EventArgs e)
        {
            Button target = (Button)sender;
            Control container = target.Parent;

            if ((int)target.Tag == -1) // Power off
            {
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
                String cmd = String.Format("Outputall 00;");
                serialPort1.WriteLine(cmd.Trim());
                serialPort1.DiscardOutBuffer();
                serialPort1.Close();
            }
            else
            {
                // If the container is output
                if (container.Name == "outputGroup")
                {
                    // Do output stuff
                    inputGroup.Visible = true;
                    currentOutput = (int)target.Tag;
                }
                // else if is input, Do input stuff
                else
                {
                    // Get the index of the button pressed
                    currentInput = (int)target.Tag;

                    // Send the signal to the ShinyBow
                    // TODO: That ^^
                    System.Console.WriteLine("Testing! Output {0}, Input {1}", currentOutput, currentInput);

                    serialPort1.WriteTimeout = 500;
                    serialPort1.Open();
                    String cmd = String.Format("Output0{1} 0{0};", currentInput, currentOutput);
                    serialPort1.WriteLine(cmd.Trim());
                    serialPort1.DiscardOutBuffer();
                    serialPort1.Close();

                    // If confirmed, update the picture of the output button

                    // hide the input buttons
                    inputGroup.Visible = false;
                }
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
