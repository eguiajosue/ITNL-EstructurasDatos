using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EguiaRodriguezJosueFrancisco
{
    class Nodo<Tipo>
    {
        #region Objeto con Datos del Objeto
        private Tipo _objetoConDatos;
        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }
        #endregion

        #region Siguiete Nodo
        private Nodo<Tipo> _siguiente;
        public Nodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        #endregion

        #region Destructor 
        ~Nodo()
        {
            _objetoConDatos = default(Tipo);
        }
        #endregion
    }
}
