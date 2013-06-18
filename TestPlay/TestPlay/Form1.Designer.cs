﻿namespace ScreenSelector
{
    partial class ScreenSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSelector));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TV2 = new System.Windows.Forms.Button();
            this.TV1 = new System.Windows.Forms.Button();
            this.Podium = new System.Windows.Forms.Button();
            this.presentation = new System.Windows.Forms.Button();
            this.recording = new System.Windows.Forms.Button();
            this.resPC1 = new System.Windows.Forms.Button();
            this.resPC2 = new System.Windows.Forms.Button();
            this.docCam = new System.Windows.Forms.Button();
            this.polycomOut = new System.Windows.Forms.Button();
            this.laptop = new System.Windows.Forms.Button();
            this.offOutputs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TV2
            // 
            this.TV2.BackColor = System.Drawing.Color.White;
            this.TV2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV2.BackgroundImage")));
            this.TV2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV2.Location = new System.Drawing.Point(24, 12);
            this.TV2.Name = "TV2";
            this.TV2.Size = new System.Drawing.Size(285, 211);
            this.TV2.TabIndex = 0;
            this.TV2.Text = "TV 2";
            this.TV2.UseVisualStyleBackColor = false;
            // 
            // TV1
            // 
            this.TV1.BackColor = System.Drawing.Color.White;
            this.TV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV1.BackgroundImage")));
            this.TV1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV1.Location = new System.Drawing.Point(326, 12);
            this.TV1.Name = "TV1";
            this.TV1.Size = new System.Drawing.Size(285, 211);
            this.TV1.TabIndex = 1;
            this.TV1.Text = "TV 1";
            this.TV1.UseVisualStyleBackColor = false;
            // 
            // Podium
            // 
            this.Podium.BackColor = System.Drawing.Color.White;
            this.Podium.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Podium.Location = new System.Drawing.Point(617, 122);
            this.Podium.Name = "Podium";
            this.Podium.Size = new System.Drawing.Size(143, 101);
            this.Podium.TabIndex = 2;
            this.Podium.Text = "Podium";
            this.Podium.UseVisualStyleBackColor = false;
            // 
            // presentation
            // 
            this.presentation.BackColor = System.Drawing.Color.White;
            this.presentation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.presentation.Location = new System.Drawing.Point(617, 12);
            this.presentation.Name = "presentation";
            this.presentation.Size = new System.Drawing.Size(143, 104);
            this.presentation.TabIndex = 3;
            this.presentation.Text = "Polycom Presentation";
            this.presentation.UseVisualStyleBackColor = false;
            // 
            // recording
            // 
            this.recording.BackColor = System.Drawing.Color.White;
            this.recording.Location = new System.Drawing.Point(766, 77);
            this.recording.Name = "recording";
            this.recording.Size = new System.Drawing.Size(75, 80);
            this.recording.TabIndex = 4;
            this.recording.Text = "Recording";
            this.recording.UseVisualStyleBackColor = false;
            // 
            // resPC1
            // 
            this.resPC1.BackColor = System.Drawing.Color.White;
            this.resPC1.Location = new System.Drawing.Point(228, 272);
            this.resPC1.Name = "resPC1";
            this.resPC1.Size = new System.Drawing.Size(75, 29);
            this.resPC1.TabIndex = 5;
            this.resPC1.Text = "Res PC 1";
            this.resPC1.UseVisualStyleBackColor = false;
            // 
            // resPC2
            // 
            this.resPC2.BackColor = System.Drawing.Color.White;
            this.resPC2.Location = new System.Drawing.Point(309, 272);
            this.resPC2.Name = "resPC2";
            this.resPC2.Size = new System.Drawing.Size(75, 29);
            this.resPC2.TabIndex = 6;
            this.resPC2.Text = "Res PC 2";
            this.resPC2.UseVisualStyleBackColor = false;
            // 
            // docCam
            // 
            this.docCam.BackColor = System.Drawing.Color.White;
            this.docCam.Location = new System.Drawing.Point(390, 272);
            this.docCam.Name = "docCam";
            this.docCam.Size = new System.Drawing.Size(75, 29);
            this.docCam.TabIndex = 7;
            this.docCam.Text = "Doc Cam";
            this.docCam.UseVisualStyleBackColor = false;
            // 
            // polycomOut
            // 
            this.polycomOut.BackColor = System.Drawing.Color.White;
            this.polycomOut.Location = new System.Drawing.Point(471, 272);
            this.polycomOut.Name = "polycomOut";
            this.polycomOut.Size = new System.Drawing.Size(75, 29);
            this.polycomOut.TabIndex = 8;
            this.polycomOut.Text = "Polycom";
            this.polycomOut.UseVisualStyleBackColor = false;
            // 
            // laptop
            // 
            this.laptop.BackColor = System.Drawing.Color.White;
            this.laptop.Location = new System.Drawing.Point(147, 272);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(75, 29);
            this.laptop.TabIndex = 10;
            this.laptop.Text = "Laptop";
            this.laptop.UseVisualStyleBackColor = false;
            // 
            // offOutputs
            // 
            this.offOutputs.BackColor = System.Drawing.Color.White;
            this.offOutputs.Location = new System.Drawing.Point(617, 270);
            this.offOutputs.Name = "offOutputs";
            this.offOutputs.Size = new System.Drawing.Size(143, 31);
            this.offOutputs.TabIndex = 12;
            this.offOutputs.Tag = -1;
            this.offOutputs.Text = "ALL OFF";
            this.offOutputs.UseVisualStyleBackColor = false;
            // 
            // ScreenSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 646);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.recording);
            this.Controls.Add(this.polycomOut);
            this.Controls.Add(this.offOutputs);
            this.Controls.Add(this.docCam);
            this.Controls.Add(this.presentation);
            this.Controls.Add(this.resPC2);
            this.Controls.Add(this.resPC1);
            this.Controls.Add(this.Podium);
            this.Controls.Add(this.TV1);
            this.Controls.Add(this.TV2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSelector";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I/O Select";
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button TV2;
        private System.Windows.Forms.Button TV1;
        private System.Windows.Forms.Button Podium;
        private System.Windows.Forms.Button presentation;
        private System.Windows.Forms.Button resPC1;
        private System.Windows.Forms.Button resPC2;
        private System.Windows.Forms.Button docCam;
        private System.Windows.Forms.Button polycomOut;
        private System.Windows.Forms.Button laptop;

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button recording;
        private System.Windows.Forms.Button offOutputs;

    }
}

