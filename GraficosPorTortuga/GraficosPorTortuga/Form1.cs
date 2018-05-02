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

        private void btnArriba_Click(object sender, EventArgs e)
        {
            ar.sentido = 1;
            ar.avanzar();
            txtResultados.Text = ar.mostrar();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            ar.avanzar();
            txtResultados.Text = ar.mostrar();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            ar.sentido = 3;
            ar.avanzar();
            txtResultados.Text = ar.mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ar.sentido = 4;
            ar.avanzar();
            txtResultados.Text = ar.mostrar();
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            ar.plumaArriba();
        }

        private void btnPlumaAbjo_Click(object sender, EventArgs e)
        {
            ar.plumaAbajo();
        }
    }
}
