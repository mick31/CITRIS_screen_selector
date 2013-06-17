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
            this.Polycom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TV2
            // 
            this.TV2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV2.BackgroundImage")));
            this.TV2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV2.Location = new System.Drawing.Point(65, 74);
            this.TV2.Name = "TV2";
            this.TV2.Size = new System.Drawing.Size(285, 211);
            this.TV2.TabIndex = 0;
            this.TV2.Text = "TV 2";
            this.TV2.UseVisualStyleBackColor = true;
            // 
            // TV1
            // 
            this.TV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TV1.BackgroundImage")));
            this.TV1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TV1.Location = new System.Drawing.Point(367, 74);
            this.TV1.Name = "TV1";
            this.TV1.Size = new System.Drawing.Size(285, 211);
            this.TV1.TabIndex = 1;
            this.TV1.Text = "TV 1";
            this.TV1.UseVisualStyleBackColor = true;
            // 
            // Podium
            // 
            this.Podium.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Podium.Location = new System.Drawing.Point(699, 205);
            this.Podium.Name = "Podium";
            this.Podium.Size = new System.Drawing.Size(123, 80);
            this.Podium.TabIndex = 2;
            this.Podium.Text = "Podium";
            this.Podium.UseVisualStyleBackColor = true;
            // 
            // Polycom
            // 
            this.Polycom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Polycom.Location = new System.Drawing.Point(689, 74);
            this.Polycom.Name = "Polycom";
            this.Polycom.Size = new System.Drawing.Size(143, 104);
            this.Polycom.TabIndex = 3;
            this.Polycom.Text = "Polycom";
            this.Polycom.UseVisualStyleBackColor = true;
            this.Polycom.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 646);
            this.Controls.Add(this.Polycom);
            this.Controls.Add(this.Podium);
            this.Controls.Add(this.TV1);
            this.Controls.Add(this.TV2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I/O Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TV2;
        private System.Windows.Forms.Button TV1;
        private System.Windows.Forms.Button Podium;
        private System.Windows.Forms.Button Polycom;

    }
}

