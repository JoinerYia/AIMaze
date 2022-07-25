
namespace AIMaze
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomlyGenerateWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStartToolStripMenuItem,
            this.setEndToolStripMenuItem,
            this.randomlyGenerateWallToolStripMenuItem,
            this.resetMapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setStartToolStripMenuItem
            // 
            this.setStartToolStripMenuItem.Name = "setStartToolStripMenuItem";
            this.setStartToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.setStartToolStripMenuItem.Text = "Set start";
            // 
            // randomlyGenerateWallToolStripMenuItem
            // 
            this.randomlyGenerateWallToolStripMenuItem.Name = "randomlyGenerateWallToolStripMenuItem";
            this.randomlyGenerateWallToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.randomlyGenerateWallToolStripMenuItem.Text = "Randomly generate wall";
            // 
            // resetMapToolStripMenuItem
            // 
            this.resetMapToolStripMenuItem.Name = "resetMapToolStripMenuItem";
            this.resetMapToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.resetMapToolStripMenuItem.Text = "Reset map";
            // 
            // setEndToolStripMenuItem
            // 
            this.setEndToolStripMenuItem.Name = "setEndToolStripMenuItem";
            this.setEndToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.setEndToolStripMenuItem.Text = "Set end";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomlyGenerateWallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEndToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

