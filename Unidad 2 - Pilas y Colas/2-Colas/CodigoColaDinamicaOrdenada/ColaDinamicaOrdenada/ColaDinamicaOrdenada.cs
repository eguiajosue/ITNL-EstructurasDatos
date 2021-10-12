using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaDinamicaOrdenada
{
    class ColaDinamicaOrdenada<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private Nodo<Tipo> _frente;
        public Nodo<Tipo> Frente
        {
            get { return _frente; }
            set { _frente = value; }
        }

        private Nodo<Tipo> _final;
        public Nodo<Tipo> Final
        {
            get { return _final; }
            set { _final = value; }
        }

        public ColaDinamicaOrdenada()
        {
            Frente = null;
            Final = null;
        }

        public bool Vacia
        {
            get 
            {
                if (Frente == null && Final == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>() ;
                nodoActual = Frente;

                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);

                yield break;
            }
        }

        public void AgregarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nuevoNodo.Siguiente = null;
                Frente = nuevoNodo;
                Final = nuevoNodo;
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = Frente;
                nodoPrevio = Frente;

                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("No se permiten objetos duplicados");
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) < 0)
                    {
                        if (nodoActual == Frente)
                        {
                            Nodo<Tipo> nuevo = new Nodo<Tipo>();
                            nuevo.ObjetoConDatos = objeto;
                            nuevo.Siguiente = Frente;
                            Frente = nuevo;
                            return;
                        }
                        else
                        {
                            Nodo<Tipo> nuevo = new Nodo<Tipo>();
                            nuevo.ObjetoConDatos = objeto;
                            nodoPrevio.Siguiente = nuevo;
                            nuevo.Siguiente = nodoActual;
                            return;
                        }
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);

                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nodoPrevio.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = null;
                Final = nuevoNodo;
            }
        }

        public Tipo EliminarNodo()
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacia");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoEliminado = new Nodo<Tipo>();
                nodoActual = Frente;

                Frente = nodoActual.Siguiente;
                nodoEliminado = nodoActual;
                nodoActual = null;

                return nodoEliminado.ObjetoConDatos;
            }
        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista se encuentra actualmente vacia");
            }
            else
            {
                Nodo<Tipo> nodoActual, nodoPrevio = new Nodo<Tipo>();
                nodoActual = Frente;
                nodoPrevio = Frente;

                if (Frente.ObjetoConDatos.Equals(objeto) && Final.ObjetoConDatos.Equals(objeto))
                {
                    Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                    Frente = null;
                    Final = null;
                    return objetoConDatos;
                }

                do
                {
                    if (Frente.ObjetoConDatos.Equals(objeto))
                    {
                        Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                        Frente = Frente.Siguiente;
                        return objetoConDatos;
                    }


                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        throw new Exception("El nodo no existe");
                    }
                    else
                    {
                        if (objeto.Equals(nodoActual.ObjetoConDatos))
                        {
                            Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            return objetoConDatos;
                        }
                        else
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.Siguiente;
                        }

                    }

                } while (nodoActual != null);
                throw new Exception("No se encontro el elemento a eliminar");
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
                nodoActual = Frente;

                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    nodoActual = nodoActual.Siguiente;

                } while (nodoActual != null);
                throw new Exception("El elemento buscado no existe");
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
                nodoActual = Frente;
                nodoPrevio = Frente;

                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                Frente = null;
                Final = null;
            }
        }

        ~ColaDinamicaOrdenada()
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
