using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploQS
{
    class Dato :IEquatable<Dato>
    {
        private int _intDatoIngresado;

        public int DatoIgresado
        {
            get { return _intDatoIngresado; }
            set { _intDatoIngresado = value; }
        }

        public bool Equals (Dato otroDato)
        {
            if (this.DatoIgresado == otroDato.DatoIgresado)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return this.DatoIgresado.ToString();
        }
    }
}
