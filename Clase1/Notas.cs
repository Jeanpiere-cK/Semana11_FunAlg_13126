using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Notas
    {
        int[] notaT1 = new int[20];
        int[] notaT2 = new int[20];
        int[] notaT3 = new int[20];
        int[] notaEF = new int[20];
        public void CalificarT1()
        {
            Random r = new Random();
            for (int i = 0; i < notaT1.Length; i++)
            {
                notaT1[i] = r.Next(1, 21);
            }
        }
        private void MostrarT1()
        {
            foreach (int item in notaT1)
            {
                Console.WriteLine(item);
            }
            //PARA CADA x PONLE UN y, 
            //Usamos ForEach, pero tambíés es posible usar For
            //A continuación un ejemplo de como sería:

            /*for (int i = 0; i < notaT1.Length; i++)
            {
                Console.WriteLine(notaT1[i]);
            }
            */
        }
        public void CalificarT2()
        {
            Random r = new Random();
            for (int i = 0; i < notaT1.Length; i++)
            {
                notaT2[i] = r.Next(1, 21);
            }
        }
        private void MostrarT2()
        {
            foreach (int item in notaT2)
            {
                Console.WriteLine(item);
            }
        }
        public void CalificarT3()
        {
            Random r = new Random();
            for (int i = 0; i < notaT1.Length; i++)
            {
                notaT3[i] = r.Next(1, 21);
            }
        }
        private void MostrarT3()
        {
            foreach (int item in notaT3)
            {
                Console.WriteLine(item);
            }
        }
        public void CalificarEF()
        {
            Random r = new Random();
            for (int i = 0; i < notaT1.Length; i++)
            {
                notaEF[i] = r.Next(1, 21);
            }
        }
        private void MostrarEF()
        {
            foreach (int item in notaEF)
            {
                Console.WriteLine(item);
            }
        }
        public void MostrarNotas(int op)
        {
            switch (op)
            {
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                case 1:
                    MostrarT1();
                    break;
                case 2:
                    MostrarT2();
                    break;
                case 3:
                    MostrarT3();
                    break;
                case 4:
                    MostrarEF();
                    break;
                case 5:
                    for (int i = 0; i < notaT1.Length; i++)
                    {
                        double prom = ((double)notaT1[i] + notaT2[i] + notaT3[i] + notaEF[i])/4;
                        Console.WriteLine("Alumno " + i + ": " + notaT1[i]
                            + "\t" + notaT2[i]
                            + "\t" + notaT3[i]
                            + "\t" + notaEF[i]
                            +"\t" + prom);

                    }
                    break;
                default:
                    Console.WriteLine("Ingrese una opción valida");
                    break;
            }
        }

    }
}
