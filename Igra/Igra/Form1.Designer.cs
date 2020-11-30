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
            this.Bar = new System.Windows.Forms.PictureBox();
            this.BarInside = new System.Windows.Forms.Panel();
            this.BuyST = new System.Windows.Forms.PictureBox();
            this.BuyMA = new System.Windows.Forms.PictureBox();
            this.BuyHP = new System.Windows.Forms.PictureBox();
            this.BARHP = new System.Windows.Forms.TextBox();
            this.BARST = new System.Windows.Forms.TextBox();
            this.BARMA = new System.Windows.Forms.TextBox();
            this.BARY = new System.Windows.Forms.TextBox();
            this.Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).BeginInit();
            this.BarInside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyHP)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Controls.Add(this.Bar);
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(785, 456);
            this.Map.TabIndex = 0;
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.SystemColors.Control;
            this.Bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Bar.InitialImage = null;
            this.Bar.Location = new System.Drawing.Point(12, 311);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(155, 96);
            this.Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.BARHP.Location = new System.Drawing.Point(11, 424);
            this.BARHP.Name = "BARHP";
            this.BARHP.Size = new System.Drawing.Size(156, 20);
            this.BARHP.TabIndex = 1;
            // 
            // BARST
            // 
            this.BARST.Location = new System.Drawing.Point(173, 424);
            this.BARST.Name = "BARST";
            this.BARST.Size = new System.Drawing.Size(156, 20);
            this.BARST.TabIndex = 2;
            // 
            // BARMA
            // 
            this.BARMA.Location = new System.Drawing.Point(335, 424);
            this.BARMA.Name = "BARMA";
            this.BARMA.Size = new System.Drawing.Size(156, 20);
            this.BARMA.TabIndex = 3;
            // 
            // BARY
            // 
            this.BARY.Location = new System.Drawing.Point(617, 424);
            this.BARY.Name = "BARY";
            this.BARY.Size = new System.Drawing.Size(156, 20);
            this.BARY.TabIndex = 4;
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
            this.Controls.Add(this.BarInside);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar)).EndInit();
            this.BarInside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuyHP)).EndInit();
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
    }
}

