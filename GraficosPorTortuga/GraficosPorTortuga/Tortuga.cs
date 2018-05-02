using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficosPorTortuga
{
    class Tortuga
    {
        private bool[,] _piso;
        private string[,] _temp;       
        

        private int x,y;
        public int sentido;
        private bool pluma;


        public Tortuga(int m, int n)
        {
            _piso = new bool[m, n];
            _temp = new string[m, n];
            pluma = false;

            x = 0;
            y = 0;
            sentido = 2;
        }

        public void inicializarMatriz()
        {
            for(int r = 0; r < _piso.Length -1; r++)
            {
                for(int c = 0; c < _piso.Length-1; c++)
                {
                    _piso[r, c] = false;
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

        public void avanzar()
        {
            int pasos = 5;
            
            switch (sentido)
            {
                case 1:
                    for(y = pasos; y >= 0; y--)
                    {
                        if (pluma == true)
                        {
                            _piso[y, x] = false;
                        }
                        else
                        {
                            _piso[y, x] = true;
                        }
                    }
                    break;
                case 2:
                    for (x = x + 1; x <= pasos; x++)
                    {

                        if (pluma == true)
                        {
                            _piso[y, x] = false;
                        }
                        else
                        {
                            _piso[y, x] = true;
                        }
                    }
                    break;
                case 3:
                    for( y = y+1; y <= pasos; y++)
                    {
                        if (pluma == true)
                        {
                            _piso[y, x] = false;
                        }
                        else
                        {
                            _piso[y, x] = true;
                        }
                    }
                    break;
                case 4:
                    for(x = pasos; x >= 0; x--)
                    {
                        if (pluma == true)
                        {
                            _piso[y, x] = false;
                        }
                        else
                        {
                            _piso[y, x] = true;
                        }
                    }
                    break;
            }

            
        }
       
       public string mostrar()
        {
            string cdn = "";

            for(int r = 0; r < 20; r++)
            {

                for(int c = 0; c < 20; c++)
                {
                    if(_piso[r,c] == true)
                    {
                        cdn += "*" + " ";
                        //_temp[r, c] = "*";
                    }
                    else
                    {
                        cdn += " " + " ";
                        //_temp[r, c] = " ";
                    }

                    //cdn += _temp[r, c].ToString() + " ";
                }

            }
                cdn += "\r\n";

            return cdn;

        }
        
    }
}
