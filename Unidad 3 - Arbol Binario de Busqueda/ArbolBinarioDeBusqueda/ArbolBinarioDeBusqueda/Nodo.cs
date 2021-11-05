using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda
{
    class Nodo<Tipo>
    {
        private Tipo _objetoConDatos;
        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        private Nodo<Tipo> _hijoIzq;
        public Nodo<Tipo> HijoIzq
        {
            get { return _hijoIzq; }
            set { _hijoIzq = value; }
        }

        private Nodo<Tipo> _hijoDer;
        public Nodo<Tipo> HijoDer
        {
            get { return _hijoDer; }
            set { _hijoDer = value; }
        }

        ~Nodo()
        {
            _objetoConDatos = default(Tipo);
        }
    }
}
