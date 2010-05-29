// utre	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// jreb	
// vzaw	 By downloading, copying, installing or using the software you agree to this license.
// swye	 If you do not agree to this license, do not download, install,
// wuln	 copy or use the software.
// diob	
// wgdm	                          License Agreement
// kifb	         For OpenVSS - Open Source Video Surveillance System
// atdr	
// ytcq	Copyright (C) 2007-2010, Prince of Songkla University, All rights reserved.
// qvrk	
// khxp	Third party copyrights are property of their respective owners.
// ehtt	
// heim	Redistribution and use in source and binary forms, with or without modification,
// fqic	are permitted provided that the following conditions are met:
// nsqn	
// tyvy	  * Redistribution's of source code must retain the above copyright notice,
// tgfc	    this list of conditions and the following disclaimer.
// suwi	
// qdro	  * Redistribution's in binary form must reproduce the above copyright notice,
// joic	    this list of conditions and the following disclaimer in the documentation
// omuv	    and/or other materials provided with the distribution.
// lqmi	
// lacy	  * Neither the name of the copyright holders nor the names of its contributors 
// eerl	    may not be used to endorse or promote products derived from this software 
// lywx	    without specific prior written permission.
// cqam	
// iawb	This software is provided by the copyright holders and contributors "as is" and
// ztsz	any express or implied warranties, including, but not limited to, the implied
// knyh	warranties of merchantability and fitness for a particular purpose are disclaimed.
// eanc	In no event shall the Prince of Songkla University or contributors be liable 
// uwrr	for any direct, indirect, incidental, special, exemplary, or consequential damages
// rydm	(including, but not limited to, procurement of substitute goods or services;
// mfck	loss of use, data, or profits; or business interruption) however caused
// skay	and on any theory of liability, whether in contract, strict liability,
// lhnl	or tort (including negligence or otherwise) arising in any way out of
// ukjr	the use of this software, even if advised of the possibility of such damage.
// hdoq	
// fjhl	Intelligent Systems Laboratory (iSys Lab)
// ltdf	Faculty of Engineering, Prince of Songkla University, THAILAND
// zjuk	Project leader by Nikom SUVONVORN
// wjpt	Project website at http://code.google.com/p/openvss/

namespace Vs.Analyzer.MotionDetection
{
    partial class VsMotionDetectionSetupPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(16, 116);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(361, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 45);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(361, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sigma Threshold";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alpha Threshold";
            // 
            // VsMotionDetectionSetupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "VsMotionDetectionSetupPage";
            this.Size = new System.Drawing.Size(421, 181);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
