using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            Thread hilo1 = new Thread(MetodoPorEjecutar);
            Thread hilo2 = new Thread(MetodoPorEjecutar);

            Console.WriteLine("La cultura del hilo principal es: {0}", Thread.CurrentThread.CurrentCulture);
            Console.WriteLine("Voy a ejecutar el hilo 1");
            hilo1.Start();
            Console.WriteLine("Voy a ejecutar el hilo 2");
            hilo2.Start();

            //el hilo principal se duerme un segundo
            Thread.Sleep(1000);

            //el join retorna los hilos al principal
            Console.WriteLine("El hilo uno se junta");
            hilo1.Join();
            Console.WriteLine("El hilo dos se junta");
            hilo2.Join();
            */

            Thread corredor1 = new Thread(Carrera.Corredor);
            Thread corredor2 = new Thread(Carrera.Corredor);
            Thread corredor3 = new Thread(Carrera.Corredor);
            Thread corredor4 = new Thread(Carrera.Corredor);

            corredor1.Start("Anthony");
            corredor2.Start("Tania");
            corredor3.Start("Brayan");
            corredor4.Start("Majo");

            corredor1.Join();
            corredor2.Join();
            corredor3.Join();
            corredor4.Join();
            
         
        }

        static void MetodoPorEjecutar()
        {
            //TO DO: Aqui pon tu codigo
            //almacenar hilo actual
            var hiloActual = Thread.CurrentThread;
            hiloActual.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Hilo actual {0}: ",hiloActual.ManagedThreadId);
            Console.WriteLine("Mi cultura es {0}: ", hiloActual.CurrentCulture);

            var random = new Random();

            for (int i =0; i <= 10; i++) 
            {
                Console.WriteLine("hilo {0} indice {1}", hiloActual.ManagedThreadId, i);
                Thread.Sleep(random.Next(100,500));
            }

           
        }

    }
}
