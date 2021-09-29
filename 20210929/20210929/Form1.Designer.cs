namespace _20210929
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
            this.lblHonap = new System.Windows.Forms.Label();
            this.btnEvszak = new System.Windows.Forms.Button();
            this.btnKi = new System.Windows.Forms.Button();
            this.txtJa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "hónap száma";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblHonap
            // 
            this.lblHonap.AutoSize = true;
            this.lblHonap.Location = new System.Drawing.Point(355, 215);
            this.lblHonap.Name = "lblHonap";
            this.lblHonap.Size = new System.Drawing.Size(35, 13);
            this.lblHonap.TabIndex = 1;
            this.lblHonap.Text = "label2";
            // 
            // btnEvszak
            // 
            this.btnEvszak.Location = new System.Drawing.Point(123, 311);
            this.btnEvszak.Name = "btnEvszak";
            this.btnEvszak.Size = new System.Drawing.Size(75, 23);
            this.btnEvszak.TabIndex = 2;
            this.btnEvszak.Text = "Évszak";
            this.btnEvszak.UseVisualStyleBackColor = true;
            this.btnEvszak.Click += new System.EventHandler(this.BtnEvszak_Click);
            // 
            // btnKi
            // 
            this.btnKi.Location = new System.Drawing.Point(476, 333);
            this.btnKi.Name = "btnKi";
            this.btnKi.Size = new System.Drawing.Size(75, 23);
            this.btnKi.TabIndex = 3;
            this.btnKi.Text = "Kilépés";
            this.btnKi.UseVisualStyleBackColor = true;
            this.btnKi.Click += new System.EventHandler(this.BtnKi_Click);
            // 
            // txtJa
            // 
            this.txtJa.Location = new System.Drawing.Point(302, 107);
            this.txtJa.Name = "txtJa";
            this.txtJa.Size = new System.Drawing.Size(100, 20);
            this.txtJa.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtJa);
            this.Controls.Add(this.btnKi);
            this.Controls.Add(this.btnEvszak);
            this.Controls.Add(this.lblHonap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHonap;
        private System.Windows.Forms.Button btnEvszak;
        private System.Windows.Forms.Button btnKi;
        private System.Windows.Forms.TextBox txtJa;
    }
}

