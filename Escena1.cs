using System;
using System.Collections.Generic;
using System.Text;

namespace Clase4Ejercicio1
{
    internal class Escena1
    {
        public static void Iniciar()
        {
            Console.Clear();
            Console.WriteLine("ESCENA 1: EL ATAQUE");
            Console.WriteLine("la horda avanzaba a pasos agigantados, detruyendo todo lo que encuentro en su camino");
            Console.WriteLine("Mustafa mira como su reino es atacado a pedazos");
            Console.WriteLine("Mustafa decide:");
            Console.WriteLine("1. Coorer");
            Console.WriteLine("2. Luchar");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                War();
            }
            else if (opcion == "2")
            {
                run();
            }
            else
            {
                Reintentar();
            }

            Console.WriteLine("Mustafa es atrapado por la horda");
        }

        static void Reintentar()
        {
            Console.WriteLine("Opción no válida...");
            Console.ReadKey();
            Iniciar();
        }
        static void War()
        {
        }
        static void run()
        {
        }
    }
}
