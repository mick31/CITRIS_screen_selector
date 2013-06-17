namespace TestPlay
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TV2 = new System.Windows.Forms.Button();
            this.TV1 = new System.Windows.Forms.Button();
            this.Podium = new System.Windows.Forms.Button();
            this.presentation = new System.Windows.Forms.Button();
            this.outputGroup = new System.Windows.Forms.Panel();
            this.resPC1 = new System.Windows.Forms.Button();
            this.resPC2 = new System.Windows.Forms.Button();
            this.docCam = new System.Windows.Forms.Button();
            this.polycomOut = new System.Windows.Forms.Button();
            this.laptop = new System.Windows.Forms.Button();
            this.inputs = new System.Windows.Forms.Panel();
            this.outputGroup.SuspendLayout();
            this.inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TV2
            // 
            this.TV2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV2.BackgroundImage")));
            this.TV2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV2.Location = new System.Drawing.Point(20, 17);
            this.TV2.Name = "TV2";
            this.TV2.Size = new System.Drawing.Size(285, 211);
            this.TV2.TabIndex = 0;
            this.TV2.Text = "TV 2";
            this.TV2.UseVisualStyleBackColor = true;
            this.TV2.Click += new System.EventHandler(this.Handle_Click);
            // 
            // TV1
            // 
            this.TV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV1.BackgroundImage")));
            this.TV1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV1.Location = new System.Drawing.Point(322, 17);
            this.TV1.Name = "TV1";
            this.TV1.Size = new System.Drawing.Size(285, 211);
            this.TV1.TabIndex = 1;
            this.TV1.Text = "TV 1";
            this.TV1.UseVisualStyleBackColor = true;
            this.TV1.Click += new System.EventHandler(this.Handle_Click);
            // 
            // Podium
            // 
            this.Podium.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Podium.Location = new System.Drawing.Point(654, 148);
            this.Podium.Name = "Podium";
            this.Podium.Size = new System.Drawing.Size(123, 80);
            this.Podium.TabIndex = 2;
            this.Podium.Text = "Podium";
            this.Podium.UseVisualStyleBackColor = true;
            this.Podium.Click += new System.EventHandler(this.Handle_Click);
            // 
            // presentation
            // 
            this.presentation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.presentation.Location = new System.Drawing.Point(644, 17);
            this.presentation.Name = "presentation";
            this.presentation.Size = new System.Drawing.Size(143, 104);
            this.presentation.TabIndex = 3;
            this.presentation.Text = "Polycom Presentation";
            this.presentation.UseVisualStyleBackColor = true;
            this.presentation.Click += new System.EventHandler(this.Handle_Click);
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.presentation);
            this.outputGroup.Controls.Add(this.Podium);
            this.outputGroup.Controls.Add(this.TV1);
            this.outputGroup.Controls.Add(this.TV2);
            this.outputGroup.Location = new System.Drawing.Point(45, 57);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(811, 253);
            this.outputGroup.TabIndex = 4;
            // 
            // resPC1
            // 
            this.resPC1.Location = new System.Drawing.Point(102, 15);
            this.resPC1.Name = "resPC1";
            this.resPC1.Size = new System.Drawing.Size(75, 29);
            this.resPC1.TabIndex = 5;
            this.resPC1.Text = "Res PC 1";
            this.resPC1.UseVisualStyleBackColor = true;
            this.resPC1.Click += new System.EventHandler(this.Handle_Click);
            // 
            // resPC2
            // 
            this.resPC2.Location = new System.Drawing.Point(183, 15);
            this.resPC2.Name = "resPC2";
            this.resPC2.Size = new System.Drawing.Size(75, 29);
            this.resPC2.TabIndex = 6;
            this.resPC2.Text = "Res PC 2";
            this.resPC2.UseVisualStyleBackColor = true;
            this.resPC2.Click += new System.EventHandler(this.Handle_Click);
            // 
            // docCam
            // 
            this.docCam.Location = new System.Drawing.Point(264, 15);
            this.docCam.Name = "docCam";
            this.docCam.Size = new System.Drawing.Size(75, 29);
            this.docCam.TabIndex = 7;
            this.docCam.Text = "Doc Cam";
            this.docCam.UseVisualStyleBackColor = true;
            this.docCam.Click += new System.EventHandler(this.Handle_Click);
            // 
            // polycomOut
            // 
            this.polycomOut.Location = new System.Drawing.Point(345, 15);
            this.polycomOut.Name = "polycomOut";
            this.polycomOut.Size = new System.Drawing.Size(75, 29);
            this.polycomOut.TabIndex = 8;
            this.polycomOut.Text = "Polycom";
            this.polycomOut.UseVisualStyleBackColor = true;
            this.polycomOut.Click += new System.EventHandler(this.Handle_Click);
            // 
            // laptop
            // 
            this.laptop.Location = new System.Drawing.Point(21, 15);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(75, 29);
            this.laptop.TabIndex = 10;
            this.laptop.Text = "Laptop";
            this.laptop.UseVisualStyleBackColor = true;
            this.laptop.Click += new System.EventHandler(this.Handle_Click);
            // 
            // inputs
            // 
            this.inputs.Controls.Add(this.laptop);
            this.inputs.Controls.Add(this.polycomOut);
            this.inputs.Controls.Add(this.docCam);
            this.inputs.Controls.Add(this.resPC2);
            this.inputs.Controls.Add(this.resPC1);
            this.inputs.Location = new System.Drawing.Point(132, 341);
            this.inputs.Name = "inputs";
            this.inputs.Size = new System.Drawing.Size(446, 64);
            this.inputs.TabIndex = 11;
            this.inputs.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 646);
            this.Controls.Add(this.inputs);
            this.Controls.Add(this.outputGroup);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I/O Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outputGroup.ResumeLayout(false);
            this.inputs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TV2;
        private System.Windows.Forms.Button TV1;
        private System.Windows.Forms.Button Podium;
        private System.Windows.Forms.Button presentation;
        private System.Windows.Forms.Panel outputGroup;
        private System.Windows.Forms.Button resPC1;
        private System.Windows.Forms.Button resPC2;
        private System.Windows.Forms.Button docCam;
        private System.Windows.Forms.Button polycomOut;
        private System.Windows.Forms.Button laptop;
        private System.Windows.Forms.Panel inputs;

    }
}

