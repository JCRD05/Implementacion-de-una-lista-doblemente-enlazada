# Implementación de Lista Doblemente Enlazada en C#

## Descripción
Este proyecto implementa una estructura de datos de lista doblemente enlazada en C#, con la posibilidad de ser circular o no. La lista permite operaciones como agregar, eliminar e imprimir elementos en orden normal e inverso.

## Estructura del Proyecto
- **Node.cs**: Define la clase `Node`, que representa un nodo en la lista doblemente enlazada.
- **List.cs**: Implementa la clase `List`, que maneja la estructura de la lista y sus operaciones.
- **Menu.cs**: Contiene la interfaz de usuario que permite la interacción con la lista.
- **Program.cs**: Punto de entrada principal del programa, donde se inicia la ejecución.

## Implementación
### Node.cs
Cada nodo tiene:
- Un valor (`data`)
- Un puntero al nodo anterior (`prev`)
- Un puntero al nodo siguiente (`next`)

### List.cs
La clase `List` maneja la estructura de la lista e implementa los siguientes métodos:

- `Append(object data)`: Agrega un nodo al final de la lista.
- `Prepend(object data)`: Agrega un nodo al inicio de la lista.
- `Insert(object data, int index)`: Inserta un nodo en una posición específica de la lista.
- `DeleteLast()`: Elimina el último nodo de la lista.
- `DeleteFirst()`: Elimina el primer nodo de la lista.
- `DeleteIndex(int index)`: Elimina un nodo en una posición específica de la lista.
- `Print()`: Imprime los elementos de la lista en orden normal.
- `PrintBackwards()`: Imprime los elementos de la lista en orden inverso.
- `IsEmpty()`: Verifica si la lista está vacía.

La lista puede ser circular o no circular, dependiendo de la opción elegida al momento de su creación.

### Menu.cs
Este archivo proporciona una interfaz de consola para interactuar con la lista. Permite al usuario:

- Crear una lista (circular o no).
- Agregar elementos al inicio, final o en una posición específica.
- Eliminar elementos del inicio, final o en una posición específica.
- Imprimir la lista en orden normal o inverso.
