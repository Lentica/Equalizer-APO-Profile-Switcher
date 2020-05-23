namespace EQAPO_Profile_Switcher
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
            this.components = new System.ComponentModel.Container();
            this.disableAll = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disableAllProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshConfigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disableAll
            // 
            this.disableAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disableAll.Location = new System.Drawing.Point(20, 10);
            this.disableAll.Name = "disableAll";
            this.disableAll.Size = new System.Drawing.Size(200, 200);
            this.disableAll.TabIndex = 0;
            this.disableAll.Text = "Disable All";
            this.disableAll.UseVisualStyleBackColor = true;
            this.disableAll.Click += new System.EventHandler(this.disableAll_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(689, 0);
            this.vScrollBar1.Maximum = 9;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(37, 261);
            this.vScrollBar1.SmallChange = 2;
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.disableAll);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 261);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableAllProfilesToolStripMenuItem,
            this.refreshConfigsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 48);
            // 
            // disableAllProfilesToolStripMenuItem
            // 
            this.disableAllProfilesToolStripMenuItem.Name = "disableAllProfilesToolStripMenuItem";
            this.disableAllProfilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableAllProfilesToolStripMenuItem.Text = "Disable All Profiles";
            this.disableAllProfilesToolStripMenuItem.Click += new System.EventHandler(this.disableAllProfilesToolStripMenuItem_Click);
            // 
            // refreshConfigsToolStripMenuItem
            // 
            this.refreshConfigsToolStripMenuItem.Name = "refreshConfigsToolStripMenuItem";
            this.refreshConfigsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshConfigsToolStripMenuItem.Text = "Refresh Configs";
            this.refreshConfigsToolStripMenuItem.Click += new System.EventHandler(this.refreshConfigsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(726, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "Form1";
            this.Text = "EQAPO Profile Switcher by Afriza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button disableAll;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem disableAllProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshConfigsToolStripMenuItem;
    }
}

