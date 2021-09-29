using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEvszak_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtJa.Text);
            switch (a)
            {
                case 12:
                    lblHonap.Text = "Tél";
                    lblHonap.Visible = true;
                    break;
                case 1:
                    lblHonap.Text = "Tél";
                    lblHonap.Visible = true;
                    break;
                case 2:
                    lblHonap.Text = "Tél";
                    lblHonap.Visible = true;
                    break;
                case 3:
                    lblHonap.Text = "Tavasz";
                    lblHonap.Visible = true;
                    break;
                case 4:
                    lblHonap.Text = "Tavasz";
                    lblHonap.Visible = true;
                    break;
                case 5:
                    lblHonap.Text = "Tavasz";
                    lblHonap.Visible = true;
                    break;
                case 6:
                    lblHonap.Text = "Nyár";
                    lblHonap.Visible = true;
                    break;
                case 7:
                    lblHonap.Text = "Nyár";
                    lblHonap.Visible = true;
                    break;
                case 8:
                    lblHonap.Text = "Nyár";
                    lblHonap.Visible = true;
                    break;
                case 9:
                    lblHonap.Text = "Ősz";
                    lblHonap.Visible = true;
                    break;
                case 10:
                    lblHonap.Text = "Ősz";
                    lblHonap.Visible = true;
                    break;
                case 11:
                    lblHonap.Text = "Ősz";
                    lblHonap.Visible = true;
                    break;
                default:
                    MessageBox.Show("Nem jó a hónap szám ;(");
                    break;

            }
        }
    }
}
