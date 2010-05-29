// tgpu	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// qnke	
// cpbh	 By downloading, copying, installing or using the software you agree to this license.
// ekkp	 If you do not agree to this license, do not download, install,
// wffn	 copy or use the software.
// vwit	
// ytwj	                          License Agreement
// hpgf	         For OpenVSS - Open Source Video Surveillance System
// fcoh	
// mtjx	Copyright (C) 2007-2010, Prince of Songkla University, All rights reserved.
// fqpe	
// payy	Third party copyrights are property of their respective owners.
// hvcg	
// iqkw	Redistribution and use in source and binary forms, with or without modification,
// yvvx	are permitted provided that the following conditions are met:
// qaxn	
// jvcb	  * Redistribution's of source code must retain the above copyright notice,
// wccc	    this list of conditions and the following disclaimer.
// whie	
// hddy	  * Redistribution's in binary form must reproduce the above copyright notice,
// uycl	    this list of conditions and the following disclaimer in the documentation
// mzxo	    and/or other materials provided with the distribution.
// srjq	
// ylhe	  * Neither the name of the copyright holders nor the names of its contributors 
// tcvu	    may not be used to endorse or promote products derived from this software 
// ywce	    without specific prior written permission.
// saka	
// hfpu	This software is provided by the copyright holders and contributors "as is" and
// sxcs	any express or implied warranties, including, but not limited to, the implied
// xlaj	warranties of merchantability and fitness for a particular purpose are disclaimed.
// xnje	In no event shall the Prince of Songkla University or contributors be liable 
// tmek	for any direct, indirect, incidental, special, exemplary, or consequential damages
// aele	(including, but not limited to, procurement of substitute goods or services;
// ijzy	loss of use, data, or profits; or business interruption) however caused
// vxtm	and on any theory of liability, whether in contract, strict liability,
// pxhn	or tort (including negligence or otherwise) arising in any way out of
// boya	the use of this software, even if advised of the possibility of such damage.
// jogi	
// blwk	Intelligent Systems Laboratory (iSys Lab)
// nxlg	Faculty of Engineering, Prince of Songkla University, THAILAND
// wzzd	Project leader by Nikom SUVONVORN
// ukmi	Project website at http://code.google.com/p/openvss/

namespace Vs.Monitor
{
    partial class VsSingleViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VsSingleViewer));
            this.vsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.vsViewer = new System.Windows.Forms.PictureBox();
            this.panelTool = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonAnalyzer = new System.Windows.Forms.Button();
            this.buttonAttach = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.vsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsViewer)).BeginInit();
            this.panelTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsTableLayoutPanel
            // 
            this.vsTableLayoutPanel.AutoSize = true;
            this.vsTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.vsTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.vsTableLayoutPanel.ColumnCount = 1;
            this.vsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vsTableLayoutPanel.Controls.Add(this.vsViewer, 0, 0);
            this.vsTableLayoutPanel.Controls.Add(this.panelTool, 0, 1);
            this.vsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.vsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.vsTableLayoutPanel.Name = "vsTableLayoutPanel";
            this.vsTableLayoutPanel.RowCount = 2;
            this.vsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.vsTableLayoutPanel.Size = new System.Drawing.Size(299, 272);
            this.vsTableLayoutPanel.TabIndex = 0;
            // 
            // vsViewer
            // 
            this.vsViewer.BackColor = System.Drawing.Color.White;
            this.vsViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsViewer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("vsViewer.ErrorImage")));
            this.vsViewer.Image = ((System.Drawing.Image)(resources.GetObject("vsViewer.Image")));
            this.vsViewer.InitialImage = ((System.Drawing.Image)(resources.GetObject("vsViewer.InitialImage")));
            this.vsViewer.Location = new System.Drawing.Point(1, 1);
            this.vsViewer.Margin = new System.Windows.Forms.Padding(0);
            this.vsViewer.Name = "vsViewer";
            this.vsViewer.Size = new System.Drawing.Size(297, 257);
            this.vsViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.vsViewer.TabIndex = 0;
            this.vsViewer.TabStop = false;
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.SystemColors.Control;
            this.panelTool.Controls.Add(this.labelStatus);
            this.panelTool.Controls.Add(this.buttonAnalyzer);
            this.panelTool.Controls.Add(this.buttonAttach);
            this.panelTool.Controls.Add(this.buttonStop);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTool.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTool.Location = new System.Drawing.Point(1, 259);
            this.panelTool.Margin = new System.Windows.Forms.Padding(0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(297, 12);
            this.panelTool.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(3, -1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 1;
            // 
            // buttonAnalyzer
            // 
            this.buttonAnalyzer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnalyzer.Image = global::Vs.Monitor.Properties.Resources.image_edit;
            this.buttonAnalyzer.Location = new System.Drawing.Point(255, -1);
            this.buttonAnalyzer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAnalyzer.Name = "buttonAnalyzer";
            this.buttonAnalyzer.Size = new System.Drawing.Size(14, 14);
            this.buttonAnalyzer.TabIndex = 0;
            this.buttonAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAnalyzer.Visible = false;
            this.buttonAnalyzer.Click += new System.EventHandler(this.buttonAnalyzer_Click);
            // 
            // buttonAttach
            // 
            this.buttonAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAttach.Image = ((System.Drawing.Image)(resources.GetObject("buttonAttach.Image")));
            this.buttonAttach.Location = new System.Drawing.Point(269, -1);
            this.buttonAttach.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(14, 14);
            this.buttonAttach.TabIndex = 0;
            this.buttonAttach.UseVisualStyleBackColor = true;
            this.buttonAttach.Visible = false;
            this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Image = global::Vs.Monitor.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(283, -1);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(14, 14);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // VsSingleViewer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.vsTableLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VsSingleViewer";
            this.Size = new System.Drawing.Size(299, 272);
            this.vsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vsViewer)).EndInit();
            this.panelTool.ResumeLayout(false);
            this.panelTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel vsTableLayoutPanel;
        private System.Windows.Forms.PictureBox vsViewer;
        private System.Windows.Forms.Panel panelTool;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonAnalyzer;
    }
}
