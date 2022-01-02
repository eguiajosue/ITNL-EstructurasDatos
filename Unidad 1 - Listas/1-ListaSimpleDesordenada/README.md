# Lista Simple (Desordenada)

![ListaSimple](https://en.wikipedia.org/wiki/Linked_list#/media/File:Singly-linked-list.svg)

## Datos de la clase _ListaSimpleDesordenada_

|     Tipo      |    Accesamiento     |    Tipo     |         Nombre         | Valor                                       | Parámetros |
| :-----------: | :-----------------: | :---------: | :--------------------: | ------------------------------------------- | :--------: |
|  `Propiedad`  | Lectura y Escritura |   Objeto    |      NodoInicial       | retorna \_nodoInicial \_nodoInicial = valor |   **X**    |
|  `Propiedad`  |       Lectura       |  Booleano   |         Vacia          | retorna NodoInicial = Nulo                  |   **X**    |
| `Constructor` |       Público       |    **X**    | ListaSimpleDesordenada | **X**                                       |   **X**    |
|  `Iterador`   |       Público       | IEnumerator |     GetEnumerator      | **X**                                       |   **X**    |
|   `Método`    |       Público       |    Void     |      AgregarNodo       | **X**                                       |   Objeto   |
|   `Método`    |       Público       |   Objeto    |       BuscarNodo       | **X**                                       |   Objeto   |
|   `Método`    |       Público       |   Objeto    |      EliminarNodo      | **X**                                       |   Objeto   |
|   `Método`    |       Público       |    Void     |      VaciarLista       | **X**                                       |   **X**    |
| `Destructor`  |        **X**        |    **X**    | ListaSimpleDesordenada | Vaciar()                                    |   **X**    |

## Datos de la clase _Nodo_

|     Tipo     |    Accesamiento     |  Tipo  |     Nombre     | Valor                                             | Parámetros |
| :----------: | :-----------------: | :----: | :------------: | ------------------------------------------------- | :--------: |
| `Propiedad`  | Lectura y Escritura | Objeto | ObjetoConDatos | retorna \_objetoConDatos \_objetoConDatos = valor |   **X**    |
| `Propiedad`  | Lectura y Escritura | Objeto |   Siguiente    | retorna \_siguiente \_siguente = valor            |   **X**    |
| `Destructor` |        **X**        | **X**  |      Nodo      | \_objetoConDatos = default(Tipo)                  |   **X**    |

## Pseudocódigo

### AgregarNodo

```PSeint
INICIO

AgregarNodo(Tipo objeto)
    SI ( Vacia ← Nulo ) ENTONCES
        DEFINIR nuevoNodo COMO Nuevo Nodo
        nuevoNodo.ObjetoConDatos ← objeto
        nuevoNodo.Siguente ← nulo
        NodoInicial ← nodoNuevo
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        DEFINIR nodoPrevio COMO NUEVO Nodo

        HACER
            SI ( nodoActual.ObjetoConDatos ← objeto)
                RETORNAR Excepcion: "No se aceptan datos duplicados"
            SINO
                nodoPrevio ← nodoActual
                nodoActual ← nodoActual.Siguiente
        MIENTRAS nodoActual <> Nulo

        DEFINIR nuevoNodo COMO NUEVO Nodo
        nuevoNodo.ObjetoConDatos ← objeto
        nuevoNodo.Siguiente ← Nulo
        nodoPrevio.Siguiente ← nuevoNodo

FIN
```

### BuscarNodo

```PSeint
INICIO

BuscarNodo(Tipo objeto)
    SI ( Vacia ← Nulo ) ENTONCES
        RETORNAR Excepcion: "La lista actualmente está vacía"
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        nodoActual ← NodoInicial

        HACER
            Si ( nodoActual.ObjetoConDatos ← objeto)
                RETORNAR nodoActual.ObjetoConDatos
            SINO
                nodoActual ← nodoActual.Siguiente
        MIENTRAS nodoActual <> Nulo
        RETORNAR Excepcion: "No existe el elemento buscado"
FIN
```

### EliminarNodo

```PSeint
INICIO

EliminarNodo(Tipo objeto)
    SI ( Vacia ← Nulo ) ENTONCES
        RETORNAR Excepcion: "La lista actualmente está vacía"
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        DEFINIR nodoPrevio COMO NUEVO Nodo
        nodoActual ← NodoInicial
        nodoPrevio ← NodoInicial

        HACER
            Si ( NodoInicial.ObjetoConDatos ← objeto)
                objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
                NodoActual ← NodoInicial.Siguiente
                RETORNAR objetoConDatos
            SINO SI ( nodoActual.ObjetoConDatos ← objeto )
                nodoPrevio.Siguiente ← nodoActual.Siguiente
                objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
                nodoActual ← Nulo
                RETORNAR objetoConDatos
            SINO
                nodoPrevio ← nodoActual
                nodoActual ← nodoActual.Siguiente
        MIENTRAS nodoActual <> Nulo
        RETORNAR Excepcion: "No existe el elemento para eliminar"
FIN
```

### VaciarLista

```PSeint
INICIO

VaciarLista()
    SI (Vacia ← Verdadero) ENTONCES
        RETORNAR EXCEPCION "La lista está actualmente vacía"
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        DEFINIR nodoPrecio COMO NUEVO Nodo
        nodoActual ← NodoInicial
        nodoPrevio ← NodoInicial

        HACER
            nodoPrevio ← nodoActual
            nodoActual ← nodoActual.Siguiente
            nodoPrevio ← Nulo
        MIENTRAS nodoActual <> Nulo
        NodoInicial = Nulo

FIN
```
