using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List;

namespace List
{
    class list
    {
        // Nodo que representa la cabeza de la lista
        private node head; 
        
        // Nodo que representa la cola de la lista
        private node tail;
        
        // Longitud de la lista
        private int length;
        
        // Nombre de la lista
        private string name;
        
        // Indica si la lista es circular o no
        private bool IsCircular;
        
        // Constructor que inicializa la lista con un nombre y su tipo (circular o no)
        public list(string name, bool IsCircular)
        {
            this.name = name;
            head = tail = null;
            length = 0;
            this.IsCircular = IsCircular;
        }
        
        // Constructor que inicializa la lista sin nombre y define si es circular
        public list(bool IsCircular)
        {
            name = "lista sin nombre";
            head = tail = null;
            length = 0;
            this.IsCircular = IsCircular;
        }
        
        // Constructor que inicializa la lista con un nombre, un primer dato y su tipo (circular o no)
        public list(string name, string dato, bool IsCircular)
        {
            this.name = name;
            head = tail = new node(dato);
            length = 1;
            this.IsCircular = IsCircular;
        }
        
        // Método que verifica si la lista está vacía
        public bool IsEmpty()
        {
            return head == null;
        }
        
        // Método para imprimir los elementos de la lista en orden
        public void Print()
        {
            if(IsEmpty())
            {
                Console.WriteLine("La lista no tiene elementos que imprimir");
            }
            else if(IsCircular) // Si la lista es circular, recorre hasta la longitud establecida
            {
                int index = 0;
                node current = head;
                Console.WriteLine("\n" + name + "\n");
                do
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                    index++;
                }while(index != length);
            }
            else // Si la lista no es circular, recorre hasta que el nodo sea nulo
            {
                node current = head;
                Console.WriteLine("\n" + name + "\n");
                while(current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }
        
        // Método para imprimir los elementos de la lista en orden inverso
        public void PrintBackwards()
        {
            if(IsEmpty())
            {
                Console.WriteLine("La lista no tiene elementos que imprimir");
            }
            else if(IsCircular) // Si la lista es circular, recorre desde la cola hasta la cabeza
            {
                int index = 0;
                node current = tail;
                Console.WriteLine("\n" + name + "\n");
                do
                {
                    Console.WriteLine(current.data);
                    current = current.prev;
                    index++;
                }while(index != length);
            }
            else // Si la lista no es circular, recorre desde la cola hasta la cabeza
            {
                node current = tail;
                Console.WriteLine("\n" + name + "\n");
                while(current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.prev;
                }
            }
        }
        
        // Método para agregar un nodo al final de la lista
        public void Append(string data)
        {
            if(IsEmpty()) // Si la lista está vacía, el nuevo nodo es cabeza y cola
            {
                head = tail = new node(data);
            }
            else if(IsCircular) // Si la lista es circular, se enlaza el nuevo nodo al final y con la cabeza
            {
                head.prev = tail;
                tail = tail.next = new node(data, tail, head);
            }
            else // Si la lista no es circular, se enlaza el nuevo nodo al final
            {
                tail = tail.next = new node(data, tail, null);
            }
            length++;
        }
        
        // Método para agregar un nodo al inicio de la lista
        public void Prepend(string data)
        {
            if(IsEmpty()) // Si la lista está vacía, el nuevo nodo es cabeza y cola
            {
                head = tail = new node(data);
            }
            else if(IsCircular) // Si la lista es circular, el nuevo nodo se enlaza a la cabeza y a la cola
            {
                head.prev = tail;
                head = head.prev = new node(data, tail, head);
            }
            else // Si la lista no es circular, se enlaza el nuevo nodo al inicio
            {
                head = head.prev = new node(data, null, head);
            }
            length++;
        }
        
        // Método para eliminar el último nodo de la lista
        public void DeleteLast()
        {
            if(IsEmpty()) // Si la lista está vacía, no hay nada que eliminar
            {
                Console.WriteLine("La lista no tiene elementos que eliminar");
            }
            
            if(head == tail) // Si la lista tiene un solo elemento, se vacía completamente
            {
                head = tail = null;
            }
            else if(IsCircular) // Si la lista es circular, se actualiza la referencia de la cola
            {
                node current = tail.prev;
                current.next = head;
                tail = current;
            }
            else // Si la lista no es circular, se elimina el último nodo
            {
                node current = tail.prev;
                current.next = null;
                tail = current;
            }
            length--;
        }
        
        // Método para eliminar el primer nodo de la lista
        public void DeleteFirst()
        {
            if(IsEmpty()) // Si la lista está vacía, no hay nada que eliminar
            {
                Console.WriteLine("La lista no tiene elementos que eliminar");
            }
            
            if(head == tail) // Si la lista tiene un solo elemento, se vacía completamente
            {
                head = tail = null;
            }
            else if(IsCircular) // Si la lista es circular, se actualiza la referencia de la cabeza
            {
                node current = head.next;
                current.prev = tail;
                head = current;
                length--;
            }
            else // Si la lista no es circular, se elimina el primer nodo
            {
                node current = head.next;
                current.prev = null;
                head = current;
                length--;
            }
        }
    }
}