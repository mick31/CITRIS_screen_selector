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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSelector));
            this.TitleBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TV2_Border = new System.Windows.Forms.PictureBox();
            this.k = new System.Windows.Forms.PictureBox();
            this.res_pc1 = new System.Windows.Forms.PictureBox();
            this.laptop = new System.Windows.Forms.PictureBox();
            this.pointingFinger = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tv1_display = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.help_instructions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TV2_Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.res_pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointingFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSize = true;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.Color.Black;
            this.TitleBar.Location = new System.Drawing.Point(484, 38);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(299, 42);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "Screen Selector";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inputs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(661, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Outputs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TV2_Border
            // 
            this.TV2_Border.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV2_Border.BackgroundImage")));
            this.TV2_Border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TV2_Border.Location = new System.Drawing.Point(322, 295);
            this.TV2_Border.Name = "TV2_Border";
            this.TV2_Border.Size = new System.Drawing.Size(372, 225);
            this.TV2_Border.TabIndex = 3;
            this.TV2_Border.TabStop = false;
            // 
            // k
            // 
            this.k.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("k.BackgroundImage")));
            this.k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.k.Location = new System.Drawing.Point(721, 295);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(372, 225);
            this.k.TabIndex = 6;
            this.k.TabStop = false;
            // 
            // res_pc1
            // 
            this.res_pc1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("res_pc1.BackgroundImage")));
            this.res_pc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.res_pc1.Location = new System.Drawing.Point(49, 411);
            this.res_pc1.Name = "res_pc1";
            this.res_pc1.Size = new System.Drawing.Size(107, 109);
            this.res_pc1.TabIndex = 11;
            this.res_pc1.TabStop = false;
            this.res_pc1.MouseLeave += new System.EventHandler(this.respc1_MouseLeave);
            this.res_pc1.MouseHover += new System.EventHandler(this.respc1_MouseHover);
            // 
            // laptop
            // 
            this.laptop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laptop.BackgroundImage")));
            this.laptop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.laptop.Location = new System.Drawing.Point(49, 301);
            this.laptop.Name = "laptop";
            this.laptop.Size = new System.Drawing.Size(107, 108);
            this.laptop.TabIndex = 12;
            this.laptop.TabStop = false;
            this.laptop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.laptop_MouseDown);
            this.laptop.MouseLeave += new System.EventHandler(this.laptop_MouseLeave);
            this.laptop.MouseHover += new System.EventHandler(this.laptop_MouseHover);
            this.laptop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.laptop_MouseMove);
            this.laptop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.laptop_MouseUp);
            // 
            // pointingFinger
            // 
            this.pointingFinger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pointingFinger.BackgroundImage")));
            this.pointingFinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pointingFinger.Location = new System.Drawing.Point(180, 229);
            this.pointingFinger.Name = "pointingFinger";
            this.pointingFinger.Size = new System.Drawing.Size(115, 53);
            this.pointingFinger.TabIndex = 13;
            this.pointingFinger.TabStop = false;
            this.pointingFinger.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 757);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1263, 228);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tv1_display
            // 
            this.tv1_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv1_display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tv1_display.Image = ((System.Drawing.Image)(resources.GetObject("tv1_display.Image")));
            this.tv1_display.Location = new System.Drawing.Point(328, 301);
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
            this.help.Location = new System.Drawing.Point(1128, 9);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(124, 163);
            this.help.TabIndex = 17;
            this.help.Text = "Help";
            this.help.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.help.MouseLeave += new System.EventHandler(this.help_MouseLeave);
            this.help.MouseHover += new System.EventHandler(this.help_MouseHover);
            // 
            // help_instructions
            // 
            this.help_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_instructions.Location = new System.Drawing.Point(322, 93);
            this.help_instructions.Multiline = true;
            this.help_instructions.Name = "help_instructions";
            this.help_instructions.ReadOnly = true;
            this.help_instructions.Size = new System.Drawing.Size(630, 108);
            this.help_instructions.TabIndex = 18;
            this.help_instructions.Text = resources.GetString("help_instructions.Text");
            this.help_instructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.help_instructions.Visible = false;
            // 
            // ScreenSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 986);
            this.Controls.Add(this.help_instructions);
            this.Controls.Add(this.help);
            this.Controls.Add(this.res_pc1);
            this.Controls.Add(this.laptop);
            this.Controls.Add(this.tv1_display);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pointingFinger);
            this.Controls.Add(this.k);
            this.Controls.Add(this.TV2_Border);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I/O Selector";
            ((System.ComponentModel.ISupportInitialize)(this.TV2_Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.res_pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointingFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox TV2_Border;
        private System.Windows.Forms.PictureBox k;
        private System.Windows.Forms.PictureBox res_pc1;
        private System.Windows.Forms.PictureBox laptop;
        private System.Windows.Forms.PictureBox pointingFinger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tv1_display;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.TextBox help_instructions;
    }
}

