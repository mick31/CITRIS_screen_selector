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
        Point ptOffset;
        Point ptHome;

        public ScreenSelector()
        {
            InitializeComponent();
        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }


        /************************************************************
         * Source to Display Functions
         * **********************************************************/
        private void laptop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = laptop.PointToScreen(new Point(e.X, e.Y));
                if (setHomePosition)
                {
                    setHomePosition = false;
                    ptHome = laptop.Location;
                }

                ptOffset = new Point();
                ptOffset.X = laptop.Location.X - ptStartPosition.X;
                ptOffset.Y = laptop.Location.Y - ptStartPosition.Y;
            }
            else
                isDragged = false;
        }

        private void laptop_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDragged)
            {
                Point newPoint = laptop.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                laptop.Location = newPoint;
            }
        }

        private void laptop_MouseUp(object sender, MouseEventArgs e)
        {
            if (tv1_display.Bounds.Contains(laptop.Bounds))
            {
                tv1_display.Image = laptop.BackgroundImage;
                tv1_display.Text = "Laptop";
            }

            //reset button position
            isDragged = false;
            setHomePosition = true;
            laptop.Location = ptHome;
        }

        private void laptop_MouseHover(object sender, EventArgs e)
        {
            laptop.BorderStyle = BorderStyle.FixedSingle;
            pointingFinger.Visible = true;
        }

        private void laptop_MouseLeave(object sender, EventArgs e)
        {
            laptop.BorderStyle = BorderStyle.None;
            pointingFinger.Visible = false;
        }

        private void respc1_MouseHover(object sender, EventArgs e)
        {
            res_pc1.BorderStyle = BorderStyle.FixedSingle;
            pointingFinger.Visible = true;
        }

        private void respc1_MouseLeave(object sender, EventArgs e)
        {
            res_pc1.BorderStyle = BorderStyle.None;
            pointingFinger.Visible = false;
        }


        /************************************************************
         * Help Button Functions
         * **********************************************************/
        private void help_MouseHover(object sender, EventArgs e)
        {
            help_instructions.Visible = true;
        }

        private void help_MouseLeave(object sender, EventArgs e)
        {
            help_instructions.Visible = false;
        }



        

        //private void laptop_DragDrop(object sender, DragEventArgs e)
        //{
        //    laptop.DoDragDrop(laptop, DragDropEffects.Copy | DragDropEffects.Move);
        //}

        //private void laptop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    laptop.DoDragDrop(laptop, DragDropEffects.Copy | DragDropEffects.Move);
        //}

        //private void tv1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        //{
        //    if (sender is Button)
        //        e.Effect = DragDropEffects.Copy;
        //    else
        //        e.Effect = DragDropEffects.None;
        //}

        //private void tv1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        //{
        //    if (!(e.Data is Button))
        //        MessageBox.Show("BLOWING IT");
            
        //    Button input_button = (Button)e.Data;
        //    TV1_Display.BackgroundImage = input_button.BackgroundImage;
        //    TV1_Display.Text = input_button.Text;

        //}
    }
}
