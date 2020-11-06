using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ColaConPrioridad : ICola<Hoja>
    {
        /* Utilizo readonly para que desde afuera, cuando se llame el metodo Pico y se obtenga la hoja en el pico, no podamos modificar los valores
        de sus atributos ya sea el medio que sea*/
        private Hoja pico;
        private Hoja apuntador;
        private int x = 0, y = 0;

        public Hoja Desencolar()
        {
            throw new NotImplementedException();
        }

        public void Encolar(int elemento)
        {
            if (apuntador is null)
            {
                apuntador = new Hoja();
                apuntador.AsignarValor(elemento);
                pico = (Hoja) apuntador.Clone();
            }
            else //if (x < ultimaAgregada.ObtenerHijas().Length)
            {
                apuntador.ObtenerHijas()[x].AsignarValor(elemento);
                x++;

                if (y == 1)
                {
                    apuntador = apuntador.ObtenerPadre().ObtenerHijas()[y];
                    y = 0;
                }
                
                if(x == apuntador.ObtenerHijas().Length)
                {                                       
                    apuntador = apuntador.ObtenerHijas()[y];
                    y++;
                    x = 0;
                } 
               
            } 
        }

        //Retornamos una copia, en vez del original, por temas de seguridad.
        public Hoja Pico()
        {
            return pico;
        }
    }
}
