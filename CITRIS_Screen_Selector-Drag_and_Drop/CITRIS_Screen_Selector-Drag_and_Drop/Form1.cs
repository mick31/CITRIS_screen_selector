using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CITRIS_Screen_Selector_Drag_and_Drop
{
    public partial class ScreenSelector : Form
    {
        bool isDragged = false;
        bool setHomePosition = true;
        bool connected;
        bool can_see_help = false;
        Point ptOffset;
        Point ptHome;

        List<Label> outputs;
        int outputTag;
        int inputTag;
        public enum LabelType { INPUT, OUTPUT, OTHER }

        public class LabelTag
        {
            private LabelType _type;
            private int _index;
            private string _display_text;

            public LabelType GetLabelType { get { return _type; } }
            public int GetIndex { get { return _index; } }
            public string GetDisplayText { get { return _display_text; } }

            public LabelTag(LabelType type, int index, string display_text)
            {
                _type = type;
                _index = index;
                _display_text = display_text;
            }
        }

        public ScreenSelector()
        {
            InitializeComponent();
            InitializeConnection();
            
            outputs = new List<Label>();

            // initialize outputs
            InitializeLabel(tv1_display, LabelType.OUTPUT, "No Output");
            InitializeLabel(tv2_display, LabelType.OUTPUT, "No Output");
            InitializeLabel(podium, LabelType.OUTPUT, "No Output");
            //InitializeLabel(polycom, LabelType.OUTPUT, "No Output");

            // initialize inputs
            InitializeLabel(laptop, LabelType.INPUT, "Laptop");
        }

        private void InitializeLabel(Label label, LabelType type, string displat_text)
        {
            LabelTag tag;

            switch (type)
            {
                case LabelType.OUTPUT:
                    tag = new LabelTag(type, outputTag++, displat_text);
                    label.Tag = tag;
                    outputs.Add(label);
                    break;
                case LabelType.INPUT:
                    tag = new LabelTag(type, inputTag++, displat_text);
                    label.Tag = tag;
                    label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
                    label.MouseLeave += new System.EventHandler(this.input_MouseLeave);
                    label.MouseHover += new System.EventHandler(this.input_MouseHover);
                    label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
                    label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.input_MouseUp);
                    break;
                case LabelType.OTHER:
                    tag = new LabelTag(type, -1, displat_text);
                    label.Tag = tag;
                    break;
                default:
                    break;
            }
        }


        /************************************************************
         * Source to Display Functions
         * **********************************************************/
        private void input_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label cur_input = (Label)sender;
                isDragged = true;
                Point ptStartPosition = cur_input.PointToScreen(new Point(e.X, e.Y));
                if (setHomePosition)
                {
                    setHomePosition = false;
                    ptHome = cur_input.Location;
                }

                ptOffset = new Point();
                ptOffset.X = cur_input.Location.X - ptStartPosition.X;
                ptOffset.Y = cur_input.Location.Y - ptStartPosition.Y;
            }
            else
                isDragged = false;
        }

        private void input_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                Label cur_input = (Label)sender;
                Point newPoint = cur_input.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                cur_input.Location = newPoint;
            }
        }

        private void input_MouseUp(object sender, MouseEventArgs e)
        {
            Label cur_input = (Label)sender;
            for (int cur_out = 0; cur_out < outputs.Count; cur_out++)
            {
                if (outputs[cur_out].Bounds.Contains(cur_input.Bounds))
                {
                    LabelTag outTag = (LabelTag)outputs[cur_out].Tag;
                    LabelTag inTag = (LabelTag)cur_input.Tag;
                    // Send input switch command to SB
                    //SendCommand(String.Format("Output0{1} 0{0};", inTag.GetIndex, outTag.GetIndex).Trim());

                    // change outputs display
                    outputs[cur_out].Image = cur_input.Image;
                    outputs[cur_out].TextAlign = ContentAlignment.BottomCenter;
                    outputs[cur_out].Text = (String)inTag.GetDisplayText;
                    break;
                }
            }

            //reset button position
            isDragged = false;
            setHomePosition = true;
            cur_input.Location = ptHome;
        }

        private void input_MouseHover(object sender, EventArgs e)
        {
            Label cur_input = (Label)sender;
            cur_input.BorderStyle = BorderStyle.FixedSingle;
            pointingFinger.Visible = true;
        }

        private void input_MouseLeave(object sender, EventArgs e)
        {
            Label cur_input = (Label)sender;
            cur_input.BorderStyle = BorderStyle.None;
            pointingFinger.Visible = false;
        }


        // turn off all ShinyBow outputs
        private void offOutputs_Click(object sender, MouseEventArgs e)
        {
            SendCommand(String.Format("Outputall 00;").Trim());
        }


        /************************************************************
         * Shinybow Interface Functions
         * **********************************************************/
        // check to ports to see if shinybow is connected
        private void InitializeConnection()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                char[] buffer = new char[8];

                serialPort1.PortName = port;
                serialPort1.Open();

                if (!serialPort1.IsOpen) continue;

                serialPort1.WriteTimeout = 500;
                serialPort1.DiscardOutBuffer();
                serialPort1.Write("Link ?;");

                serialPort1.DiscardInBuffer();

                try
                {
                    serialPort1.Read(buffer, 0, 8);
                }
                catch (System.TimeoutException)
                {
                    serialPort1.Close();
                    continue;
                }

                serialPort1.Close();
                connected = true;
                break;
            }
        }

        // display a message if no ShinyBow is connected and exit
        private void SendCommand(string p)
        {
            if (!connected)
            {
                MessageBox.Show("No Switcher Detected!", "Error", MessageBoxButtons.OK);

                this.Close();

                return;
            }
            serialPort1.WriteTimeout = 500;
            serialPort1.Open();
            serialPort1.WriteLine(p);
            serialPort1.DiscardOutBuffer();
            serialPort1.Close();
        }


        /************************************************************
         * Help Button Functions
         * **********************************************************/
        private void help_MouseClick(object sender, MouseEventArgs e)
        {
            can_see_help = !can_see_help;
            if (can_see_help)
                help.BorderStyle = BorderStyle.Fixed3D;
            else
                help.BorderStyle = BorderStyle.None;

            help_instructions.Visible = can_see_help;
        }
    }
}