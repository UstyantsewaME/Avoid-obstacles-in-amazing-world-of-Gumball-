namespace Avoid_obstacles_in_amazing_world_of_Gumball_
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.returnBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBTN
            // 
            this.returnBTN.BackColor = System.Drawing.Color.Transparent;
            this.returnBTN.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.return_12_05_2025;
            this.returnBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.returnBTN.FlatAppearance.BorderSize = 0;
            this.returnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.returnBTN.Location = new System.Drawing.Point(0, 532);
            this.returnBTN.Name = "returnBTN";
            this.returnBTN.Size = new System.Drawing.Size(813, 29);
            this.returnBTN.TabIndex = 0;
            this.returnBTN.UseVisualStyleBackColor = false;
            this.returnBTN.Click += new System.EventHandler(this.returnBTN_Click);
            this.returnBTN.MouseEnter += new System.EventHandler(this.BTN_MouseEnter);
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.Transparent;
            this.nextBTN.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.next_13_05_2025;
            this.nextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextBTN.FlatAppearance.BorderSize = 0;
            this.nextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nextBTN.Location = new System.Drawing.Point(0, 494);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(813, 38);
            this.nextBTN.TabIndex = 1;
            this.nextBTN.UseVisualStyleBackColor = false;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 561);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.returnBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avoid, Gumball!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnBTN;
        private System.Windows.Forms.Button nextBTN;
    }
}