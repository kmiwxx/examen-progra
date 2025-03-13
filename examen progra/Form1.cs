using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_progra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 
            if (int.TryParse(txtnumero1.Text, out int num1))
            {
                if (int.TryParse(txtnumero2.Text, out int num2))
                {
                    // 
                    if (num1 > num2)
                    {
                        MessageBox.Show($"El número {num1} es mayor que {num2}");
                    }
                    else if (num1 < num2)
                    {
                        MessageBox.Show($"El número {num2} es mayor que {num1}");
                    }
                    else
                    {
                        MessageBox.Show("Los dos son igualeeees .");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa uno valido en el segundooo.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa uno valido en el primerooo .");
            }
        }

        private void txtnumero2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
