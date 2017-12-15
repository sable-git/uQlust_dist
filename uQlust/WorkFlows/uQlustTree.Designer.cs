﻿namespace WorkFlows
{
    partial class uQlustTreeSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uQlustTreeSimple));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.relevantC = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Hash = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.distanceControl1 = new Graph.DistanceControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioHTree = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.relevantC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(207, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Choose directory with protein stuctures";
            // 
            // relevantC
            // 
            this.relevantC.Location = new System.Drawing.Point(207, 89);
            this.relevantC.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.relevantC.Name = "relevantC";
            this.relevantC.Size = new System.Drawing.Size(120, 20);
            this.relevantC.TabIndex = 66;
            this.relevantC.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Number of required micro clusters  (K)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 36);
            this.button2.TabIndex = 69;
            this.button2.Text = "RUN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(3, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 36);
            this.button4.TabIndex = 68;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Pofile to be used:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Hash
            // 
            this.Hash.AutoSize = true;
            this.Hash.Checked = true;
            this.Hash.Location = new System.Drawing.Point(6, 24);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(50, 17);
            this.Hash.TabIndex = 72;
            this.Hash.TabStop = true;
            this.Hash.Text = "Hash";
            this.Hash.UseVisualStyleBackColor = true;
            this.Hash.CheckedChanged += new System.EventHandler(this.Hash_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(95, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.Text = "Rpart";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Acive profiles";
            // 
            // distanceControl1
            // 
            this.distanceControl1.CAtoms = uQlustCore.PDB.PDBMODE.ONLY_CA;
            this.distanceControl1.distDef = uQlustCore.DistanceMeasures.HAMMING;
            this.distanceControl1.HideAtoms = false;
            this.distanceControl1.HideCosine = false;
            this.distanceControl1.HideHamming = false;
            this.distanceControl1.hideReference = true;
            this.distanceControl1.HideRmsdLike = false;
            this.distanceControl1.hideSetup = true;
            this.distanceControl1.Location = new System.Drawing.Point(12, 241);
            this.distanceControl1.Name = "distanceControl1";
            this.distanceControl1.profileInfo = false;
            this.distanceControl1.profileName = null;
            this.distanceControl1.reference = false;
            this.distanceControl1.referenceProfile = null;
            this.distanceControl1.Size = new System.Drawing.Size(573, 130);
            this.distanceControl1.TabIndex = 77;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hash);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(15, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 54);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Micro cluster algorithm";
            // 
            // radioRegular
            // 
            this.radioRegular.AutoSize = true;
            this.radioRegular.Checked = true;
            this.radioRegular.Location = new System.Drawing.Point(6, 23);
            this.radioRegular.Name = "radioRegular";
            this.radioRegular.Size = new System.Drawing.Size(62, 17);
            this.radioRegular.TabIndex = 79;
            this.radioRegular.TabStop = true;
            this.radioRegular.Text = "Regular";
            this.radioRegular.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioHTree);
            this.groupBox2.Controls.Add(this.radioRegular);
            this.groupBox2.Location = new System.Drawing.Point(15, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 59);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tree algorithm";
            // 
            // radioHTree
            // 
            this.radioHTree.AutoSize = true;
            this.radioHTree.Location = new System.Drawing.Point(95, 23);
            this.radioHTree.Name = "radioHTree";
            this.radioHTree.Size = new System.Drawing.Size(55, 17);
            this.radioHTree.TabIndex = 81;
            this.radioHTree.TabStop = true;
            this.radioHTree.Text = "HTree";
            this.radioHTree.UseVisualStyleBackColor = true;
            this.radioHTree.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // uQlustTreeSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.distanceControl1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.relevantC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uQlustTreeSimple";
            this.Text = "uQlustTree";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.uQlustTree_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.relevantC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown relevantC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton Hash;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Graph.DistanceControl distanceControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioHTree;
    }
}