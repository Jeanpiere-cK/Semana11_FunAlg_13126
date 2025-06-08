using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Clase1;

namespace Semana11_FunAlg_13126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notas FunAlg_13126 = new Notas();

            FunAlg_13126.CalificarT1();
            Thread.Sleep(2);
            FunAlg_13126.CalificarT2();
            Thread.Sleep(2);
            FunAlg_13126.CalificarT3();
            Thread.Sleep(2);
            FunAlg_13126.CalificarEF();

            int op;

            do
            {
                Console.Clear();
                Console.WriteLine(":!:! NOTAS DE FUN. ALGORITMOS :!:! ");
                Console.WriteLine("1. Mostrar Notas T1");
                Console.WriteLine("2. Mostrar Notas T2");
                Console.WriteLine("3. Mostrar Notas T3");
                Console.WriteLine("4. Mostrar Notas EF");
                Console.WriteLine("5. Mostrar Promedio");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Ingrese una opcion...");
                op = int.Parse(Console.ReadLine());

                FunAlg_13126.MostrarNotas(op);
                Console.ReadKey();
            }
            while (op!=0);
        }
        
    }
}
