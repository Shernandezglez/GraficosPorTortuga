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
             
        

        private int x,y;
        public int sentido;
        private bool pluma;

        public int pasos = 1, temp = 0;
        

        public Tortuga(int m, int n)
        {
            _piso = new bool[m, n];
            pluma = false;

            x = 0;
            y = 0;
            sentido = 2;
        }

        //inicializa todas las pociciones de la matriz a "false", excepto la primera posicion (0,0)
        public void inicializarMatriz()
        {
            for(int r = 1; r < 20 ; r++)
            {
                for(int c = 1; c < 20; c++)
                {
                    _piso[r, c] = false;
                }
            }
            _piso[0, 0] = true;
        }
        //asigna la variable "pluma a "true
        public bool plumaArriba()
        {
            if(pluma == false)
            {
                pluma = true;
            }
            return pluma;

        }
        //asigna la variable "pluma" a "false"
        public bool plumaAbajo()
        {
            if (pluma == true)
            {
                pluma = false;
            }
            return pluma;

        }

        //Metodo que llena la matriz "_piso" 
        //usando los ejes de un plano bidimensional (x,y),
        //dependera en que valor este la variable "sentido", 
        //si es 1 se llenara por el eje de Y positiva y si es 3 por el eje de Y negativa,
        //si es 2 usara el eje X positiva y con 4 el eje X negativa.
        public void avanzar()
        {
            switch (sentido)
            {
                case 1:
                    temp = y - pasos;
                    for(y = y; y >= temp; y--)
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
                    y++;
                    break;
                case 2:
                    
                    temp = x + pasos;
                    for (x = x + 1; x <= temp; x++)
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
                    x--;
                    
                    break;

                case 3:
                    
                    temp = y + pasos;
                    for( y = y + 1; y <= temp; y++)
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
                    y--;
                    break;
                    
                case 4:
                    temp = x - pasos;
                    for(x = x; x >= temp; x--)
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
                    x++;
                    break;
            }

            
        }

        //Muestra la matriz
        //si dicha posicion de esta matriz tiene como valor "false" imprmira un "_" en esa psicion,
        //y si es "true" asignara un "*";

      public string mostrarPiso()
        {
            string cdn = "";

            for (int r = 0; r < 20; r++)
            {

                for (int c = 0; c < 20; c++)
                {
                    if (_piso[r, c] == true)
                    {
                        cdn += "°" + "";  
                    }
                    else
                    {
                        cdn += "_" + "";
                      
                    }
                }
                cdn += "\r\n";
            }
           

            return cdn;
        }
        
    }
}
