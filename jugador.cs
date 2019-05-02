using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serpintes_y_escaleras
{
    class jugador : dado
    {
        protected int posicion;
        protected int num_jugador;
        
        //iniciamos el constructor
        public jugador(int numero)
        {
            num_jugador = numero;
            posicion = 0;
        }

        public int adelante(int random)
        {
            posicion = posicion + random;

            if (posicion == 12) //Escalera
                posicion += 15;

            else if (posicion == 26) //Serpiente
                posicion -= 7;

            else if (posicion == 47) //Escalera
                posicion += 16;

            else if (posicion == 19) //Serpiente
                posicion -= 11;

            else if (posicion == 57) //Escalera
                posicion += 18;

            else if (posicion == 24) //Serpiente
                posicion -= 14;

            else if (posicion == 31) //Escalera
                posicion += 20;

            else if (posicion == 40) //Serpiente
                posicion -= 30;

            else if (posicion == 66) //Escalera
                posicion += 16;

            else if (posicion == 89) //Serpiente
                posicion -= 35;

            else if (posicion == 23) //Escalera
                posicion += 70;

            else if (posicion == 19) //Serpiente
                posicion -= 9;

            else if (posicion == 81) //Escalera
                posicion += 18;

            else if (posicion == 62) //Serpiente
                posicion -= 32;

            else if (posicion == 77) //Escalera
                posicion += 34;

            else if (posicion == 87) //Serpiente
                posicion -= 98;

            return posicion;
        }

    }
}
