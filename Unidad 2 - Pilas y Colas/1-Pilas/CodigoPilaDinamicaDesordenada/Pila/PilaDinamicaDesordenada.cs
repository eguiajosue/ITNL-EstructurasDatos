using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class PilaDinamicaDesordenada<Tipo> where Tipo : IEquatable<Tipo>
    {
        private Nodo<Tipo> _top;
        public Nodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public PilaDinamicaDesordenada()
        {
            Top = null;
        }

        public bool Vacia
        {
            get { return Top == null; }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            else
            {
                Nodo<Tipo> nodoActual = Top;
                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                yield break;
            }
        }

        public void Push(Tipo objeto)
        {
            if (Vacia)
            {
                Nodo<Tipo> nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                Top = nodoNuevo;
            } 
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = Top;

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
                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nuevoNodo.Siguiente = Top;
                Top = nuevoNodo;
            }
        }

        public Tipo Pop()
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacía");
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                Nodo<Tipo> nodoEliminado = new Nodo<Tipo>();
                nodoActual = Top;

                Top = nodoActual.Siguiente;
                nodoEliminado = nodoActual;
                nodoActual = null;

                return nodoEliminado.ObjetoConDatos;
            }
        }

        public Tipo Pop(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacia");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = Top;

                do
                {
                    if (Top.ObjetoConDatos.Equals(objeto))
                    {
                        Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                        Top = Top.Siguiente;

                        return objetoConDatos;
                    }
                    else if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        nodoPrevio.Siguiente = nodoActual.Siguiente;
                        Tipo objetoConDatos = nodoActual.ObjetoConDatos;

                        return (objetoConDatos);
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontro el objeto para eliminar");
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
                nodoActual = Top;
                nodoPrevio = Top;

                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                Top = null;
            }
        }


        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacia");
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = Top;

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
                throw new Exception("No se encontro el objeto buscado");
            }
        }

        ~PilaDinamicaDesordenada()
        {
            try
            {
                Vaciar();
            }
            catch (Exception e)
            {

            }
        }
    }
}
