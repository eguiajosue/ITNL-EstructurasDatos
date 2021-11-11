using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_formas
{
    class Empleado: IComparable<Empleado>
    {

        private int _intNumero;
        public int Numero
        {
            get { return _intNumero; }
            set { _intNumero = value; }
        }

        private string _strNombre;
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private double _dblSueldo;
        public double Sueldo
        {
            get { return _dblSueldo; }
            set { _dblSueldo = value; }
        }

      

        public int CompareTo(Empleado x)
        {
            if (this.Numero < x.Numero)
                return (-1);
            else
                if (this.Numero > x.Numero)
                return (1);
            else
                return (0);
        }

       /* public static int OrdenarPorNombre(Empleado x)
        {
            if (this.Nombre < x.Nombre)
                return (-1);
            else
                if (this.Nombre > x.Nombre)
                return (1);
            else
                return (0);
        }

        public static int OrdenarPorSueldo(Empleado x)
        {
            if (this.Sueldo < x.Sueldo)
                return (-1);
            else
                if (this.Sueldo > x.Sueldo)
                return (1);
            else
                return (0);
        }*/

    }
}
