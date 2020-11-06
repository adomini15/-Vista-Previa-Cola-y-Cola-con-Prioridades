using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Cola 
    {
        private List<object> lista = new List<object>();

        public object Desencolar()
        {
            object temp = lista[0];
            lista.RemoveAt(0);
            return temp;
        }

        public void Encolar(object elemento)
        {
            lista.Add(elemento);
        }

        public object Pico()
        {
            return lista[0];
        }

       
    }

    class Cola<T> 
    {
        private List<T> lista = new List<T>();

        public T Desencolar()
        {
            T temp = lista[0];
            lista.RemoveAt(0);
            return temp;
        }

        public void Encolar(T elemento)
        {
            lista.Add(elemento);
        }

        public T Pico()
        {
            return lista[0];
        }
    }
}
