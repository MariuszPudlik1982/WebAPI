namespace PictureBoard2
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
            this.P1 = new System.Windows.Forms.PictureBox();
            this.P4 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.P5 = new System.Windows.Forms.PictureBox();
            this.P3 = new System.Windows.Forms.PictureBox();
            this.P6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P1.Location = new System.Drawing.Point(27, 24);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(136, 98);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1.TabIndex = 0;
            this.P1.TabStop = false;
            this.P1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // P4
            // 
            this.P4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P4.Location = new System.Drawing.Point(27, 164);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(124, 116);
            this.P4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P4.TabIndex = 1;
            this.P4.TabStop = false;
            this.P4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // P2
            // 
            this.P2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P2.Location = new System.Drawing.Point(191, 24);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(144, 98);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2.TabIndex = 2;
            this.P2.TabStop = false;
            this.P2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // P5
            // 
            this.P5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P5.Location = new System.Drawing.Point(191, 164);
            this.P5.Name = "P5";
            this.P5.Size = new System.Drawing.Size(144, 116);
            this.P5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P5.TabIndex = 3;
            this.P5.TabStop = false;
            this.P5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // P3
            // 
            this.P3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P3.Location = new System.Drawing.Point(352, 24);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(157, 98);
            this.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P3.TabIndex = 4;
            this.P3.TabStop = false;
            this.P3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // P6
            // 
            this.P6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P6.Location = new System.Drawing.Point(352, 164);
            this.P6.Name = "P6";
            this.P6.Size = new System.Drawing.Size(157, 116);
            this.P6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P6.TabIndex = 5;
            this.P6.TabStop = false;
            this.P6.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refresh
            // 
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(79, 24);
            this.refresh.Text = "Odśwież";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 313);
            this.Controls.Add(this.P6);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P5);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox P4;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox P5;
        private System.Windows.Forms.PictureBox P3;
        private System.Windows.Forms.PictureBox P6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refresh;
    }
}

