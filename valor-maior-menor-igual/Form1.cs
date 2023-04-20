using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valor_maior_menor_igual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValor1.Text);
            int v2 = Convert.ToInt32(txtValor2.Text);

            if (v1 < v2)
            {
                MessageBox.Show("O valor " + v2 + " é o maior!");
                MessageBox.Show("O valor " + v1 + " é o menor!");
                
            }
            else if (v1 > v2)
            {
                MessageBox.Show("O valor " + v1 + " é o maior!");
                MessageBox.Show("O valor " + v2 + " é o menor!");
            }
            else if (v1 == v2)
            {
                MessageBox.Show("Os valores são iguais!!");
            }

        }
    }
}
