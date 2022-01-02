# Lista Doble (Desordenada)

![ListaDoble](https://en.wikipedia.org/wiki/Linked_list#/media/File:Doubly-linked-list.svg)

## Datos de la clase _ListaDobleDesordenada_

|      Tipo               |     Accesamiento    |     Tipo    |         Nombre        | Parámetros |
|:-----------------------:|:-------------------:|:-----------:|:---------------------:|:----------:|
|  `Propiedad`            | Lectura y Escritura |    Objeto   |      NodoInicial      |    **X**   |
|  `Propiedad`            | Lectura y Escritura |    Objeto   |       NodoFinal       |    **X**   |
| `Constructor`           |       Público       |    **X**    | ListaDobleDesordenada |    **X**   |
|  `Propiedad`            |       Lectura       |    **X**    |         Vacía         |    **X**   |
|   `Propiedad Iterador`  |       Lectura       | IEnumerable |     HaciaAdelante     |    **X**   |
|   `Propiedad Iterador`  |       Lectura       | IEnumerable |       HaciaAtras      |    **X**   |
|    `Método`             |       Público       |     Void    |      AgregarNodo      |   Objeto   |
|    `Método`             |       Público       |    Objeto   |      EliminarNodo     |   Objeto   |
|    `Método`             |       Público       |    Objeto   |       BuscarNodo      |   Objeto   |
|    `Método`             |       Público       |     Void    |      VaciarLista      |    **X**   |
|  `Destructor`           |        **X**        |    **X**    | ListaDobleDesordenada |    **X**   |

## Datos de la clase _Nodo_

|     Tipo     |    Accesamiento     |  Tipo  |     Nombre     | Valor                                             | Parámetros |
| :----------: | :-----------------: | :----: | :------------: | ------------------------------------------------- | :--------: |
| `Propiedad`  | Lectura y Escritura | Objeto | ObjetoConDatos | retorna \_objetoConDatos \_objetoConDatos = valor |   **X**    |
| `Propiedad`  | Lectura y Escritura | Objeto |   Siguiente    | retorna \_anterior \_anterior  = valor            |   **X**    |
| `Propiedad`  | Lectura y Escritura | Objeto |    Anterior    | retorna \_anterior \_anterior  = valor            |   **X**    |
| `Destructor` |        **X**        | **X**  |      Nodo      | \_objetoConDatos = default(Tipo)                  |   **X**    |

## Pseudocódigo

### AgregarNodo

```PSeint
INICIO

AgregarNodo(Tipo objeto)
    SI ( Vacia ← Nulo ) ENTONCES
        DEFINIR nuevoNodo COMO Nuevo Nodo
        nuevoNodo.ObjetoConDatos ← objeto
        nuevoNodo.Anterior ← nulo
        nuevoNodo.Siguente ← nulo
        NodoInicial ← nodoNuevo
        NodoFinal ← nodoNuevo
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        nodoActual ← NodoFinal

        HACER
            SI ( objeto ← nodoActual.ObjetoConDatos)
                RETORNAR Excepcion: "No se aceptan datos duplicados"
            SINO
                nodoActual ← nodoActual.Anterior
        MIENTRAS nodoActual <> Nulo

        DEFINIR nuevoNodo COMO NUEVO Nodo
        nuevoNodo.ObjetoConDatos ← objeto
        nuevoNodo.Siguiente ← Nulo
        nodoPrevio.Anterior ← NodoFinal
        NodoFinal.Siguiente ← nuevoNodo
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
        nodoActual ← NodoFinal

        HACER
            Si ( objeto ← nodoActual.ObjetoConDatos )
                RETORNAR nodoActual.ObjetoConDatos
            SINO
                nodoActual ← nodoActual.Anterior
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
        nodoActual ← NodoFinal
        nodoPrevio ← NodoFinal

        SI (NodoInicial.ObjetoConDatos ← objeto Y NodoFinal.ObjetoConDatos ← objeto ENTONCES
            objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
            NodoInicial = Nulo
            NodoFinal = Nulo
            RETORNAR objetoConDatos 
        SINO
            SI (NodoInicial.ObjetoConDatos ← objeto) ENTONCES
                objetoConDatos:Tipo = nodoActual.ObjetoConDatos
                NodoInicial ← NodoInicial.Siguiente
                NodoInicial.Siguiente ← Nulo
                RETORNAR objetoConDatos
            SINO
                SI (NodoFinal.ObjetoConDatos ← objeto) ENTONCES
                    objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
                    NodoFinal ← NodoFinal.Anterior
                    NodoFinal.Siguiente ← Nulo
                    RETORNAR objetoConDatos
                SINO
                    nodoPrevio ← nodoActual
                    nodoActual ← nodoActual.Anterior
                
                HACER
                    SI (nodoActual.ObjetoConDatos ← objeto) ENTONCES
                        objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
                        nodoActual.Anterior.Siguiente ← nodoPrevio
                        nodoPrevio.Anterior ← nodoActual
                    SINO
                        nodoPrevio ← nodoActual
                        nodoActual ← nodoActual.Anterior
                MIENTRAS nodoActual <> Nulo
            RETORNAR Excepcion "No se encontró el elemento a eliminar"
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
        nodoActual ← NodoFinal
        nodoPrevio ← NodoFinal

        HACER
            nodoPrevio ← nodoActual
            nodoActual ← nodoActual.Anterior
            nodoPrevio ← Nulo
        MIENTRAS nodoActual <> Nulo
        NodoInicial = Nulo

FIN
```
