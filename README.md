# Implementación de Lista Doblemente Enlazada en C#

## Descripción
Este proyecto implementa una estructura de datos de **lista doblemente enlazada** en C#, con la posibilidad de ser **circular o no**. La lista permite operaciones como agregar, eliminar e imprimir elementos en orden normal e inverso.

### Estructura del Proyecto
- **`node.cs`**: Define la clase `node`, que representa un nodo en la lista doblemente enlazada.
- **`list.cs`**: Implementa la clase `list`, que maneja la estructura de la lista y sus operaciones.
- **`Program.cs`**: Contiene la lógica de interacción con el usuario, permitiendo la creación y manipulación de la lista.

## Implementación
### `node.cs`
Cada nodo tiene:
- Un **valor** (`data`)
- Un **puntero al nodo anterior** (`prev`)
- Un **puntero al nodo siguiente** (`next`)

### `list.cs`
La clase `list` maneja la estructura de la lista e implementa los siguientes métodos:
- **`Append(string data)`**: Agrega un nodo al final de la lista.
- **`Prepend(string data)`**: Agrega un nodo al inicio de la lista.
- **`DeleteLast()`**: Elimina el último nodo de la lista.
- **`DeleteFirst()`**: Elimina el primer nodo de la lista.
- **`Print()`**: Imprime los elementos de la lista en orden normal.
- **`PrintBackwards()`**: Imprime los elementos de la lista en orden inverso.
- **`IsEmpty()`**: Verifica si la lista está vacía.
- **`Insert()`**: Inserta un nodo en un punto especifico de la lista.

La lista puede ser **circular** o **no circular**, dependiendo de la opción elegida al momento de su creación.

### `Program.cs`
Este archivo proporciona una interfaz de consola para interactuar con la lista. Permite al usuario:
1. Crear una lista (circular o no).
2. Agregar elementos al inicio o al final.
3. Eliminar elementos del inicio o del final.
4. Imprimir la lista en orden normal o inverso.

## Ejemplo de Uso
Al ejecutar el programa, se mostrará el siguiente flujo:

```plaintext
¿Desea crear una lista?
1. Si 2. No
> 1
¿Desea que sea circular?
1. Si 2. No
> 2
Introduzca el nombre de la lista
> ListaEjemplo

¿Que operacion desea hacer?
1. Agregar un elemento al final
2. Agregar un elemento al principio
3. Eliminar un elemento al final
4. Eliminar un elemento al principio
5. Imprimir elementos
6. Imprimir elementos al revés
> 1
Introduzca el texto que desea meter al final de la lista
> Hola

¿Desea realizar otra operación?
1. Si 2. No
> 1
> 5

ListaEjemplo
Hola
```
