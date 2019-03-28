using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PINGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPin_MouseDown(object sender, MouseEventArgs e)
        {
            txtPin.Clear();
        }
        int hak = 3;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            try
            {
                int pin = Convert.ToInt32(txtPin.Text);
                if(pin == 1234)
                {
                    MessageBox.Show("PIN Doğru!");
                    this.Close();
                }
                else if(hak == 0)
                {
                    MessageBox.Show("Hakkınız Doldu!");
                    btnGiris.Enabled = false;

                }
                else
                {
                    hak--;
                    lblHak.Text = hak.ToString();
                    MessageBox.Show("PIN Yanlış");


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayı Giriniz.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
