namespace _20210930Feladar7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKis = new System.Windows.Forms.TextBox();
            this.txtNagy = new System.Windows.Forms.TextBox();
            this.txtOszto = new System.Windows.Forms.TextBox();
            this.btnSzam = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kisebb szám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nagyobb szám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Legnagyobb közös szám";
            // 
            // txtKis
            // 
            this.txtKis.Location = new System.Drawing.Point(304, 81);
            this.txtKis.Name = "txtKis";
            this.txtKis.Size = new System.Drawing.Size(100, 20);
            this.txtKis.TabIndex = 3;
            // 
            // txtNagy
            // 
            this.txtNagy.Location = new System.Drawing.Point(304, 135);
            this.txtNagy.Name = "txtNagy";
            this.txtNagy.Size = new System.Drawing.Size(100, 20);
            this.txtNagy.TabIndex = 4;
            // 
            // txtOszto
            // 
            this.txtOszto.Enabled = false;
            this.txtOszto.Location = new System.Drawing.Point(349, 231);
            this.txtOszto.Name = "txtOszto";
            this.txtOszto.Size = new System.Drawing.Size(100, 20);
            this.txtOszto.TabIndex = 5;
            // 
            // btnSzam
            // 
            this.btnSzam.Location = new System.Drawing.Point(183, 374);
            this.btnSzam.Name = "btnSzam";
            this.btnSzam.Size = new System.Drawing.Size(75, 23);
            this.btnSzam.TabIndex = 6;
            this.btnSzam.Text = "Számitás";
            this.btnSzam.UseVisualStyleBackColor = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(442, 374);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(75, 23);
            this.btnKilep.TabIndex = 7;
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
            this.Controls.Add(this.txtOszto);
            this.Controls.Add(this.txtNagy);
            this.Controls.Add(this.txtKis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKis;
        private System.Windows.Forms.TextBox txtNagy;
        private System.Windows.Forms.TextBox txtOszto;
        private System.Windows.Forms.Button btnSzam;
        private System.Windows.Forms.Button btnKilep;
    }
}

