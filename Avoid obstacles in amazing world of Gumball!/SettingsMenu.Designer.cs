namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.settigns_12_05_2025;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // returnBTN
            // 
            this.returnBTN.BackColor = System.Drawing.Color.Transparent;
            this.returnBTN.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.return_12_05_2025;
            this.returnBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBTN.FlatAppearance.BorderSize = 0;
            this.returnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.returnBTN.Location = new System.Drawing.Point(195, 598);
            this.returnBTN.Name = "returnBTN";
            this.returnBTN.Size = new System.Drawing.Size(372, 60);
            this.returnBTN.TabIndex = 4;
            this.returnBTN.UseVisualStyleBackColor = false;
            this.returnBTN.Click += new System.EventHandler(this.returnBTN_Click);
            this.returnBTN.MouseEnter += new System.EventHandler(this.BTN_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.Buttons_sound_12_05_2025;
            this.pictureBox2.Location = new System.Drawing.Point(12, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(438, 203);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(284, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 10;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(734, 670);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.returnBTN);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button returnBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}