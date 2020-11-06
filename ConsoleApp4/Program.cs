using System;
using System.Collections;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            #region AlgunasImplementaciones
            Hoja inicio = new Hoja();

            inicio.AsignarValor(25); //10

            inicio.ObtenerHijas()[0].AsignarValor(12); //25
            inicio.ObtenerHijas()[1].AsignarValor(10); //12

            inicio.ObtenerHijas()[0].ObtenerHijas()[0].AsignarValor(-8);
            inicio.ObtenerHijas()[0].ObtenerHijas()[1].AsignarValor(34);

            inicio.ObtenerHijas()[1].ObtenerHijas()[0].AsignarValor(-4);
            inicio.ObtenerHijas()[1].ObtenerHijas()[1].AsignarValor(-25);

            //ColaConPrioridad prioridad = new ColaConPrioridad();


            //prioridad.Encolar(12); //25

            //Console.WriteLine(prioridad.Pico().ObtenerValor());

            //prioridad.Encolar(10); //12

            //prioridad.Encolar(-8);

            //prioridad.Encolar(34);


            //prioridad.Encolar(-4);

            //prioridad.Encolar(-25);

            Console.WriteLine(inicio.ObtenerValor());

            Console.WriteLine(inicio.ObtenerHijas()[0].ObtenerValor());
            Console.WriteLine(inicio.ObtenerHijas()[1].ObtenerValor());

            Console.WriteLine(inicio.ObtenerHijas()[0].ObtenerHijas()[0].ObtenerValor());

            Console.WriteLine(inicio.ObtenerHijas()[0].ObtenerHijas()[1].ObtenerValor());

            Console.WriteLine(inicio.ObtenerHijas()[1].ObtenerHijas()[0].ObtenerValor());

            Console.WriteLine(inicio.ObtenerHijas()[1].ObtenerHijas()[1].ObtenerValor());

            Console.WriteLine();



            //Console.WriteLine(prioridad.Pico().ObtenerHijas()[0].ObtenerValor());
            //Console.WriteLine(prioridad.Pico().ObtenerHijas()[1].ObtenerValor());

            //Console.WriteLine(prioridad.Pico().ObtenerHijas()[0].ObtenerHijas()[0].ObtenerValor());

            //Console.WriteLine(prioridad.Pico().ObtenerHijas()[0].ObtenerHijas()[1].ObtenerValor());

            //Console.WriteLine(prioridad.Pico().ObtenerHijas()[1].ObtenerHijas()[0].ObtenerValor());

            //Console.WriteLine(prioridad.Pico().ObtenerHijas()[1].ObtenerHijas()[1].ObtenerValor());

            //Console.WriteLine();

            //Console.WriteLine("Valor Padre: {0}", inicio.ObtenerValor());
            //Console.WriteLine("Valor Hija izquierda: {0}", inicio.ObtenerHijas()[0].ObtenerValor());
            //Console.WriteLine("Valor Hija derecha: {0}", inicio.ObtenerHijas()[1].ObtenerValor());
            //Console.ReadLine();
            #endregion


            Console.ReadLine();

        }
    }
}
