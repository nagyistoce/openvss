// zuki	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// wdcm	
// bqfo	 By downloading, copying, installing or using the software you agree to this license.
// uevx	 If you do not agree to this license, do not download, install,
// unpz	 copy or use the software.
// libq	
// djid	                          License Agreement
// bntn	         For OpenVSS - Open Source Video Surveillance System
// luqd	
// fuib	Copyright (C) 2007-2010, Prince of Songkla University, All rights reserved.
// nwtu	
// wrwt	Third party copyrights are property of their respective owners.
// ssgo	
// ifoq	Redistribution and use in source and binary forms, with or without modification,
// suen	are permitted provided that the following conditions are met:
// vzln	
// xrda	  * Redistribution's of source code must retain the above copyright notice,
// osra	    this list of conditions and the following disclaimer.
// enmp	
// pgum	  * Redistribution's in binary form must reproduce the above copyright notice,
// noki	    this list of conditions and the following disclaimer in the documentation
// heeg	    and/or other materials provided with the distribution.
// fzkl	
// pugn	  * Neither the name of the copyright holders nor the names of its contributors 
// lgxe	    may not be used to endorse or promote products derived from this software 
// ovfa	    without specific prior written permission.
// bgju	
// szal	This software is provided by the copyright holders and contributors "as is" and
// zszg	any express or implied warranties, including, but not limited to, the implied
// ocgs	warranties of merchantability and fitness for a particular purpose are disclaimed.
// nwuo	In no event shall the Prince of Songkla University or contributors be liable 
// hglj	for any direct, indirect, incidental, special, exemplary, or consequential damages
// hyei	(including, but not limited to, procurement of substitute goods or services;
// jqyr	loss of use, data, or profits; or business interruption) however caused
// jkhb	and on any theory of liability, whether in contract, strict liability,
// ujng	or tort (including negligence or otherwise) arising in any way out of
// zzlx	the use of this software, even if advised of the possibility of such damage.
// vzzi	
// aerr	Intelligent Systems Laboratory (iSys Lab)
// brsu	Faculty of Engineering, Prince of Songkla University, THAILAND
// uzmu	Project leader by Nikom SUVONVORN
// vrcj	Project website at http://code.google.com/p/openvss/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Vs.Core;

namespace Vs.Monitor
{
	/// <summary>
	/// Summary description for VsCameraInfo.
	/// </summary>
	public class CameraInfo : System.Windows.Forms.Form
	{
		private VsCamera camera;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label widthLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label providerLabel;
		private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button closeButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		// Camera property
		public VsCamera Camera
		{
			get { return camera; }
			set { camera = value; }
		}

		// Constructor
		public CameraInfo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.providerLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // widthLabel
            // 
            this.widthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.widthLabel.Location = new System.Drawing.Point(60, 145);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(60, 16);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(140, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(60, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(200, 16);
            this.nameLabel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel.Location = new System.Drawing.Point(8, 47);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(252, 40);
            this.descriptionLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Provider:";
            // 
            // providerLabel
            // 
            this.providerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.providerLabel.Location = new System.Drawing.Point(60, 97);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(200, 16);
            this.providerLabel.TabIndex = 8;
            // 
            // heightLabel
            // 
            this.heightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heightLabel.Location = new System.Drawing.Point(200, 145);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(60, 16);
            this.heightLabel.TabIndex = 10;
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(185, 171);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            // 
            // CameraInfo
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(270, 206);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraInfo";
            this.Opacity = 0.85;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camera info";
            this.Load += new System.EventHandler(this.CameraInfo_Load);
            this.ResumeLayout(false);

		}
		#endregion

		// On load
		private void CameraInfo_Load(object sender, System.EventArgs e)
		{
			if (camera != null)
			{
                nameLabel.Text = camera.CameraName;
                descriptionLabel.Text = camera.CameraDescription;
				providerLabel.Text = camera.Provider.Name;

                /*
				if (camera.Width != -1)
				{
					widthLabel.Text = camera.Width.ToString();
					heightLabel.Text = camera.Height.ToString();
				}
				else
				{
					widthLabel.Text = string.Empty;
					heightLabel.Text = string.Empty;
				}
                */
			}
		}
	}
}
