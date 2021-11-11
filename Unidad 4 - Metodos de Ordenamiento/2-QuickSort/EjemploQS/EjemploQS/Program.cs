using System;
using System.Diagnostics;

namespace EjemploQS
{
    class Program
    {
       static int[] ArregloDatos;
        static void Main(string[] args)
        {
            GenerarDatosYOrdenar();
        
        }
       
      
        static void GenerarDatosYOrdenar()
        {
            Console.WriteLine("GENERAR ARREGLO");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Ingrese la cantidad de datos: ");
            int intCantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------");
            ArregloDatos = new int[intCantidad];
            Random intNumero = new Random();
            for (int i = 0; i < intCantidad; i++)
            {
                int intDato = 0;
                intDato = intNumero.Next(1, 10000) + 1;

                ArregloDatos[i] = intDato;

                Console.WriteLine(ArregloDatos[i]);

            }
            int intComparaciones, intMovimientos,intMilisegundos;
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("DATOS ORDENADOS POR EL QUICKSORT");
            Console.WriteLine("---------------------------------------------------");
            QuickSort(ArregloDatos,out intComparaciones,out intMovimientos,out intMilisegundos);
            foreach (int Dato in ArregloDatos)
            {
                Console.WriteLine(Dato);
            }
            Console.Write("\n\nComparaciones = " + intComparaciones.ToString("N0"));
            Console.Write("\nMovimientos   = " + intMovimientos.ToString("N0"));
            Console.Write("\nTiempo        = " + intMilisegundos.ToString("N0") + " ms.");

            Console.ReadKey();

        }
       
        static void QuickSort(int[] ArregloDatos, out int intComparaciones, out int intMovimientos, out int intMiliSegundos)
        {
            intComparaciones = 0;
            intMovimientos = 0;


            Stopwatch Reloj = Stopwatch.StartNew();

            QSort( ArregloDatos, 0, ArregloDatos.Length-1, ref intComparaciones, ref  intMovimientos);
            intMiliSegundos = Reloj.Elapsed.Milliseconds;
            return;
        }

        static void QSort(int[] Arreglo,int intIzquierdo, int intDerecho, ref int intComparaciones, ref int intMovimientos)
        {
            int intPivote =Arreglo[(int)(intIzquierdo + (int)intDerecho) / 2];
            
            int Izquierdo = intIzquierdo;
            int Derecho = intDerecho;
            do
            {
                while (intPivote > Arreglo[Izquierdo])
                {
                    Izquierdo++;
                    intComparaciones++;
                }
                while (intPivote < Arreglo[Derecho])
                {
                    Derecho--;
                    intComparaciones++;
                }
                if (Izquierdo <= Derecho)
                {
                    int intIntercambio = 0;
                    intIntercambio = Arreglo[Izquierdo];
                    Arreglo[Izquierdo] = Arreglo[Derecho];
                    Arreglo[Derecho] = intIntercambio;
                    Izquierdo++;
                    Derecho--;
                    intMovimientos++;
                }
            } while (Izquierdo <= Derecho);
            if (intIzquierdo < Derecho)
            {
                QSort(Arreglo, intIzquierdo,Izquierdo, ref intComparaciones, ref intMovimientos);
               
            }
            if (Izquierdo < intDerecho)
            {
                QSort(Arreglo, Derecho + 1, intDerecho, ref intComparaciones, ref intMovimientos);
            }
            
            return;

        }

      
    }
}
