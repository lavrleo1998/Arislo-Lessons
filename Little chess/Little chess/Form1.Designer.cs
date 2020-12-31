namespace Little_chess
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
            this.Menu = new System.Windows.Forms.Panel();
            this.ButtonWithComputer = new System.Windows.Forms.Button();
            this.ButtonWithFriend = new System.Windows.Forms.Button();
            this.PictureOfMenu = new System.Windows.Forms.PictureBox();
            this.Game = new System.Windows.Forms.Panel();
            this.TextLabel = new System.Windows.Forms.Label();
            this.Cube8 = new System.Windows.Forms.Button();
            this.Cube7 = new System.Windows.Forms.Button();
            this.Cube6 = new System.Windows.Forms.Button();
            this.Cube5 = new System.Windows.Forms.Button();
            this.Cube4 = new System.Windows.Forms.Button();
            this.Cube3 = new System.Windows.Forms.Button();
            this.Cube2 = new System.Windows.Forms.Button();
            this.Cube1 = new System.Windows.Forms.Button();
            this.Cube0 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfMenu)).BeginInit();
            this.Game.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Menu.Controls.Add(this.ButtonWithComputer);
            this.Menu.Controls.Add(this.ButtonWithFriend);
            this.Menu.Controls.Add(this.PictureOfMenu);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(504, 504);
            this.Menu.TabIndex = 0;
            // 
            // ButtonWithComputer
            // 
            this.ButtonWithComputer.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonWithComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonWithComputer.BackgroundImage")));
            this.ButtonWithComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonWithComputer.Enabled = false;
            this.ButtonWithComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonWithComputer.Location = new System.Drawing.Point(277, 250);
            this.ButtonWithComputer.Name = "ButtonWithComputer";
            this.ButtonWithComputer.Size = new System.Drawing.Size(150, 150);
            this.ButtonWithComputer.TabIndex = 2;
            this.ButtonWithComputer.Text = "Играть с ботом";
            this.ButtonWithComputer.UseVisualStyleBackColor = false;
            this.ButtonWithComputer.Visible = false;
            // 
            // ButtonWithFriend
            // 
            this.ButtonWithFriend.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonWithFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonWithFriend.BackgroundImage")));
            this.ButtonWithFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonWithFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonWithFriend.Location = new System.Drawing.Point(177, 250);
            this.ButtonWithFriend.Name = "ButtonWithFriend";
            this.ButtonWithFriend.Size = new System.Drawing.Size(150, 150);
            this.ButtonWithFriend.TabIndex = 1;
            this.ButtonWithFriend.Text = "Играть с другом";
            this.ButtonWithFriend.UseVisualStyleBackColor = false;
            this.ButtonWithFriend.Click += new System.EventHandler(this.ButtonWithFriend_Click);
            // 
            // PictureOfMenu
            // 
            this.PictureOfMenu.Enabled = false;
            this.PictureOfMenu.Image = ((System.Drawing.Image)(resources.GetObject("PictureOfMenu.Image")));
            this.PictureOfMenu.Location = new System.Drawing.Point(102, 50);
            this.PictureOfMenu.Name = "PictureOfMenu";
            this.PictureOfMenu.Size = new System.Drawing.Size(300, 150);
            this.PictureOfMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOfMenu.TabIndex = 0;
            this.PictureOfMenu.TabStop = false;
            // 
            // Game
            // 
            this.Game.Controls.Add(this.TextLabel);
            this.Game.Controls.Add(this.Cube8);
            this.Game.Controls.Add(this.Cube7);
            this.Game.Controls.Add(this.Cube6);
            this.Game.Controls.Add(this.Cube5);
            this.Game.Controls.Add(this.Cube4);
            this.Game.Controls.Add(this.Cube3);
            this.Game.Controls.Add(this.Cube2);
            this.Game.Controls.Add(this.Cube1);
            this.Game.Controls.Add(this.Cube0);
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Enabled = false;
            this.Game.Location = new System.Drawing.Point(0, 0);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(504, 504);
            this.Game.TabIndex = 0;
            this.Game.Visible = false;
            // 
            // TextLabel
            // 
            this.TextLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TextLabel.Enabled = false;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(168, 168);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(168, 168);
            this.TextLabel.TabIndex = 9;
            this.TextLabel.Visible = false;
            this.TextLabel.Click += new System.EventHandler(this.TextLabel_Click);
            // 
            // Cube8
            // 
            this.Cube8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube8.BackgroundImage")));
            this.Cube8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cube8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube8.Location = new System.Drawing.Point(336, 336);
            this.Cube8.Name = "Cube8";
            this.Cube8.Size = new System.Drawing.Size(168, 168);
            this.Cube8.TabIndex = 8;
            this.Cube8.UseVisualStyleBackColor = true;
            this.Cube8.Click += new System.EventHandler(this.Cube8_Click);
            // 
            // Cube7
            // 
            this.Cube7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube7.BackgroundImage")));
            this.Cube7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube7.Location = new System.Drawing.Point(168, 336);
            this.Cube7.Name = "Cube7";
            this.Cube7.Size = new System.Drawing.Size(168, 168);
            this.Cube7.TabIndex = 7;
            this.Cube7.UseVisualStyleBackColor = true;
            this.Cube7.Click += new System.EventHandler(this.Cube7_Click);
            // 
            // Cube6
            // 
            this.Cube6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube6.BackgroundImage")));
            this.Cube6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube6.Location = new System.Drawing.Point(0, 336);
            this.Cube6.Name = "Cube6";
            this.Cube6.Size = new System.Drawing.Size(168, 168);
            this.Cube6.TabIndex = 6;
            this.Cube6.UseVisualStyleBackColor = true;
            this.Cube6.Click += new System.EventHandler(this.Cube6_Click);
            // 
            // Cube5
            // 
            this.Cube5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube5.BackgroundImage")));
            this.Cube5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cube5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube5.Location = new System.Drawing.Point(336, 168);
            this.Cube5.Name = "Cube5";
            this.Cube5.Size = new System.Drawing.Size(168, 168);
            this.Cube5.TabIndex = 5;
            this.Cube5.UseVisualStyleBackColor = true;
            this.Cube5.Click += new System.EventHandler(this.Cube5_Click);
            // 
            // Cube4
            // 
            this.Cube4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube4.BackgroundImage")));
            this.Cube4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube4.Location = new System.Drawing.Point(168, 168);
            this.Cube4.Name = "Cube4";
            this.Cube4.Size = new System.Drawing.Size(168, 168);
            this.Cube4.TabIndex = 4;
            this.Cube4.UseVisualStyleBackColor = true;
            this.Cube4.Click += new System.EventHandler(this.Cube4_Click);
            // 
            // Cube3
            // 
            this.Cube3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube3.BackgroundImage")));
            this.Cube3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube3.Location = new System.Drawing.Point(0, 168);
            this.Cube3.Name = "Cube3";
            this.Cube3.Size = new System.Drawing.Size(168, 168);
            this.Cube3.TabIndex = 3;
            this.Cube3.UseVisualStyleBackColor = true;
            this.Cube3.Click += new System.EventHandler(this.Cube3_Click);
            // 
            // Cube2
            // 
            this.Cube2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube2.BackgroundImage")));
            this.Cube2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cube2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube2.Location = new System.Drawing.Point(336, 0);
            this.Cube2.Name = "Cube2";
            this.Cube2.Size = new System.Drawing.Size(168, 168);
            this.Cube2.TabIndex = 2;
            this.Cube2.UseVisualStyleBackColor = true;
            this.Cube2.Click += new System.EventHandler(this.Cube2_Click);
            // 
            // Cube1
            // 
            this.Cube1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube1.BackgroundImage")));
            this.Cube1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube1.Location = new System.Drawing.Point(168, 0);
            this.Cube1.Name = "Cube1";
            this.Cube1.Size = new System.Drawing.Size(168, 168);
            this.Cube1.TabIndex = 1;
            this.Cube1.UseVisualStyleBackColor = true;
            this.Cube1.Click += new System.EventHandler(this.Cube1_Click);
            // 
            // Cube0
            // 
            this.Cube0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cube0.BackgroundImage")));
            this.Cube0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cube0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cube0.Location = new System.Drawing.Point(0, 0);
            this.Cube0.Name = "Cube0";
            this.Cube0.Size = new System.Drawing.Size(168, 168);
            this.Cube0.TabIndex = 0;
            this.Cube0.UseVisualStyleBackColor = true;
            this.Cube0.Click += new System.EventHandler(this.Cube0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 504);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfMenu)).EndInit();
            this.Game.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button ButtonWithComputer;
        private System.Windows.Forms.Button ButtonWithFriend;
        private System.Windows.Forms.PictureBox PictureOfMenu;
        private System.Windows.Forms.Panel Game;
        private System.Windows.Forms.Button Cube0;
        private System.Windows.Forms.Button Cube8;
        private System.Windows.Forms.Button Cube7;
        private System.Windows.Forms.Button Cube6;
        private System.Windows.Forms.Button Cube5;
        private System.Windows.Forms.Button Cube4;
        private System.Windows.Forms.Button Cube3;
        private System.Windows.Forms.Button Cube2;
        private System.Windows.Forms.Button Cube1;
        private System.Windows.Forms.Label TextLabel;
    }
}

