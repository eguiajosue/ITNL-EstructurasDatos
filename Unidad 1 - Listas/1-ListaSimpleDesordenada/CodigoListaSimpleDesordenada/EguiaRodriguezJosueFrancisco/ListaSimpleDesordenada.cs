using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EguiaRodriguezJosueFrancisco
{
    class ListaSimpleDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        private Nodo<Tipo> _nodoInicial;
        private Nodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        public bool Vacia
        {
            get { return NodoInicial == null; }
        }
        
        public ListaSimpleDesordenada()
        {
            NodoInicial = null;
        }

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
    }
}
