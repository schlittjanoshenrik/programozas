namespace _20210930Feladat8
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
            this.lblSzam = new System.Windows.Forms.Label();
            this.btnSzam = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSzam
            // 
            this.lblSzam.AutoSize = true;
            this.lblSzam.Location = new System.Drawing.Point(136, 69);
            this.lblSzam.Name = "lblSzam";
            this.lblSzam.Size = new System.Drawing.Size(35, 13);
            this.lblSzam.TabIndex = 0;
            this.lblSzam.Text = "label1";
            // 
            // btnSzam
            // 
            this.btnSzam.Location = new System.Drawing.Point(139, 317);
            this.btnSzam.Name = "btnSzam";
            this.btnSzam.Size = new System.Drawing.Size(75, 23);
            this.btnSzam.TabIndex = 1;
            this.btnSzam.Text = "Számit";
            this.btnSzam.UseVisualStyleBackColor = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(282, 317);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 2;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnSzam);
            this.Controls.Add(this.lblSzam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSzam;
        private System.Windows.Forms.Button btnSzam;
        private System.Windows.Forms.Button btnKilep;
    }
}

