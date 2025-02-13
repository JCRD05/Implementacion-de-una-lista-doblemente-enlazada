# Implementación de Lista Doblemente Enlazada en C#

Este proyecto implementa una **lista doblemente enlazada** en C#, con soporte para listas **circulares y no circulares**. Permite realizar operaciones como agregar elementos al inicio o final, eliminar elementos y recorrer la lista en ambas direcciones.

## Contenido del Proyecto
El código se divide en tres archivos principales:

1. **`node.cs`**: Define la estructura de un nodo de la lista.
2. **`list.cs`**: Implementa la lista doblemente enlazada con las operaciones básicas.
3. **`Program.cs`**: Contiene la interfaz de consola para interactuar con la lista.

## Implementación

### `node.cs`
```csharp
namespace List
{
	class node
	{
	    public string data;
	    public node prev;
	    public node next;
	    
	    public node(string data, node prev, node next)
	    {
	        this.data = data;
	        this.prev = prev;
	        this.next = next;
	    }
	    
	    public node(string data)
	    {
	        this.data = data;
	        this.prev = null;
	        this.next = null;
	    }
	    
	    public node()
	    {
	        this.data = " ";
	        this.prev = null;
	        this.next = null;
	    }
	}
}
```

### `list.cs`
```csharp
using System;
using List;

namespace List
{
    class list
    {
        private node head;
        private node tail;
        private int length;
        private string name;
        private bool IsCircular;
        
        public list(string name, bool IsCircular)
        {
            this.name = name;
            head = tail = null;
            length = 0;
            this.IsCircular = IsCircular;
        }
        
        public bool IsEmpty()
        {
            return head == null;
        }
        
        public void Print()
        {
            if(IsEmpty())
                Console.WriteLine("La lista no tiene elementos que imprimir");
            else
            {
                node current = head;
                Console.WriteLine("\n" + name + "\n");
                do
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                } while (current != head && IsCircular);
            }
        }
        
        public void Append(string data)
        {
            if(IsEmpty())
                head = tail = new node(data);
            else
            {
                tail.next = new node(data, tail, IsCircular ? head : null);
                tail = tail.next;
                if (IsCircular) head.prev = tail;
            }
            length++;
        }
    }
}
```

### `Program.cs`
```csharp
using System;
using List;

class Program
{
    static void Main()
    {
        Console.WriteLine("¿Desea crear una lista? (1. Si / 2. No)");
        int makeList = Convert.ToInt32(Console.ReadLine());
        if (makeList != 1) return;
        
        Console.WriteLine("¿Desea que sea circular? (1. Si / 2. No)");
        bool isCircular = Convert.ToInt32(Console.ReadLine()) == 1;
        
        Console.WriteLine("Introduzca el nombre de la lista:");
        string listName = Console.ReadLine();
        
        list lista = new list(listName, isCircular);
        
        Console.WriteLine("Agregue un elemento al final:");
        string data = Console.ReadLine();
        lista.Append(data);
        
        Console.WriteLine("Contenido de la lista:");
        lista.Print();
    }
}
```

## Ejemplo de Uso
### Crear una Lista Circular y Agregar un Elemento
```
¿Desea crear una lista? (1. Si / 2. No)
> 1
¿Desea que sea circular? (1. Si / 2. No)
> 1
Introduzca el nombre de la lista:
> MiLista
Agregue un elemento al final:
> Hola
Contenido de la lista:
MiLista
Hola
```

Este código proporciona una **estructura básica de lista doblemente enlazada**, con soporte para listas circulares y una interfaz de consola para su manipulación.

