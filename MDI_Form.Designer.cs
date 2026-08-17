namespace My_Daily_Wins_Project
{
    partial class MDI_Form
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
            this.MdiMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalWinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MdiMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenuStrip
            // 
            this.MdiMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MdiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEditToolStripMenuItem,
            this.totalWinsToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.MdiMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MdiMenuStrip.Name = "MdiMenuStrip";
            this.MdiMenuStrip.Size = new System.Drawing.Size(1215, 28);
            this.MdiMenuStrip.TabIndex = 1;
            this.MdiMenuStrip.Text = "MdiMenuStrip";
            // 
            // addEditToolStripMenuItem
            // 
            this.addEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.addEditToolStripMenuItem.Name = "addEditToolStripMenuItem";
            this.addEditToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.addEditToolStripMenuItem.Text = "Add/Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // totalWinsToolStripMenuItem
            // 
            this.totalWinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearLogToolStripMenuItem,
            this.monthlyLogToolStripMenuItem});
            this.totalWinsToolStripMenuItem.Name = "totalWinsToolStripMenuItem";
            this.totalWinsToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.totalWinsToolStripMenuItem.Text = "Log";
            // 
            // yearLogToolStripMenuItem
            // 
            this.yearLogToolStripMenuItem.Name = "yearLogToolStripMenuItem";
            this.yearLogToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.yearLogToolStripMenuItem.Text = "Yearly Log";
            // 
            // monthlyLogToolStripMenuItem
            // 
            this.monthlyLogToolStripMenuItem.Name = "monthlyLogToolStripMenuItem";
            this.monthlyLogToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.monthlyLogToolStripMenuItem.Text = "Monthly Log";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyStatusToolStripMenuItem,
            this.monthlyStatusToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // yearlyStatusToolStripMenuItem
            // 
            this.yearlyStatusToolStripMenuItem.Name = "yearlyStatusToolStripMenuItem";
            this.yearlyStatusToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.yearlyStatusToolStripMenuItem.Text = "Yearly Status";
            // 
            // monthlyStatusToolStripMenuItem
            // 
            this.monthlyStatusToolStripMenuItem.Name = "monthlyStatusToolStripMenuItem";
            this.monthlyStatusToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.monthlyStatusToolStripMenuItem.Text = "Monthly Status";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MDI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 631);
            this.Controls.Add(this.MdiMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenuStrip;
            this.Name = "MDI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Daily Wins";
            this.MdiMenuStrip.ResumeLayout(false);
            this.MdiMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalWinsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyStatusToolStripMenuItem;
    }
}

