﻿namespace Graph
{
    partial class SelectBestToNatiive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBestToNatiive));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectBest1 = new Graph.SelectBest();
            this.jury1DSetup1 = new Graph.jury1DSetup();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(372, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(24, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectBest1
            // 
            this.selectBest1.bestNumber = 1;
            this.selectBest1.getFileName = "";
            this.selectBest1.HideAtoms = false;
            this.selectBest1.Location = new System.Drawing.Point(12, 12);
            this.selectBest1.measure = uQlustCore.DistanceMeasures.HAMMING;
            this.selectBest1.Name = "selectBest1";
            this.selectBest1.Size = new System.Drawing.Size(489, 221);
            this.selectBest1.TabIndex = 0;
            // 
            // jury1DSetup1
            // 
            this.jury1DSetup1.Location = new System.Drawing.Point(24, 217);
            this.jury1DSetup1.Name = "jury1DSetup1";
            this.jury1DSetup1.profileName = null;
            this.jury1DSetup1.Size = new System.Drawing.Size(220, 75);
            this.jury1DSetup1.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(208, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Use 1DJury for best structure selection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SelectBestToNatiive
            // 
            this.ClientSize = new System.Drawing.Size(625, 368);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.jury1DSetup1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectBest1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectBestToNatiive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private SelectBest selectBest1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private jury1DSetup jury1DSetup1;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}