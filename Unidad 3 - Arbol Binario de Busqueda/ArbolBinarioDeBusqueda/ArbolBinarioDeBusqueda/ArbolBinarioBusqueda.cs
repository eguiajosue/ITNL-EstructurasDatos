using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda
{
    class ArbolBinarioBusqueda<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        private Nodo<Tipo> _raiz;
        public Nodo<Tipo> Raiz
        {
            get { return _raiz; }
            set { _raiz = value; }
        }

        public ArbolBinarioBusqueda()
        {
            Raiz = null;
        }

        public bool Vacia
        {
            get 
            {
                if (Raiz == null) 
                    return true;
                else 
                    return false;
            }
        }

        public void AgregarNodo(Tipo objeto)
        {
            // Alta Vacia
            if (Vacia)
            {
                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto;
                nuevoNodo.HijoIzq = null;
                nuevoNodo.HijoDer = null;
                Raiz = nuevoNodo;
            }
            else
            {
                Nodo<Tipo> nuevoNodo = new Nodo<Tipo>();
                nuevoNodo.ObjetoConDatos = objeto; // <== Se asigna el parametro enviado desde la forma al la propiedad ObjetoConDatos del nuevoNodo
                nuevoNodo.HijoIzq = null; // <== El valor de HijoIzq se asigna como "null" (Realizado desde el constructor de la clase Nodo)
                nuevoNodo.HijoDer = null; // <== El valor de HijoDer se asigna como "null" (Realizado desde el constructor de la clase Nodo)

                Nodo<Tipo> nodoPadre, nodoActual = new Nodo<Tipo>();
                /// nodoPadre y nodoActual son objetos que nos ayudaran a determinar la posicion del objeto
                nodoActual = Raiz;

                do
                {
                    nodoPadre = nodoActual; // <== Hacemos referencia de que el nodoPadre apunte a la Raiz a la que se agregara su nuevo hijo
                    // No permitir duplicados
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        throw new Exception("No se permiten objetos duplicados");
                    }
                    // Alta por la izquierda
                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        nodoActual = nodoActual.HijoIzq;
                    }
                    // Alta por la derecha
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
                    {
                        nodoActual = nodoActual.HijoDer;
                    }
                } while (nodoActual != null);
                
                if (objeto.CompareTo(nodoPadre.ObjetoConDatos) == -1)
                {
                    nodoPadre.HijoIzq = nuevoNodo;
                } else
                {
                    nodoPadre.HijoDer = nuevoNodo;
                }
            }
        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("El arbol se encuentra actualmente vacio");
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                Nodo<Tipo> nodoPadre = new Nodo<Tipo>();
                Tipo objetoConDatos = nodoActual.ObjetoConDatos;
                nodoActual = Raiz;
                nodoPadre = null;

                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        if (nodoActual.HijoDer == null)
                        {
                            if (nodoPadre == null)
                            {
                                Raiz = nodoActual.HijoIzq;
                            }

                            else if (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1)
                            {
                                nodoPadre.HijoIzq = nodoActual.HijoIzq;
                            }
                            else if (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1)
                            {
                                nodoPadre.HijoDer = nodoActual.HijoIzq;
                            }
                        }
                        else
                        {
                            if (nodoActual.HijoDer.HijoIzq == null)
                            {
                                nodoActual.HijoDer.HijoIzq = nodoActual.HijoIzq;
                                if (nodoPadre == null)
                                {
                                    Raiz = nodoActual.HijoDer;
                                }
                                else if (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1)
                                {
                                    nodoPadre.HijoIzq = nodoActual.HijoDer;
                                }
                                else if (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1)
                                {
                                    nodoPadre.HijoDer = nodoActual.HijoDer;
                                }
                            }
                            else
                            {
                                Nodo<Tipo> nodoMenor, nodoPadreMenor = new Nodo<Tipo>();
                                nodoMenor = nodoActual.HijoDer.HijoIzq;
                                nodoPadreMenor = nodoActual.HijoDer;

                                do
                                {
                                    nodoPadreMenor = nodoMenor;
                                    nodoMenor = nodoMenor.HijoIzq;

                                } while (nodoMenor.HijoIzq != null);

                                nodoPadreMenor.HijoIzq = nodoMenor.HijoDer;
                                nodoMenor.HijoIzq = nodoActual.HijoIzq;
                                nodoMenor.HijoDer = nodoActual.HijoDer;

                                if (nodoPadre == null)
                                {
                                    Raiz = nodoMenor;
                                }
                                else if (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1)
                                {
                                    nodoPadre.HijoDer = nodoMenor;
                                }
                                else if (nodoPadre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1)
                                {
                                    nodoPadre.HijoIzq = nodoMenor;
                                }
                            }
                        }
                        return objetoConDatos;
                    }
                    

                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoIzq;
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoDer;
                    }


                } while (nodoActual != null);
                throw new Exception("El nodo no se pudo encontrar");
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
                nodoActual = Raiz;

                do
                {
                    Nodo<Tipo> nodoPadre = new Nodo<Tipo>();

                    if (nodoActual.ObjetoConDatos.Equals(objeto))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoIzq;
                    }
                    else
                    {
                        nodoPadre = nodoActual;
                        nodoActual = nodoActual.HijoDer;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontro el objeto buscado");
            }
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                return;
            }
            else
            {
                this.RecorrerYBorrar(this.Raiz);
                this.Raiz = null;
                return;
            }
        }

        public void RecorrerYBorrar(Nodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                this.RecorrerYBorrar(nodoActual.HijoIzq);
                this.RecorrerYBorrar(nodoActual.HijoDer);
                this.EliminarNodo(nodoActual.ObjetoConDatos);
                return;
            }
            else
            {
                return;
            }
        }

        // Recorridos
        public IEnumerable<Tipo> RecorrerPreOrden()
        {
            return this.RecorrerPreOrden(this.Raiz);
        }

        public IEnumerable<Tipo> RecorrerInOrden()
        {
            return this.RecorrerInOrden(this.Raiz);
        }

        public IEnumerable<Tipo> RecorrerPostOrden()
        {
            return this.RecorrerPostOrden(this.Raiz);
        }

        // Metodos Recorrido Recursivos
        private IEnumerable<Tipo> RecorrerPreOrden(Nodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                yield return (nodoActual.ObjetoConDatos);

                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoIzq))
                    yield return miNodo;

                foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoDer))
                    yield return miNodo;
            }
        }

        private IEnumerable<Tipo> RecorrerInOrden(Nodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {

                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoIzq))
                    yield return miNodo;

                yield return nodoActual.ObjetoConDatos;

                foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoDer))
                    yield return miNodo;
            }
        }

        private IEnumerable<Tipo> RecorrerPostOrden(Nodo<Tipo> nodoActual)
        {
            if (nodoActual != null)
            {
                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoIzq))
                    yield return miNodo;

                foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoDer))
                    yield return miNodo;

                yield return nodoActual.ObjetoConDatos;
            }
        }

        public void CrearArchivoDot(ref string Resultado)
        {
            if (!Vacia)
            {
                Resultado = Resultado + "digraph Figura {";
                Resultado = Resultado + "\nRaíz->" + Raiz.ObjetoConDatos.ToString() + ";";
                RecorrerNodos(Raiz, ref Resultado);
                Resultado = Resultado + "\n}";
            }
        }

        private void RecorrerNodos(Nodo<Tipo> nodoActual, ref string Resultado)
        {
            if (nodoActual != null)
            {
                if (nodoActual.HijoIzq != null)
                    Resultado = Resultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" + nodoActual.HijoIzq.ObjetoConDatos.ToString() + ";";

                if (nodoActual.HijoDer != null)
                    Resultado = Resultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" + nodoActual.HijoDer.ObjetoConDatos.ToString() + ";";
                RecorrerNodos(nodoActual.HijoIzq, ref Resultado);
                RecorrerNodos(nodoActual.HijoDer, ref Resultado);
            }
        }
    
        ~ArbolBinarioBusqueda()
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
