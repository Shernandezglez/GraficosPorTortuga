using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficosPorTortuga
{
    class Tortuga
    {
        private bool[,] _matr;
        private bool pluma;

        public Tortuga(int m, int n)
        {
            _matr = new bool[m, n];
            pluma = true;
        }

        public void inicializarMatriz()
        {
            for(int r = 0; r < _matr.Length -1; r++)
            {
                for(int c = 0; c < _matr.Length-1; c++)
                {
                    _matr[r, c] = false;
                }
            }
        }

        public bool plumaArriba()
        {
            if(pluma == false)
            {
                pluma = true;
            }
            return pluma;

        }

        public bool plumaAbajo()
        {
            if (pluma == true)
            {
                pluma = false;
            }
            return pluma;

        }

        public void llenarMatriz()
        {
            if(pluma == false)
            {
                for (int r = 0; r < _matr.Length - 1; r++)
                {
                    for (int c = 0; c < _matr.Length - 1; c++)
                    {
                        _matr[r, c] = true;
                    }
                }
            }

            else
            {
                for (int r = 0; r < _matr.Length - 1; r++)
                {
                    for (int c = 0; c < _matr.Length - 1; c++)
                    {
                        _matr[r, c] = false;
                    }
                }
            }
        }


        public string mostrarMatriz()
        {
            string cosa = "";

            for (int r = 0; r < _matr.Length - 1; r++)
            {
                for (int c = 0; c < _matr.Length - 1; c++)
                {
                   
                }
            }
            return cosa;
        }
    }
}
