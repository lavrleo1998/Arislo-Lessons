namespace Igra
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
            this.Map = new System.Windows.Forms.Panel();
            this.BossBattle = new System.Windows.Forms.PictureBox();
            this.Battle3 = new System.Windows.Forms.PictureBox();
            this.Battle2 = new System.Windows.Forms.PictureBox();
            this.Battle1 = new System.Windows.Forms.PictureBox();
            this.Bar = new System.Windows.Forms.PictureBox();
            this.BarInside = new System.Windows.Forms.Panel();
            this.BuyST = new System.Windows.Forms.PictureBox();
            this.BuyMA = new System.Windows.Forms.PictureBox();
            this.BuyHP = new System.Windows.Forms.PictureBox();
            this.BARHP = new System.Windows.Forms.TextBox();
            this.BARST = new System.Windows.Forms.TextBox();
            this.BARMA = new System.Windows.Forms.TextBox();
            this.BARY = new System.Windows.Forms.TextBox();
            this.Battle = new System.Windows.Forms.Panel();
            this.BarNameEnemy = new System.Windows.Forms.TextBox();
            this.BarHPEnemy = new System.Windows.Forms.TextBox();
            this.ShowEnemy = new System.Windows.Forms.PictureBox();
            this.Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BossBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.BarInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyHP)).BeginInit();
            this.Battle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Map.BackgroundImage")));
            this.Map.Controls.Add(this.BossBattle);
            this.Map.Controls.Add(this.Battle3);
            this.Map.Controls.Add(this.Battle2);
            this.Map.Controls.Add(this.Battle1);
            this.Map.Controls.Add(this.Bar);
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(785, 456);
            this.Map.TabIndex = 0;
            // 
            // BossBattle
            // 
            this.BossBattle.Location = new System.Drawing.Point(608, 86);
            this.BossBattle.Name = "BossBattle";
            this.BossBattle.Size = new System.Drawing.Size(111, 116);
            this.BossBattle.TabIndex = 4;
            this.BossBattle.TabStop = false;
            // 
            // Battle3
            // 
            this.Battle3.Location = new System.Drawing.Point(461, 237);
            this.Battle3.Name = "Battle3";
            this.Battle3.Size = new System.Drawing.Size(51, 54);
            this.Battle3.TabIndex = 3;
            this.Battle3.TabStop = false;
            // 
            // Battle2
            // 
            this.Battle2.Location = new System.Drawing.Point(268, 75);
            this.Battle2.Name = "Battle2";
            this.Battle2.Size = new System.Drawing.Size(51, 54);
            this.Battle2.TabIndex = 2;
            this.Battle2.TabStop = false;
            // 
            // Battle1
            // 
            this.Battle1.Location = new System.Drawing.Point(24, 168);
            this.Battle1.Name = "Battle1";
            this.Battle1.Size = new System.Drawing.Size(51, 54);
            this.Battle1.TabIndex = 1;
            this.Battle1.TabStop = false;
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.SystemColors.Control;
            this.Bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bar.Image = ((System.Drawing.Image)(resources.GetObject("Bar.Image")));
            this.Bar.InitialImage = null;
            this.Bar.Location = new System.Drawing.Point(12, 311);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(155, 96);
            this.Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bar.TabIndex = 0;
            this.Bar.TabStop = false;
            this.Bar.Click += new System.EventHandler(this.Bar_Click);
            // 
            // BarInside
            // 
            this.BarInside.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarInside.BackgroundImage")));
            this.BarInside.Controls.Add(this.BuyST);
            this.BarInside.Controls.Add(this.BuyMA);
            this.BarInside.Controls.Add(this.BuyHP);
            this.BarInside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarInside.Enabled = false;
            this.BarInside.Location = new System.Drawing.Point(0, 0);
            this.BarInside.Name = "BarInside";
            this.BarInside.Size = new System.Drawing.Size(785, 456);
            this.BarInside.TabIndex = 1;
            this.BarInside.Visible = false;
            this.BarInside.Click += new System.EventHandler(this.BarInside_Click);
            // 
            // BuyST
            // 
            this.BuyST.Image = ((System.Drawing.Image)(resources.GetObject("BuyST.Image")));
            this.BuyST.Location = new System.Drawing.Point(537, 275);
            this.BuyST.Name = "BuyST";
            this.BuyST.Size = new System.Drawing.Size(111, 49);
            this.BuyST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuyST.TabIndex = 2;
            this.BuyST.TabStop = false;
            this.BuyST.Click += new System.EventHandler(this.BuyST_Click);
            // 
            // BuyMA
            // 
            this.BuyMA.Image = ((System.Drawing.Image)(resources.GetObject("BuyMA.Image")));
            this.BuyMA.Location = new System.Drawing.Point(537, 172);
            this.BuyMA.Name = "BuyMA";
            this.BuyMA.Size = new System.Drawing.Size(111, 49);
            this.BuyMA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuyMA.TabIndex = 1;
            this.BuyMA.TabStop = false;
            this.BuyMA.Click += new System.EventHandler(this.BuyMA_Click);
            // 
            // BuyHP
            // 
            this.BuyHP.Image = ((System.Drawing.Image)(resources.GetObject("BuyHP.Image")));
            this.BuyHP.Location = new System.Drawing.Point(537, 79);
            this.BuyHP.Name = "BuyHP";
            this.BuyHP.Size = new System.Drawing.Size(111, 49);
            this.BuyHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuyHP.TabIndex = 0;
            this.BuyHP.TabStop = false;
            this.BuyHP.Click += new System.EventHandler(this.BuyHP_Click);
            // 
            // BARHP
            // 
            this.BARHP.BackColor = System.Drawing.Color.Red;
            this.BARHP.Location = new System.Drawing.Point(11, 424);
            this.BARHP.Name = "BARHP";
            this.BARHP.Size = new System.Drawing.Size(156, 20);
            this.BARHP.TabIndex = 1;
            // 
            // BARST
            // 
            this.BARST.BackColor = System.Drawing.Color.ForestGreen;
            this.BARST.Location = new System.Drawing.Point(173, 424);
            this.BARST.Name = "BARST";
            this.BARST.Size = new System.Drawing.Size(156, 20);
            this.BARST.TabIndex = 2;
            // 
            // BARMA
            // 
            this.BARMA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BARMA.Location = new System.Drawing.Point(335, 424);
            this.BARMA.Name = "BARMA";
            this.BARMA.Size = new System.Drawing.Size(156, 20);
            this.BARMA.TabIndex = 3;
            // 
            // BARY
            // 
            this.BARY.BackColor = System.Drawing.Color.Yellow;
            this.BARY.Location = new System.Drawing.Point(617, 424);
            this.BARY.Name = "BARY";
            this.BARY.Size = new System.Drawing.Size(156, 20);
            this.BARY.TabIndex = 4;
            // 
            // Battle
            // 
            this.Battle.Controls.Add(this.BarNameEnemy);
            this.Battle.Controls.Add(this.BarHPEnemy);
            this.Battle.Controls.Add(this.ShowEnemy);
            this.Battle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Battle.Enabled = false;
            this.Battle.Location = new System.Drawing.Point(0, 0);
            this.Battle.Name = "Battle";
            this.Battle.Size = new System.Drawing.Size(785, 456);
            this.Battle.TabIndex = 5;
            this.Battle.Visible = false;
            // 
            // BarNameEnemy
            // 
            this.BarNameEnemy.Location = new System.Drawing.Point(263, 15);
            this.BarNameEnemy.Name = "BarNameEnemy";
            this.BarNameEnemy.Size = new System.Drawing.Size(228, 20);
            this.BarNameEnemy.TabIndex = 7;
            // 
            // BarHPEnemy
            // 
            this.BarHPEnemy.BackColor = System.Drawing.Color.Red;
            this.BarHPEnemy.Location = new System.Drawing.Point(19, 15);
            this.BarHPEnemy.Name = "BarHPEnemy";
            this.BarHPEnemy.Size = new System.Drawing.Size(156, 20);
            this.BarHPEnemy.TabIndex = 6;
            // 
            // ShowEnemy
            // 
            this.ShowEnemy.Location = new System.Drawing.Point(263, 44);
            this.ShowEnemy.Name = "ShowEnemy";
            this.ShowEnemy.Size = new System.Drawing.Size(228, 264);
            this.ShowEnemy.TabIndex = 0;
            this.ShowEnemy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 456);
            this.Controls.Add(this.BARHP);
            this.Controls.Add(this.BARST);
            this.Controls.Add(this.BARMA);
            this.Controls.Add(this.BARY);
            this.Controls.Add(this.Battle);
            this.Controls.Add(this.BarInside);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BossBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Battle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.BarInside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyHP)).EndInit();
            this.Battle.ResumeLayout(false);
            this.Battle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Map;
        private System.Windows.Forms.PictureBox Bar;
        private System.Windows.Forms.Panel BarInside;
        private System.Windows.Forms.PictureBox BuyST;
        private System.Windows.Forms.PictureBox BuyMA;
        private System.Windows.Forms.PictureBox BuyHP;
        private System.Windows.Forms.TextBox BARMA;
        private System.Windows.Forms.TextBox BARST;
        private System.Windows.Forms.TextBox BARHP;
        private System.Windows.Forms.TextBox BARY;
        private System.Windows.Forms.Panel Battle;
        private System.Windows.Forms.TextBox BarNameEnemy;
        private System.Windows.Forms.TextBox BarHPEnemy;
        private System.Windows.Forms.PictureBox ShowEnemy;
        private System.Windows.Forms.PictureBox BossBattle;
        private System.Windows.Forms.PictureBox Battle3;
        private System.Windows.Forms.PictureBox Battle2;
        private System.Windows.Forms.PictureBox Battle1;
    }
}

