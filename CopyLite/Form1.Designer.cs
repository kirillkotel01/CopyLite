namespace CopyLite
{
    partial class Form1
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
            this.buttonActive = new System.Windows.Forms.Button();
            this.buttonOpenYcet = new System.Windows.Forms.Button();
            this.buttonOpenSotr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonActive
            // 
            this.buttonActive.Location = new System.Drawing.Point(12, 790);
            this.buttonActive.Name = "buttonActive";
            this.buttonActive.Size = new System.Drawing.Size(542, 117);
            this.buttonActive.TabIndex = 0;
            this.buttonActive.Text = "button1";
            this.buttonActive.UseVisualStyleBackColor = true;
            this.buttonActive.Click += new System.EventHandler(this.buttonActive_Click);
            // 
            // buttonOpenYcet
            // 
            this.buttonOpenYcet.Location = new System.Drawing.Point(12, 658);
            this.buttonOpenYcet.Name = "buttonOpenYcet";
            this.buttonOpenYcet.Size = new System.Drawing.Size(542, 117);
            this.buttonOpenYcet.TabIndex = 1;
            this.buttonOpenYcet.Text = "button2";
            this.buttonOpenYcet.UseVisualStyleBackColor = true;
            this.buttonOpenYcet.Click += new System.EventHandler(this.buttonOpenYcet_Click);
            // 
            // buttonOpenSotr
            // 
            this.buttonOpenSotr.Location = new System.Drawing.Point(12, 523);
            this.buttonOpenSotr.Name = "buttonOpenSotr";
            this.buttonOpenSotr.Size = new System.Drawing.Size(542, 117);
            this.buttonOpenSotr.TabIndex = 2;
            this.buttonOpenSotr.Text = "button3";
            this.buttonOpenSotr.UseVisualStyleBackColor = true;
            this.buttonOpenSotr.Click += new System.EventHandler(this.buttonOpenSotr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 919);
            this.Controls.Add(this.buttonOpenSotr);
            this.Controls.Add(this.buttonOpenYcet);
            this.Controls.Add(this.buttonActive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonActive;
        private System.Windows.Forms.Button buttonOpenYcet;
        private System.Windows.Forms.Button buttonOpenSotr;
    }
}