// dyzz	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// sruo	
// mzwa	 By downloading, copying, installing or using the software you agree to this license.
// agyh	 If you do not agree to this license, do not download, install,
// ggcn	 copy or use the software.
// kbuq	
// xopf	                          License Agreement
// qpwx	         For OpenVSS - Open Source Video Surveillance System
// mwvz	
// hnkq	Copyright (C) 2007-2010, Prince of Songkla University, All rights reserved.
// gxgr	
// leqr	Third party copyrights are property of their respective owners.
// rxng	
// qbqc	Redistribution and use in source and binary forms, with or without modification,
// ejcd	are permitted provided that the following conditions are met:
// bpxx	
// czod	  * Redistribution's of source code must retain the above copyright notice,
// kzzt	    this list of conditions and the following disclaimer.
// wmgm	
// ucfs	  * Redistribution's in binary form must reproduce the above copyright notice,
// yynt	    this list of conditions and the following disclaimer in the documentation
// bphl	    and/or other materials provided with the distribution.
// gtuy	
// lgor	  * Neither the name of the copyright holders nor the names of its contributors 
// ziol	    may not be used to endorse or promote products derived from this software 
// qmgs	    without specific prior written permission.
// xukd	
// veib	This software is provided by the copyright holders and contributors "as is" and
// dked	any express or implied warranties, including, but not limited to, the implied
// bewm	warranties of merchantability and fitness for a particular purpose are disclaimed.
// sdxr	In no event shall the Prince of Songkla University or contributors be liable 
// eaip	for any direct, indirect, incidental, special, exemplary, or consequential damages
// xoml	(including, but not limited to, procurement of substitute goods or services;
// ntbm	loss of use, data, or profits; or business interruption) however caused
// rvvh	and on any theory of liability, whether in contract, strict liability,
// fdpb	or tort (including negligence or otherwise) arising in any way out of
// ltvb	the use of this software, even if advised of the possibility of such damage.
// ckpv	
// mctn	Intelligent Systems Laboratory (iSys Lab)
// oonw	Faculty of Engineering, Prince of Songkla University, THAILAND
// lufg	Project leader by Nikom SUVONVORN
// rwoj	Project website at http://code.google.com/p/openvss/

namespace Vs.Monitor
{
    partial class VsMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VsMonitor));
            this.vsMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vsLiveviewTool1 = new Vs.Monitor.VsLiveviewTool();
            this.vsSettingTool1 = new Vs.Monitor.VsSettingTool();
            this.vsToolStrip = new System.Windows.Forms.ToolStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.vsMainMenu.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsMainMenu
            // 
            this.vsMainMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.vsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.vsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.vsMainMenu.Name = "vsMainMenu";
            this.vsMainMenu.Size = new System.Drawing.Size(1016, 24);
            this.vsMainMenu.TabIndex = 0;
            this.vsMainMenu.Text = "vsMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.BackColor = System.Drawing.Color.White;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer.ContentPanel.Controls.Add(this.vsSettingTool1);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1016, 670);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1016, 670);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.vsToolStrip);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vsLiveviewTool1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 670F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 670);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // vsLiveviewTool1
            // 
            this.vsLiveviewTool1.BackColor = System.Drawing.SystemColors.Control;
            this.vsLiveviewTool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsLiveviewTool1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.vsLiveviewTool1.Location = new System.Drawing.Point(3, 3);
            this.vsLiveviewTool1.Name = "vsLiveviewTool1";
            this.vsLiveviewTool1.Size = new System.Drawing.Size(1010, 664);
            this.vsLiveviewTool1.TabIndex = 1;
            // 
            // vsSettingTool1
            // 
            this.vsSettingTool1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vsSettingTool1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.vsSettingTool1.Location = new System.Drawing.Point(62, 20);
            this.vsSettingTool1.Name = "vsSettingTool1";
            this.vsSettingTool1.Size = new System.Drawing.Size(290, 199);
            this.vsSettingTool1.TabIndex = 3;
            // 
            // vsToolStrip
            // 
            this.vsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.vsToolStrip.Location = new System.Drawing.Point(3, 0);
            this.vsToolStrip.Name = "vsToolStrip";
            this.vsToolStrip.Size = new System.Drawing.Size(111, 25);
            this.vsToolStrip.TabIndex = 0;
            this.vsToolStrip.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Security Surveillance System";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // VsMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 694);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.vsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.vsMainMenu;
            this.Name = "VsMonitor";
            this.Text = "VsMonitor";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.vsMainMenu.ResumeLayout(false);
            this.vsMainMenu.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose core application
                VsMonitor_Close();
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.MenuStrip vsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip vsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private VsSettingTool vsSettingTool1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private VsLiveviewTool vsLiveviewTool1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

