﻿namespace MarshalUtil
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.evePathTxtBox = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.singleFile = new System.Windows.Forms.CheckBox();
            this.packetSubDirs = new System.Windows.Forms.CheckBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressIndicators = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Packet Dir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // evePathTxtBox
            // 
            this.evePathTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evePathTxtBox.Enabled = false;
            this.evePathTxtBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evePathTxtBox.Location = new System.Drawing.Point(93, 15);
            this.evePathTxtBox.Name = "evePathTxtBox";
            this.evePathTxtBox.Size = new System.Drawing.Size(387, 20);
            this.evePathTxtBox.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(237, 41);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(243, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // singleFile
            // 
            this.singleFile.AutoSize = true;
            this.singleFile.Checked = true;
            this.singleFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.singleFile.Location = new System.Drawing.Point(12, 45);
            this.singleFile.Name = "singleFile";
            this.singleFile.Size = new System.Drawing.Size(71, 17);
            this.singleFile.TabIndex = 5;
            this.singleFile.Text = "Single file";
            this.singleFile.UseVisualStyleBackColor = true;
            // 
            // packetSubDirs
            // 
            this.packetSubDirs.AutoSize = true;
            this.packetSubDirs.Location = new System.Drawing.Point(93, 45);
            this.packetSubDirs.Name = "packetSubDirs";
            this.packetSubDirs.Size = new System.Drawing.Size(138, 17);
            this.packetSubDirs.TabIndex = 6;
            this.packetSubDirs.Text = "Sub Dirs as Packet Dirs";
            this.packetSubDirs.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(12, 319);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(468, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // progressIndicators
            // 
            this.progressIndicators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressIndicators.AutoScroll = true;
            this.progressIndicators.Location = new System.Drawing.Point(12, 69);
            this.progressIndicators.Name = "progressIndicators";
            this.progressIndicators.Size = new System.Drawing.Size(468, 244);
            this.progressIndicators.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 354);
            this.Controls.Add(this.progressIndicators);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.packetSubDirs);
            this.Controls.Add(this.singleFile);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.evePathTxtBox);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Bulk Packet Decode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox evePathTxtBox;
        private System.Windows.Forms.Button btnProcess;
    private System.Windows.Forms.CheckBox singleFile;
        private System.Windows.Forms.CheckBox packetSubDirs;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.FlowLayoutPanel progressIndicators;
    }
}