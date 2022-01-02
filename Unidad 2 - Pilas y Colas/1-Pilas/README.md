# Pila Dinámica (Desordenada)

![Pila](https://link)

## Datos de la clase _Pila_

|      Tipo     |     Accesamiento    |     Tipo    |          Nombre         | Parámetros |
|:-------------:|:-------------------:|:-----------:|:-----------------------:|:----------:|
|  `Propiedad`  | Escritura y Lectura |    Objeto   |           Top           |    **X**   |
|  `Propiedad`  |       Lectura       |   Booleano  |          Vacia          |    **X**   |
| `Constructor` |       Público       |    **X**    | PilaDinamicaDesordenada |    **X**   |
|   `Iterador`  |       Público       | IEnumerator |      GetEnumerator      |    **X**   |
|    `Método`   |       Público       |     Void    |           Push          |   Objeto   |
|    `Método`   |       Público       |    Objeto   |           Pop           |    **X**   |
|    `Método`   |       Público       |    Objeto   |           Pop           |   Objeto   |
|    `Método`   |       Público       |     Void    |        VaciarPila       |    **X**   |
|    `Método`   |       Público       |    Objeto   |        BuscarNodo       |   Objeto   |
|  `Destructor` |        **X**        |    **X**    | PilaDinamicaDesordenada |    **X**   |

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

Push(Tipo objeto)
    SI (Vaica ← Verdadero) ENTONCES
        DEFINIR nuevoNodo ← COMO NUEVO Nodo
        nuevoNodo.ObjetoConDatos ← objeto
        nuevoNodo.Siguiente ← Nulo
        Top ← nuevoNodo
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        DEFINIR nodoPrevio COMO NUEVO Nodo
        nodoActual ← nuevoNodo

        HACER
            SI (nodoActual.ObjetoConDaros ← objeto) ENTONCES
                RETORNAR Excepcion "No se permiten datos duplicados"
            SINO
                nodoPrecio ← nodoActual
                nodoActual ← nodoActual.Siguiente
        MIENTRAS nodoActual <> Nulo
        
        DEFINIR nuevoNodo ← COMO NUEVO Nodo
        nuevoNodo.ObjetoConDatos ← objeto
        nuevoNodo.Siguiente ← Top
        Top ← nuevoNodo

FIN
```

### Pop (Sin parámetros)

```PSeint
INICIO

Pop()
    SI (Vacia ← Verdadero) ENTONCES
        RETORNAR Excepcion "La pila está vacía"
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        DEFINIR nodoEliminado COMO NUEVO Nodo
        nodoActual ← Top

        Top ← nodoActual.Siguiente
        nodoEliminado ← nodoActual
        nodoActual ← Nulo

        RETORNAR nodoEliminado.ObjetoConDatos
    
FIN
```

### Pop (Con parámetros)

```PSeint
INICIO

Pop(Objeto)
    SI (Vacia ← Verdadero) ENTONCES
        RETORNAR Excepcion "La pila está vacía"
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        DEFINIR nodoEliminado COMO NUEVO Nodo
        nodoActual ← Top
        
        HACER
            SI (Top.ObjetoConDatos ← objeto) ENTONCES
                objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
                Tipo ← Top.Siguiente
                RETORNAR objetoConDatos
            SINO
                SI (nodoActual.ObjetoConDatos ← objeto) ENTONCES
                    nodoPrevio.Siguiente ← nodoActual.Siguiente
                    objetoConDatos:Tipo ← nodoActual.ObjetoConDatos
                    RETORNAR objetoConDatos
                SINO
                    nodoPrevio ← nodoActual
                    nodoActual ← nodoActual.Siguiente
        MIENTRAS nodoActual <> Nulo
        RETORNAR Excepcion "No se encontró el dato"

FIN
```

### BuscarNodo

```PSeint
    
INICIO

BuscarNodo(Tipo objeto)
SI (Vacia ← Verdadero) ENTONCES
        RETORNAR Excepcion "La pila está vacía"
    SINO
        DEFINIR nodoActual COMO NUEVO Nodo
        nodoActual ← Top

        HACER
            SI (nodoActual.ObjetoConDatos ← objeto) ENTONCES
                RETORNAR nodoActual.ObjetoConDatos
            SINO
                nodoActual ← nodoActual.Siguiente
        MIENTRAS nodoActual <> Nulo
        RETORNAR Excepcion "No se encontró el dato"
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
        DEFINIR nodoPrevio COMO NUEVO Nodo
        nodoActual ← Top
        nodoPrevio ← Top

        HACER
            nodoPrevio ← nodoActual
            nodoActual ← nodoActual.Siguiente
            nodoPrevio ← Nulo
        MIENTRAS nodoActual <> Nulo
        NodoInicial = Nulo
        Top ← Nulo
FIN
```
