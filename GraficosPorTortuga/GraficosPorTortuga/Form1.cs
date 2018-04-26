using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosPorTortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tortuga ar = new Tortuga(20,20);

        private void button1_Click(object sender, EventArgs e)
        {
            ar.plumaArriba();
            txtPlumaEstado.Text = Convert.ToString(ar.plumaArriba());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ar.plumaAbajo();
            txtPlumaEstado.Text = Convert.ToString(ar.plumaAbajo());
        }
    }
}
