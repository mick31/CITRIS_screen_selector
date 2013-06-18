using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenSelector
{
   

    public partial class ScreenSelector : Form
    {
        int currentOutput;

        int outputTag;
        int inputTag;

        List<Button> inputs;
        List<Button> outputs;
        List<Button> others;

        public ScreenSelector()
        {
            currentOutput = 0;

            outputTag = 1;
            inputTag = 1;

            inputs = new List<Button>();
            outputs = new List<Button>();
            others = new List<Button>();

            InitializeComponent();

            InitializeButton(TV2, ButtonType.OUTPUT);
            InitializeButton(TV1, ButtonType.OUTPUT);
            InitializeButton(Podium, ButtonType.OUTPUT);
            InitializeButton(presentation, ButtonType.OUTPUT);
            InitializeButton(recording, ButtonType.OUTPUT);

            InitializeButton(resPC1, ButtonType.INPUT);
            InitializeButton(resPC2, ButtonType.INPUT);
            InitializeButton(docCam, ButtonType.INPUT);
            InitializeButton(laptop, ButtonType.INPUT);
            InitializeButton(polycomOut, ButtonType.INPUT);

            InitializeButton(offOutputs, ButtonType.OTHER);
            offOutputs.Click += new EventHandler(offOutputs_Click);
        }

        private void InitializeButton(Button button, ButtonType type)
        {
            ButtonTag tag;
            
            switch (type)
            {
                case ButtonType.OUTPUT:
                    tag = new ButtonTag(type, outputTag++);
                    button.Click += new EventHandler(Handle_Button);
                    button.Tag = tag;
                    outputs.Add(button);
                    break;
                case ButtonType.INPUT:
                    tag = new ButtonTag(type, inputTag++);
                    button.Click += new EventHandler(Handle_Button);
                    button.Tag = tag;
                    button.Visible = false;
                    inputs.Add(button);
                    break;
                case ButtonType.OTHER:
                    tag = new ButtonTag(type, -1);
                    button.Tag = tag;
                    others.Add(button);
                    break;
                default:
                    break;
            }
        }

        private void Handle_Button(object sender, EventArgs e)
        {
            if (!(sender is Button))
                // Do something fancier here
                return;

            Button target = (Button)sender;

            if (!(target.Tag is ButtonTag))
                return;

            ButtonTag tag = (ButtonTag)target.Tag;

            if (tag.GetButtonType == ButtonType.INPUT)
            {
                // Send input switch command to SB
                SendCommand(String.Format("Output0{1} 0{0};", tag.GetIndex, currentOutput).Trim());

                // Hide the inputs
                foreach (Button b in inputs)
                {
                    b.Visible = false;
                }
            }
            else if (tag.GetButtonType == ButtonType.OUTPUT)
            {
                currentOutput = tag.GetIndex;

                // Show the inputs
                foreach (Button b in inputs)
                {
                    b.Visible = true;
                }
            }
        }

        private void offOutputs_Click(object sender, EventArgs e)
        {
            SendCommand(String.Format("Outputall 00;").Trim());
        }

        private void SendCommand(string p)
        {
            serialPort1.WriteTimeout = 500;
            serialPort1.Open();
            serialPort1.WriteLine(p);
            serialPort1.DiscardOutBuffer();
            serialPort1.Close();
        }
    }

    public enum ButtonType { INPUT, OUTPUT, OTHER }

    public class ButtonTag
    {
        private ButtonType _type;
        private int _index;

        public ButtonType GetButtonType { get { return _type; } }
        public int GetIndex { get { return _index; } }

        public ButtonTag(ButtonType type, int index)
        {
            _type = type;
            _index = index;
        }
    }
}
