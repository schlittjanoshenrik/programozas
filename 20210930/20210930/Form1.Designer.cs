namespace _20210930
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
            this.txtSzam = new System.Windows.Forms.TextBox();
            this.txtGyok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSzam = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSzam
            // 
            this.txtSzam.Location = new System.Drawing.Point(311, 64);
            this.txtSzam.Name = "txtSzam";
            this.txtSzam.Size = new System.Drawing.Size(100, 20);
            this.txtSzam.TabIndex = 0;
            // 
            // txtGyok
            // 
            this.txtGyok.Enabled = false;
            this.txtGyok.Location = new System.Drawing.Point(311, 124);
            this.txtGyok.Name = "txtGyok";
            this.txtGyok.Size = new System.Drawing.Size(100, 20);
            this.txtGyok.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Négyzetgyök ";
            // 
            // btnSzam
            // 
            this.btnSzam.Location = new System.Drawing.Point(210, 341);
            this.btnSzam.Name = "btnSzam";
            this.btnSzam.Size = new System.Drawing.Size(75, 23);
            this.btnSzam.TabIndex = 4;
            this.btnSzam.Text = "Számítás";
            this.btnSzam.UseVisualStyleBackColor = true;
            this.btnSzam.Click += new System.EventHandler(this.BtnSzam_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(381, 341);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 5;
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGyok);
            this.Controls.Add(this.txtSzam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSzam;
        private System.Windows.Forms.TextBox txtGyok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSzam;
        private System.Windows.Forms.Button btnKilep;
    }
}

