﻿namespace WSSAT
{
    partial class MainForm
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
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDynamicScan = new System.Windows.Forms.CheckBox();
            this.chkStaticScan = new System.Windows.Forms.CheckBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblSelectedFileName = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.chkInfoDisclosure = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResult
            // 
            this.lvResult.BackColor = System.Drawing.Color.Black;
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvResult.ForeColor = System.Drawing.Color.White;
            this.lvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvResult.LabelWrap = false;
            this.lvResult.Location = new System.Drawing.Point(0, 111);
            this.lvResult.Name = "lvResult";
            this.lvResult.ShowItemToolTips = true;
            this.lvResult.Size = new System.Drawing.Size(789, 320);
            this.lvResult.TabIndex = 0;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 750;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.chkInfoDisclosure);
            this.groupBox1.Controls.Add(this.chkDynamicScan);
            this.groupBox1.Controls.Add(this.chkStaticScan);
            this.groupBox1.Controls.Add(this.chkDebug);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.lblSelectedFileName);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(789, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // chkDynamicScan
            // 
            this.chkDynamicScan.AutoSize = true;
            this.chkDynamicScan.Checked = true;
            this.chkDynamicScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDynamicScan.ForeColor = System.Drawing.Color.White;
            this.chkDynamicScan.Location = new System.Drawing.Point(558, 38);
            this.chkDynamicScan.Name = "chkDynamicScan";
            this.chkDynamicScan.Size = new System.Drawing.Size(95, 17);
            this.chkDynamicScan.TabIndex = 12;
            this.chkDynamicScan.Text = "Dynamic Scan";
            this.chkDynamicScan.UseVisualStyleBackColor = true;
            // 
            // chkStaticScan
            // 
            this.chkStaticScan.AutoSize = true;
            this.chkStaticScan.Checked = true;
            this.chkStaticScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStaticScan.ForeColor = System.Drawing.Color.White;
            this.chkStaticScan.Location = new System.Drawing.Point(558, 15);
            this.chkStaticScan.Name = "chkStaticScan";
            this.chkStaticScan.Size = new System.Drawing.Size(81, 17);
            this.chkStaticScan.TabIndex = 11;
            this.chkStaticScan.Text = "Static Scan";
            this.chkStaticScan.UseVisualStyleBackColor = true;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Checked = true;
            this.chkDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDebug.ForeColor = System.Drawing.Color.White;
            this.chkDebug.Location = new System.Drawing.Point(726, 12);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(58, 17);
            this.chkDebug.TabIndex = 10;
            this.chkDebug.Text = "Debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Black;
            this.btnScan.Location = new System.Drawing.Point(10, 45);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblSelectedFileName
            // 
            this.lblSelectedFileName.AutoSize = true;
            this.lblSelectedFileName.ForeColor = System.Drawing.Color.White;
            this.lblSelectedFileName.Location = new System.Drawing.Point(92, 20);
            this.lblSelectedFileName.Name = "lblSelectedFileName";
            this.lblSelectedFileName.Size = new System.Drawing.Size(56, 13);
            this.lblSelectedFileName.TabIndex = 8;
            this.lblSelectedFileName.Text = "Select File";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Black;
            this.btnOpenFile.Location = new System.Drawing.Point(10, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Select File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // chkInfoDisclosure
            // 
            this.chkInfoDisclosure.AutoSize = true;
            this.chkInfoDisclosure.Checked = true;
            this.chkInfoDisclosure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInfoDisclosure.ForeColor = System.Drawing.Color.White;
            this.chkInfoDisclosure.Location = new System.Drawing.Point(558, 61);
            this.chkInfoDisclosure.Name = "chkInfoDisclosure";
            this.chkInfoDisclosure.Size = new System.Drawing.Size(130, 17);
            this.chkInfoDisclosure.TabIndex = 13;
            this.chkInfoDisclosure.Text = "Information Disclosure";
            this.chkInfoDisclosure.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(789, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvResult);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Text = "WEB SERVICE SECURITY ASSESSMENT TOOL (WSSAT)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDynamicScan;
        private System.Windows.Forms.CheckBox chkStaticScan;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblSelectedFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.CheckBox chkInfoDisclosure;
    }
}

