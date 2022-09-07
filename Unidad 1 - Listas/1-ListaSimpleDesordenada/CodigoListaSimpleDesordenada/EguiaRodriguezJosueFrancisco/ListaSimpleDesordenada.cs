using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EguiaRodriguezJosueFrancisco
{
    class ListaSimpleDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        #region "Nodo Inicial"
        private Nodo<Tipo> _nodoInicial;
        private Nodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }
        #endregion

        #region Vacia
        public bool Vacia
        {
            get { return NodoInicial == null; }
        }
        #endregion

        #region Constructor
        public ListaSimpleDesordenada()
        {
            NodoInicial = null;
        }
        #endregion

        #region Método para recorrer la lista
        public IEnumerator<Tipo> GetEnumerator()
        {
            if (NodoInicial == null)
            {
                yield break;
            }
            else
            {
                Nodo<Tipo> nodoActual = NodoInicial;

                do
                {
                    yield return ( nodoActual.ObjetoConDatos );
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);

                yield break;
            }
        }
        #endregion

        #region Agregar Nodo
        /// <summary>
        /// Método para agregar un nuevo objeto a la lista
        /// </summary>
        /// <param name="objeto">Se pasa el objeto que se agregará a la lista</param>
        /// <exception cref="Exception"></exception>
        public void AgregarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                Nodo<Tipo> nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                NodoInicial = nodoNuevo;
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                nodoPrevio = NodoInicial;

                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        throw new Exception("No se permiten datos duplicados");
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }

                } while (nodoActual != null);

                Nodo<Tipo> nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                nodoPrevio.Siguiente = nodoNuevo;
            }
        }
        #endregion

        #region Buscar nodo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista está vacía actualmente");
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoInicial;

                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    else
                    {
                        nodoActual = nodoActual.Siguiente;
                    }

                } while (nodoActual != null);

                throw new Exception("El elemento que está buscando no existe");
            }
        }
        #endregion

        #region Eliminar Nodo
        /// <summary>
        /// Se recibe un método y se recorre la lista, si se encuentrá el nodo introducido entonces se eliminará de la lista
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>Retorna los datos del objeto a eliminar</returns>
        /// <exception cref="Exception"></exception>
        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra vacía");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                nodoPrevio = NodoInicial;

                do
                {
                    if (NodoInicial.ObjetoConDatos.Equals(objeto))
                    {
                        Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                        NodoInicial = NodoInicial.Siguiente;
                        return objetoConDatos;
                    }
                    else if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        nodoPrevio.Siguiente = nodoActual.Siguiente;
                        Tipo objetoDatos = nodoActual.ObjetoConDatos;
                        nodoActual = null;
                        return objetoDatos;
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontró el elemento para eliminar");
            }
        }
        #endregion

        #region Vaciar Lista
        /// <summary>
        /// Método para vaciar la lista
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void Vaciar()
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacia");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                nodoPrevio = NodoInicial;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                }
                while (nodoActual != null);
                NodoInicial = null;
            }
            
        }
        #endregion

        #region Destructor
        ~ListaSimpleDesordenada()
        {
            try
            {
                Vaciar();
            }
            catch (Exception)
            {
                
            }
        }
        #endregion
    }
}
