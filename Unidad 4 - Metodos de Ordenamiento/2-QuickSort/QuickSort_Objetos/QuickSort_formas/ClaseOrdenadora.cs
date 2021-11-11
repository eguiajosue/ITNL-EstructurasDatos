using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuickSort_formas
{
    class ClaseOrdenadora<Tipo> where Tipo : IComparable<Tipo>
    {
        
        public delegate bool CriterioOrdenamiento(Tipo x, Tipo y);

        
        public static bool Ascendente(Tipo x, Tipo y)
        {
            if (x.CompareTo(y) > 0)
                return (true);
            else
                return (false);
        }

        
        public static bool Descendente(Tipo x, Tipo y)
        {
            if (x.CompareTo(y) < 0)
                return (true);
            else
                return (false);
        }

        private static void Intercambia(Tipo[] Arreglo, int a, int b)
        {
            Tipo Auxiliar;

            Auxiliar = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = Auxiliar;
        }

        private static void QSort(Tipo[] Arreglo, int intIzquierdo, int intDerecho, CriterioOrdenamiento Orden, ref int intComparaciones, ref int intMovimientos)
        {
            int izq, der;
            Tipo Pivote;


            Pivote = Arreglo[(intIzquierdo + intDerecho) / 2];
            izq = intIzquierdo;
            der = intDerecho;

            do
            {

                if (Orden.Method.Name.Equals("Ascendente"))
                {
                    while (Pivote.CompareTo(Arreglo[izq]) > 0)
                    {
                        izq++;
                        intComparaciones++;
                    }

                    while (Pivote.CompareTo(Arreglo[der]) < 0)
                    {
                        der--;
                        intComparaciones++;
                    }

                }
                else
                {
                    while (Pivote.CompareTo(Arreglo[izq]) < 0)
                    {
                        izq++;
                        intComparaciones++;
                    }

                    while (Pivote.CompareTo(Arreglo[der]) > 0)
                    {
                        der--;
                        intComparaciones++;
                    }
                }


                


                if (izq <= der)
                {
                    Intercambia(Arreglo, izq, der);
                    izq++;
                    der--;
                    intMovimientos++;
                }

            } while (izq <= der);


            if (intIzquierdo < der)
            {
                QSort(Arreglo, intIzquierdo, der, Orden, ref intComparaciones, ref intMovimientos);
            }


            if (izq < intDerecho)
            {
                QSort(Arreglo, der + 1, intDerecho, Orden, ref intComparaciones, ref intMovimientos);
            }

        }


        public static void QuickSort(Tipo[] Arreglo, CriterioOrdenamiento Orden, out int intComparaciones, out int intMovimientos, out int intMiliSegundos)
        {

            intComparaciones = 0;
            intMovimientos = 0;


            Stopwatch Reloj = Stopwatch.StartNew();


            QSort(Arreglo, 0, Arreglo.Length - 1, Orden, ref intComparaciones, ref intMovimientos);

            intMiliSegundos = Reloj.Elapsed.Milliseconds;
        }


    }
}
    

