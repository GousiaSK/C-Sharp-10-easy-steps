﻿namespace Methods {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.paramTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 137);
            this.textBox1.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(27, 171);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(166, 23);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Run Method Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // paramTestBtn
            // 
            this.paramTestBtn.Location = new System.Drawing.Point(289, 171);
            this.paramTestBtn.Name = "paramTestBtn";
            this.paramTestBtn.Size = new System.Drawing.Size(166, 23);
            this.paramTestBtn.TabIndex = 2;
            this.paramTestBtn.Text = "Value, Ref and Out Parameters";
            this.paramTestBtn.UseVisualStyleBackColor = true;
            this.paramTestBtn.Click += new System.EventHandler(this.paramTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 217);
            this.Controls.Add(this.paramTestBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button paramTestBtn;
    }
}

