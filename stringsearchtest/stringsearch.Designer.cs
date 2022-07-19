﻿namespace stringsearchtest
{
    partial class stringsearch
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
            this.phrasetextbox = new System.Windows.Forms.TextBox();
            this.vowelinputtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phrasetextbox
            // 
            this.phrasetextbox.Location = new System.Drawing.Point(105, 12);
            this.phrasetextbox.Name = "phrasetextbox";
            this.phrasetextbox.Size = new System.Drawing.Size(392, 20);
            this.phrasetextbox.TabIndex = 0;
            this.phrasetextbox.TextChanged += new System.EventHandler(this.phrasetextbox_TextChanged);
            // 
            // vowelinputtextbox
            // 
            this.vowelinputtextbox.Location = new System.Drawing.Point(105, 38);
            this.vowelinputtextbox.Name = "vowelinputtextbox";
            this.vowelinputtextbox.Size = new System.Drawing.Size(100, 20);
            this.vowelinputtextbox.TabIndex = 1;
            this.vowelinputtextbox.TextChanged += new System.EventHandler(this.vowelinputtextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phrase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vowel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // stringsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vowelinputtextbox);
            this.Controls.Add(this.phrasetextbox);
            this.Name = "stringsearch";
            this.Text = "Naive String Matching Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phrasetextbox;
        private System.Windows.Forms.TextBox vowelinputtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

