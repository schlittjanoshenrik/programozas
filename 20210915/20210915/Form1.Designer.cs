namespace _20210915
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
            this.btnOssze = new System.Windows.Forms.Button();
            this.btnKivon = new System.Windows.Forms.Button();
            this.btnSzor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOssze
            // 
            this.btnOssze.Location = new System.Drawing.Point(45, 201);
            this.btnOssze.Name = "btnOssze";
            this.btnOssze.Size = new System.Drawing.Size(75, 23);
            this.btnOssze.TabIndex = 0;
            this.btnOssze.Text = "Összeadás";
            this.btnOssze.UseVisualStyleBackColor = true;
            this.btnOssze.Click += new System.EventHandler(this.BtnOssze_Click);
            // 
            // btnKivon
            // 
            this.btnKivon.Location = new System.Drawing.Point(45, 277);
            this.btnKivon.Name = "btnKivon";
            this.btnKivon.Size = new System.Drawing.Size(75, 23);
            this.btnKivon.TabIndex = 1;
            this.btnKivon.Text = "Kivonás";
            this.btnKivon.UseVisualStyleBackColor = true;
            // 
            // btnSzor
            // 
            this.btnSzor.Location = new System.Drawing.Point(45, 354);
            this.btnSzor.Name = "btnSzor";
            this.btnSzor.Size = new System.Drawing.Size(75, 23);
            this.btnSzor.TabIndex = 2;
            this.btnSzor.Text = "Szorzás";
            this.btnSzor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adat1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adat2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eredmény";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Művelet:";
            // 
            // txtB3
            // 
            this.txtB3.Location = new System.Drawing.Point(490, 178);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(100, 20);
            this.txtB3.TabIndex = 7;
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(137, 37);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(100, 20);
            this.txtB1.TabIndex = 8;
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(137, 81);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(100, 20);
            this.txtB2.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(537, 148);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 13);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Néha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSzor);
            this.Controls.Add(this.btnKivon);
            this.Controls.Add(this.btnOssze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOssze;
        private System.Windows.Forms.Button btnKivon;
        private System.Windows.Forms.Button btnSzor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.Label lbl1;
    }
}

