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

        List<Label> label_obj;
        List<PictureBox> picbox_obj;

        List<Label> outputs;
        List<Image> orig_outputs;
        public enum LabelType { INPUT, OUTPUT, OTHER }

        public class LabelTag
        {
            private LabelType _type;
            private int _index;
            private string _display_text;
            private Image _highlight_img;
            private Image _norm_img;

            public LabelType GetLabelType { get { return _type; } }
            public int GetIndex { get { return _index; } }
            public string GetDisplayText { get { return _display_text; } }
            public Image GetHighImage { get { return _highlight_img; } }
            public Image GetNormImage { get { return _norm_img; } }

            public LabelTag(LabelType type, int index, string display_text, Image highlight_img, Image norm_img)
            {
                _type = type;
                _index = index;
                _display_text = display_text;
                _highlight_img = highlight_img;
                _norm_img = norm_img;
            }
        }

        public ScreenSelector()
        {
            InitializeComponent();
            InitializeConnection();

            label_obj = new List<Label>();
            picbox_obj = new List<PictureBox>();
            outputs = new List<Label>();
            orig_outputs = new List<Image>();

            Image output_highlight = tv1_display.Image;

            Image laptop_highlight = Image.FromFile("ScreenSelector_Laptop-Highlight.png");
            Image doccam_highlight = Image.FromFile("ScreenSelector_DocCam-Highlight.png");
            Image ploycom_highlight = Image.FromFile("ScreenSelector_PolyComm-Highlight.png");
            Image desktop1_highlight = Image.FromFile("ScreenSelector_Desktop1-Highlight.png");
            Image desktop2_highlight = Image.FromFile("ScreenSelector_Desktop2-Highlight.png");

            label_obj.Add(TitleBar);
            label_obj.Add(Sources);
            label_obj.Add(Displays);
            label_obj.Add(tv1_display);
            label_obj.Add(help);
            label_obj.Add(alloff);
            label_obj.Add(tv2_display);
            label_obj.Add(podium);
            label_obj.Add(laptop);
            label_obj.Add(Main_Help_Instructions);
            label_obj.Add(polycom_out);
            label_obj.Add(doccam);
            label_obj.Add(desktop1);
            label_obj.Add(polycom_in);
            label_obj.Add(desktop2);

            picbox_obj.Add(TV1_Border);
            picbox_obj.Add(TV2_Border);
            picbox_obj.Add(pointingFinger);
            picbox_obj.Add(audience);
            picbox_obj.Add(podium_frame);
            picbox_obj.Add(podium_pic);
            picbox_obj.Add(Poly_Comm_Frame);

            // initialize outputs
            InitializeLabel(tv1_display, LabelType.OUTPUT, 4, "No Output", output_highlight);
            InitializeLabel(tv2_display, LabelType.OUTPUT, 5, "No Output", output_highlight);
            InitializeLabel(podium, LabelType.OUTPUT, 6, "No Output", output_highlight);
            InitializeLabel(polycom_out, LabelType.OUTPUT, 7, "No Output", output_highlight);

            // initialize inputs
            InitializeLabel(laptop, LabelType.INPUT, 1, "", laptop_highlight);
            InitializeLabel(doccam, LabelType.INPUT, 1, "", doccam_highlight);
            InitializeLabel(polycom_in, LabelType.INPUT, 1, "", ploycom_highlight);
            InitializeLabel(desktop1, LabelType.INPUT, 1, "", desktop1_highlight);
            InitializeLabel(desktop2, LabelType.INPUT, 1, "", desktop2_highlight);

            audience.BackColor = Color.Transparent;
            audience.Parent = carpet;
            audience.Location = new Point(0, 0);

            alloff.BackColor = Color.Transparent;
            alloff.Parent = podium_pic;
            alloff.Location = new Point(30, 30);
        }

        // takes a label to tag, the type og tag, the index for the switcher matrix port, and the text to be displayed by default
        private void InitializeLabel(Label label, LabelType type, int index, string displat_text, Image highlight_img)
        {
            LabelTag tag;

            switch (type)
            {
                case LabelType.OUTPUT:
                    tag = new LabelTag(type, index, displat_text, highlight_img, label.Image);
                    label.Tag = tag;
                    label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.output_MouseClick);
                    outputs.Add(label);

                    // store original output properties
                    orig_outputs.Add(label.Image);
                    break;
                case LabelType.INPUT:
                    tag = new LabelTag(type, index, displat_text, highlight_img, label.Image);
                    label.Tag = tag;
                    label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.input_MouseDown);
                    label.MouseLeave += new System.EventHandler(this.input_MouseLeave);
                    label.MouseHover += new System.EventHandler(this.input_MouseHover);
                    label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
                    label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.input_MouseUp);
                    break;
                case LabelType.OTHER:
                    tag = new LabelTag(type, -1, displat_text, highlight_img, label.Image);
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
            //easter egg
            mick1.Visible = false;
            ian1.Visible = false;
            nabil1.Visible = false;
            mick2.Visible = false;
            ian2.Visible = false;
            nabil2.Visible = false;

            if (e.Button == MouseButtons.Left)
            {
                Label cur_input = (Label)sender;
                cur_input.BringToFront();
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

                //foreach (Label n in label_obj)
                //{
                //    if (cur_input.Bounds.IntersectsWith((Rectangle)n.ClientRectangle))
                //    {
                //        cur_input.BackColor = Color.Transparent;
                //        cur_input.Parent = n;
                //    }
                //}

                //foreach (PictureBox n in picbox_obj)
                //{
                //    if (cur_input.Bounds.IntersectsWith((Rectangle)n.ClientRectangle))
                //    {
                //        cur_input.BackColor = Color.Transparent;
                //        cur_input.Parent = n;
                //    }
                //}

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
                   // SendCommand(String.Format("Output0{1} 0{0};", inTag.GetIndex, outTag.GetIndex).Trim());

                    // change outputs display
                    outputs[cur_out].Image = inTag.GetNormImage;
                    outputs[cur_out].TextAlign = ContentAlignment.BottomCenter;
                    outputs[cur_out].Text = (String)inTag.GetDisplayText;

                    // easter egg check
                    if (cur_input == polycom_in && outputs[cur_out] == polycom_out)
                        key.Visible = true;

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
            LabelTag cur_tag = (LabelTag)cur_input.Tag;

            cur_input.Image = cur_tag.GetHighImage;
            cur_input.Tag = cur_tag;
            
            pointingFinger.Visible = true;
        }

        private void input_MouseLeave(object sender, EventArgs e)
        {
            Label cur_input = (Label)sender;
            LabelTag cur_tag = (LabelTag)cur_input.Tag;

            cur_input.Image = cur_tag.GetNormImage;
            cur_input.Tag = cur_tag;
            
            pointingFinger.Visible = false;
        }


        private void output_MouseClick(object sender, EventArgs e)
        {
            Label cur_output = (Label)sender;
            LabelTag cur_tag = (LabelTag)cur_output.Tag;

            //easter egg
            mick1.Visible = false;
            ian1.Visible = false;
            nabil1.Visible = false;
            mick2.Visible = false;
            ian2.Visible = false;
            nabil2.Visible = false;
            if (cur_output == polycom_out && cur_output.Image == polycom_in.Image)
                key.Visible = false;

           // SendCommand(String.Format("Output0{0} 00;", cur_tag.GetIndex).Trim());
            cur_output.Image = cur_tag.GetNormImage;
            cur_output.TextAlign = ContentAlignment.MiddleCenter;
            cur_output.Text = "No Source";
        }

        // turn off all ShinyBow outputs
        private void offOutputs_Click(object sender, MouseEventArgs e)
        {
           // SendCommand(String.Format("Outputall 00;").Trim());
            for (int cur_out = 0; cur_out < outputs.Count; cur_out++)
            {
                outputs[cur_out].Image = orig_outputs[cur_out];
                outputs[cur_out].TextAlign = ContentAlignment.MiddleCenter;
                outputs[cur_out].Text = "No Source";
            }

            //easter egg
            mick1.Visible = false;
            ian1.Visible = false;
            nabil1.Visible = false;
            mick2.Visible = false;
            ian2.Visible = false;
            nabil2.Visible = false;
            key.Visible = false;
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
                MessageBox.Show("No Switcher Detected! Please Contact CITRIS\n tech lab: (831)502-7399", "Error", MessageBoxButtons.OK);

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
            {
                help.BorderStyle = BorderStyle.Fixed3D;
                help.BackColor = Color.LightGray;
            }
            else
            {
                help.BorderStyle = BorderStyle.None;
                help.BackColor = Color.Transparent;
            }

            help_instructions.Visible = can_see_help;
        }


        /************************************************************
         * Easter Egg Functions
         * **********************************************************/
        private void egg_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox cur_input = (PictureBox)sender;
                cur_input.BringToFront();
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

        private void egg_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                PictureBox cur_input = (PictureBox)sender;
                Point newPoint = cur_input.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);

                //if (cur_input.Bounds.IntersectsWith(cabinet1.Bounds))
                //{
                //    cur_input.BackColor = Color.Transparent;
                //    cur_input.Parent = cabinet1;
                //}


                //if (cur_input.Bounds.IntersectsWith(cabinet2.Bounds))
                //{
                //    cur_input.BackColor = Color.Transparent;
                //    cur_input.Parent = cabinet2;
                //}

                cur_input.Location = newPoint;
            }
        }

        private void egg_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox cur_input = (PictureBox)sender;

            if (cabinet1.Bounds.Contains(cur_input.Bounds))
            {
                // change display
                mick1.Visible = true;
                ian1.Visible = true;
                nabil1.Visible = true;
            }
            else if (cabinet2.Bounds.Contains(cur_input.Bounds))
            {
                // change display
                mick2.Visible = true;
                ian2.Visible = true;
                nabil2.Visible = true;
            }

            //reset button position
            isDragged = false;
            setHomePosition = true;
            cur_input.Location = ptHome;
        }
    }
}