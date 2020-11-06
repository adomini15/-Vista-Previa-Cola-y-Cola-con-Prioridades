using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public interface ICola<T>
    {
        public void Encolar(int elemento);
        public T Desencolar();
        public T Pico();

    
    }
}
