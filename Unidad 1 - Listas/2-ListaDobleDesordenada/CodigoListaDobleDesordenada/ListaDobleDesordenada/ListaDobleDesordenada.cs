using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleDesordenada
{
    class ListaDobleDesordenada<Tipo> where Tipo:IEquatable<Tipo>
    {
        private Nodo<Tipo> _nodoInicial;
        public Nodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        private Nodo<Tipo> _nodoFinal;
        public Nodo<Tipo> NodoFinal
        {
            get { return _nodoFinal; }
            set { _nodoFinal = value; }
        }

        public ListaDobleDesordenada()
        {
            NodoInicial = null;
            NodoFinal = null;
        }

        public bool Vacia
        {
            get
            {
                if(NodoInicial == null && NodoFinal == null) return true;
                else return false;
            }
        }

        public IEnumerable<Tipo> HaciaAdelante
        {
            get
            {
                if (Vacia) yield break;
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                yield break;
            }
        }

        public IEnumerable<Tipo> HaciaAtras
        {
            get
            {
                if (Vacia) yield break;
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoFinal;
                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Anterior;
                } while (nodoActual != null);
            }
        }


        public void AgregarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nuevoNodo.Anterior = null;
                nuevoNodo.Siguiente = null;
                NodoInicial = nuevoNodo;
                NodoFinal = nuevoNodo;
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoFinal;

                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("No se permiten objetos duplicados");
                    }
                    else
                    {
                        nodoActual = nodoActual.Anterior;
                    }
                } while (nodoActual != null);


                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nuevoNodo.Siguiente = null;
                nuevoNodo.Anterior = NodoFinal;
                NodoFinal.Siguiente = nuevoNodo;
                NodoFinal = nuevoNodo;
            }
        }


        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra vacía actualmente");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = NodoFinal;
                nodoPrevio = NodoFinal;

                if (NodoInicial.ObjetoConDatos.Equals(objeto) && NodoFinal.ObjetoConDatos.Equals(objeto))
                {
                    Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                    NodoInicial = null;
                    NodoFinal = null;
                    return objetoConDatos;
                }
                else if (NodoInicial.ObjetoConDatos.Equals(objeto))
                {
                    Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                    NodoInicial = NodoInicial.Siguiente;
                    NodoInicial.Anterior = null;
                    return objetoConDatos;
                }
                else if (NodoFinal.ObjetoConDatos.Equals(objeto))
                {
                    Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                    NodoFinal = NodoFinal.Anterior;
                    NodoFinal.Siguiente = null;
                    return objetoConDatos;
                }
                else
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Anterior;
                }
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                        nodoActual.Anterior.Siguiente = nodoPrevio;
                        nodoPrevio.Anterior = nodoActual;
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Anterior;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontró el elemento para eliminar");
            }
        }


        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacía");
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoFinal;

                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    else
                    {
                        nodoActual = nodoActual.Anterior;
                    }
                } while (nodoActual != null);
                throw new Exception("El objeto que está buscando no existe");
            }
        }


        public void Vaciar()
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacía");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = NodoFinal;
                nodoPrevio = NodoFinal;

                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Anterior;
                    nodoPrevio = null;
                } while (nodoActual != null);
                NodoInicial = null;
                NodoFinal = null;
            }
        }


        ~ListaDobleDesordenada()
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
