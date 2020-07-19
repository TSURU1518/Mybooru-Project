using System;

namespace Mybooru_Project
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opendbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edititemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edittagdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.runscannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r18modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r18onlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r18blendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.r18exceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1742, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opendbToolStripMenuItem,
            this.exportdbToolStripMenuItem,
            this.toolStripSeparator,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // opendbToolStripMenuItem
            // 
            this.opendbToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opendbToolStripMenuItem.Name = "opendbToolStripMenuItem";
            this.opendbToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.opendbToolStripMenuItem.Text = "Open Database";
            // 
            // exportdbToolStripMenuItem
            // 
            this.exportdbToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportdbToolStripMenuItem.Name = "exportdbToolStripMenuItem";
            this.exportdbToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.exportdbToolStripMenuItem.Text = "Export Database";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(200, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edititemToolStripMenuItem,
            this.toolStripSeparator4,
            this.edittagdbToolStripMenuItem,
            this.toolStripSeparator2,
            this.runscannerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // edititemToolStripMenuItem
            // 
            this.edititemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edititemToolStripMenuItem.Name = "edititemToolStripMenuItem";
            this.edititemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.edititemToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.edititemToolStripMenuItem.Text = "Edit Selected Item";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(265, 6);
            // 
            // edittagdbToolStripMenuItem
            // 
            this.edittagdbToolStripMenuItem.Name = "edittagdbToolStripMenuItem";
            this.edittagdbToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.edittagdbToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.edittagdbToolStripMenuItem.Text = "Edit Tag Database";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(265, 6);
            // 
            // runscannerToolStripMenuItem
            // 
            this.runscannerToolStripMenuItem.Name = "runscannerToolStripMenuItem";
            this.runscannerToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.runscannerToolStripMenuItem.Text = "Run Library Scanner";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listingToolStripMenuItem,
            this.r18modeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listingToolStripMenuItem
            // 
            this.listingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem,
            this.latestToolStripMenuItem});
            this.listingToolStripMenuItem.Name = "listingToolStripMenuItem";
            this.listingToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.listingToolStripMenuItem.Text = "Listing";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // latestToolStripMenuItem
            // 
            this.latestToolStripMenuItem.Name = "latestToolStripMenuItem";
            this.latestToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.latestToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.latestToolStripMenuItem.Text = "Latest";
            // 
            // r18modeToolStripMenuItem
            // 
            this.r18modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.r18onlyToolStripMenuItem,
            this.r18blendToolStripMenuItem,
            this.r18exceptToolStripMenuItem});
            this.r18modeToolStripMenuItem.Name = "r18modeToolStripMenuItem";
            this.r18modeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.r18modeToolStripMenuItem.Text = "R-18 Mode";
            // 
            // r18onlyToolStripMenuItem
            // 
            this.r18onlyToolStripMenuItem.Name = "r18onlyToolStripMenuItem";
            this.r18onlyToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.r18onlyToolStripMenuItem.Text = "R-18 Only";
            // 
            // r18blendToolStripMenuItem
            // 
            this.r18blendToolStripMenuItem.Name = "r18blendToolStripMenuItem";
            this.r18blendToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.r18blendToolStripMenuItem.Text = "Blending";
            // 
            // r18exceptToolStripMenuItem
            // 
            this.r18exceptToolStripMenuItem.Name = "r18exceptToolStripMenuItem";
            this.r18exceptToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.r18exceptToolStripMenuItem.Text = "Except R-18";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 943);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mybooru";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opendbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportdbToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edititemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem edittagdbToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem runscannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r18onlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r18blendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r18exceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem r18modeToolStripMenuItem;
    }
}

