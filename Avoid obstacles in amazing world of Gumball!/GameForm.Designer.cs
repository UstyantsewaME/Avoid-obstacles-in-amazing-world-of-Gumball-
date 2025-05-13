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
            this.instructionIMG = new System.Windows.Forms.PictureBox();
            this.nextBTN = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.characterIMG = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.instructionIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterIMG)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnBTN
            // 
            this.returnBTN.BackColor = System.Drawing.Color.Transparent;
            this.returnBTN.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources._return;
            this.returnBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.returnBTN.FlatAppearance.BorderSize = 0;
            this.returnBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.returnBTN.Location = new System.Drawing.Point(0, 480);
            this.returnBTN.Name = "returnBTN";
            this.returnBTN.Size = new System.Drawing.Size(813, 33);
            this.returnBTN.TabIndex = 0;
            this.returnBTN.UseVisualStyleBackColor = false;
            this.returnBTN.Click += new System.EventHandler(this.returnBTN_Click);
            this.returnBTN.MouseEnter += new System.EventHandler(this.BTN_MouseEnter);
            // 
            // instructionIMG
            // 
            this.instructionIMG.BackColor = System.Drawing.Color.Transparent;
            this.instructionIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instructionIMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionIMG.Image = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.instruction;
            this.instructionIMG.Location = new System.Drawing.Point(0, 0);
            this.instructionIMG.Name = "instructionIMG";
            this.instructionIMG.Size = new System.Drawing.Size(813, 480);
            this.instructionIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.instructionIMG.TabIndex = 1;
            this.instructionIMG.TabStop = false;
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.Transparent;
            this.nextBTN.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.next;
            this.nextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextBTN.FlatAppearance.BorderSize = 0;
            this.nextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBTN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nextBTN.Location = new System.Drawing.Point(0, 513);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(813, 48);
            this.nextBTN.TabIndex = 2;
            this.nextBTN.UseVisualStyleBackColor = false;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            this.nextBTN.MouseEnter += new System.EventHandler(this.BTN_MouseEnter);
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionLabel.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.instructionLabel.Location = new System.Drawing.Point(3, 264);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(807, 216);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionLabel.Visible = false;
            // 
            // characterIMG
            // 
            this.characterIMG.Dock = System.Windows.Forms.DockStyle.None;
            this.characterIMG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterIMG.Size = new System.Drawing.Size(200, 200);
            this.characterIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.characterIMG.BackColor = System.Drawing.Color.Transparent;
            this.characterIMG.Location = new System.Drawing.Point(3, 3);
            this.characterIMG.Name = "characterIMG";
            this.characterIMG.TabIndex = 4;
            this.characterIMG.TabStop = false;
            this.characterIMG.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.characterIMG, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.instructionLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 480);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Avoid_obstacles_in_amazing_world_of_Gumball_.Properties.Resources.wallpaperflare_com_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.instructionIMG);
            this.Controls.Add(this.returnBTN);
            this.Controls.Add(this.nextBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avoid, Gumball!";
            ((System.ComponentModel.ISupportInitialize)(this.instructionIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterIMG)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnBTN;
        private System.Windows.Forms.PictureBox instructionIMG;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox characterIMG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}