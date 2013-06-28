namespace CITRIS_Screen_Selector_Drag_and_Drop
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
            this.TitleBar = new System.Windows.Forms.Label();
            this.Sources = new System.Windows.Forms.Label();
            this.Displays = new System.Windows.Forms.Label();
            this.TV2_Border = new System.Windows.Forms.PictureBox();
            this.k = new System.Windows.Forms.PictureBox();
            this.pointingFinger = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tv1_display = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.help_instructions = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.alloff = new System.Windows.Forms.Label();
            this.tv2_display = new System.Windows.Forms.Label();
            this.podium = new System.Windows.Forms.Label();
            this.podium_frame = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.laptop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.polycom_out = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TV2_Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointingFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podium_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSize = true;
            this.TitleBar.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.Color.Black;
            this.TitleBar.Location = new System.Drawing.Point(493, 9);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(319, 44);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "Screen Selector";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sources
            // 
            this.Sources.AutoSize = true;
            this.Sources.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sources.Location = new System.Drawing.Point(19, 207);
            this.Sources.Name = "Sources";
            this.Sources.Size = new System.Drawing.Size(156, 42);
            this.Sources.TabIndex = 1;
            this.Sources.Text = "Sources";
            this.Sources.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Displays
            // 
            this.Displays.AutoSize = true;
            this.Displays.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displays.Location = new System.Drawing.Point(550, 207);
            this.Displays.Name = "Displays";
            this.Displays.Size = new System.Drawing.Size(160, 42);
            this.Displays.TabIndex = 2;
            this.Displays.Text = "Displays";
            this.Displays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TV2_Border
            // 
            this.TV2_Border.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV2_Border.BackgroundImage")));
            this.TV2_Border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TV2_Border.Location = new System.Drawing.Point(257, 289);
            this.TV2_Border.Name = "TV2_Border";
            this.TV2_Border.Size = new System.Drawing.Size(372, 225);
            this.TV2_Border.TabIndex = 3;
            this.TV2_Border.TabStop = false;
            // 
            // k
            // 
            this.k.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("k.BackgroundImage")));
            this.k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.k.Location = new System.Drawing.Point(639, 289);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(372, 225);
            this.k.TabIndex = 6;
            this.k.TabStop = false;
            // 
            // pointingFinger
            // 
            this.pointingFinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pointingFinger.BackgroundImage")));
            this.pointingFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pointingFinger.Location = new System.Drawing.Point(193, 207);
            this.pointingFinger.Name = "pointingFinger";
            this.pointingFinger.Size = new System.Drawing.Size(104, 42);
            this.pointingFinger.TabIndex = 13;
            this.pointingFinger.TabStop = false;
            this.pointingFinger.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 820);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1263, 165);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tv1_display
            // 
            this.tv1_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv1_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tv1_display.Image = ((System.Drawing.Image)(resources.GetObject("tv1_display.Image")));
            this.tv1_display.Location = new System.Drawing.Point(263, 295);
            this.tv1_display.Name = "tv1_display";
            this.tv1_display.Size = new System.Drawing.Size(360, 205);
            this.tv1_display.TabIndex = 16;
            this.tv1_display.Text = "No Input";
            this.tv1_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Default;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Image = ((System.Drawing.Image)(resources.GetObject("help.Image")));
            this.help.Location = new System.Drawing.Point(1162, 9);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(90, 119);
            this.help.TabIndex = 17;
            this.help.Text = "Help";
            this.help.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.help_MouseClick);
            // 
            // help_instructions
            // 
            this.help_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.help_instructions.Location = new System.Drawing.Point(263, 64);
            this.help_instructions.Multiline = true;
            this.help_instructions.Name = "help_instructions";
            this.help_instructions.ReadOnly = true;
            this.help_instructions.Size = new System.Drawing.Size(774, 140);
            this.help_instructions.TabIndex = 18;
            this.help_instructions.Text = resources.GetString("help_instructions.Text");
            this.help_instructions.Visible = false;
            // 
            // alloff
            // 
            this.alloff.BackColor = System.Drawing.Color.Transparent;
            this.alloff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alloff.Image = ((System.Drawing.Image)(resources.GetObject("alloff.Image")));
            this.alloff.Location = new System.Drawing.Point(583, 603);
            this.alloff.Name = "alloff";
            this.alloff.Size = new System.Drawing.Size(159, 151);
            this.alloff.TabIndex = 19;
            this.alloff.Text = "Power Off All Displays";
            this.alloff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.alloff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.offOutputs_Click);
            // 
            // tv2_display
            // 
            this.tv2_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv2_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tv2_display.Image = ((System.Drawing.Image)(resources.GetObject("tv2_display.Image")));
            this.tv2_display.Location = new System.Drawing.Point(645, 295);
            this.tv2_display.Name = "tv2_display";
            this.tv2_display.Size = new System.Drawing.Size(360, 205);
            this.tv2_display.TabIndex = 20;
            this.tv2_display.Text = "No Input";
            this.tv2_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // podium
            // 
            this.podium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.podium.Image = ((System.Drawing.Image)(resources.GetObject("podium.Image")));
            this.podium.Location = new System.Drawing.Point(1055, 386);
            this.podium.Name = "podium";
            this.podium.Size = new System.Drawing.Size(180, 138);
            this.podium.TabIndex = 21;
            this.podium.Text = "No Input";
            this.podium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // podium_frame
            // 
            this.podium_frame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("podium_frame.BackgroundImage")));
            this.podium_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.podium_frame.Location = new System.Drawing.Point(1048, 374);
            this.podium_frame.Name = "podium_frame";
            this.podium_frame.Size = new System.Drawing.Size(195, 162);
            this.podium_frame.TabIndex = 22;
            this.podium_frame.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1023, 531);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 311);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // laptop
            // 
            this.laptop.BackColor = System.Drawing.Color.Transparent;
            this.laptop.Image = ((System.Drawing.Image)(resources.GetObject("laptop.Image")));
            this.laptop.Location = new System.Drawing.Point(39, 249);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(107, 108);
            this.laptop.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "(Drag and drop desired source onto the desired display.)";
            // 
            // polycom_out
            // 
            this.polycom_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polycom_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polycom_out.Image = ((System.Drawing.Image)(resources.GetObject("polycom_out.Image")));
            this.polycom_out.Location = new System.Drawing.Point(1048, 238);
            this.polycom_out.Name = "polycom_out";
            this.polycom_out.Size = new System.Drawing.Size(198, 133);
            this.polycom_out.TabIndex = 26;
            this.polycom_out.Text = "   No    Input";
            this.polycom_out.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(18, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 108);
            this.label2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(18, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 108);
            this.label3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(39, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 108);
            this.label4.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(18, 706);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 108);
            this.label5.TabIndex = 30;
            // 
            // ScreenSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 986);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.polycom_out);
            this.Controls.Add(this.help_instructions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alloff);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.podium);
            this.Controls.Add(this.podium_frame);
            this.Controls.Add(this.tv2_display);
            this.Controls.Add(this.help);
            this.Controls.Add(this.tv1_display);
            this.Controls.Add(this.pointingFinger);
            this.Controls.Add(this.k);
            this.Controls.Add(this.TV2_Border);
            this.Controls.Add(this.Displays);
            this.Controls.Add(this.Sources);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            ((System.ComponentModel.ISupportInitialize)(this.TV2_Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointingFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podium_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.Label Sources;
        private System.Windows.Forms.Label Displays;
        private System.Windows.Forms.PictureBox TV2_Border;
        private System.Windows.Forms.PictureBox k;
        private System.Windows.Forms.PictureBox pointingFinger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tv1_display;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.TextBox help_instructions;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label alloff;
        private System.Windows.Forms.Label tv2_display;
        private System.Windows.Forms.Label podium;
        private System.Windows.Forms.PictureBox podium_frame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label laptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label polycom_out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

