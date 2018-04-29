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
        private string[,] _temp;       
        

        private int posXini = 0, posYini = 0, posXfinal = 0, posYfinal = 0, x = 0, y = 0;
        
        private bool pluma;

        public Tortuga(int m, int n)
        {
            _matr = new bool[m, n];
            _temp = new string[m, n];
            pluma = false;
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

        public void comandos(int command)
        {
            int pasos = 5;
            if(command == 1)
            {
                for(posYini = 0; posYini <= pasos; posYini++)
                {

                }
            }

            if(command == 2)
            {
                
            }

            if(command == 3)
            {
                
            }
        }
       
       public string mostrar()
        {
            string cdn = "";

            for(int r = 0; r < 20; r++)
            {

                for(int c = 0; c < 20; c++)
                {
                    if(_matr[r,c] == true)
                    {
                        _temp[r, c] = "*";
                    }
                    else
                    {
                        _temp[r, c] = " ";
                    }

                    cdn += _temp[r, c].ToString() + " ";
                }

            }
                cdn += "\r\n";

            return cdn;

        }
        
    }
}
