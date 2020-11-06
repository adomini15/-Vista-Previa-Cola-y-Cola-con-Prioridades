using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public sealed class Hoja : ICloneable
    {
        //Hicimos este atributo nullable.
        private int? valor = null;
        //El elemento con indice cero sera el de la izquierda, y el 1 sera el de la derecha.
        private Hoja[] hijas;
        //Variable que almacenara una referencia de la hoja padre.
        private Hoja padre = null;

        public void AsignarValor(int valor)
        {
            this.valor = valor;
            InicializarHijas();

            IntercambiarValores(this, padre);

        }

        private void IntercambiarValores(Hoja actual, Hoja padre)
        {
            //Aqui utilice recursividad para poder compararar ademas entre el padre y el objeto actual, tambien entre el padre y su abuelo, y su abuelo y su visabuelo, etc.
            if (!(padre is null) && actual.valor < padre.valor)
            {
                int? valorTemporal = padre.valor;
                padre.valor = actual.valor;
                actual.valor = valorTemporal;

                IntercambiarValores(actual.padre, padre.padre);
                
            }
        }

        private void InicializarHijas()
        {
            hijas = new Hoja[2];

            for (int i = 0; i < hijas.Length; i++)
            {
                hijas[i] = new Hoja();
                hijas[i].AsignarPadre(this);
            }
        }

        private void AsignarPadre(Hoja hoja_padre)
        {
            padre = hoja_padre;
        }

        public int? ObtenerValor()
        {
            return valor;

        }

        public Hoja[] ObtenerHijas()
        {
            return hijas;
        }

        public Hoja HijaIzquierda()
        {
            return hijas[0];
        }

        public Hoja HijaDerecha()
        {
            return hijas[1];
        }

        public Hoja ObtenerPadre()
        {
            return padre;
        }

        //Implemento la interfaz ICloneable para tener la capacidad de clonar Hoja's
        public object Clone()
        {
            Hoja temporal = new Hoja();
            temporal.valor = valor;
            return temporal;
        }
    }
}
