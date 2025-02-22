using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class List
    {
        private Node head; // Primer elemento de la lista
        private Node tail; // Ultimo elemento de la lista
        private int length; // Tamaño de la lista
        private bool isCircular; // Variable que guarda si la lista es circular
        
        // Constructor de la lista
        public List(bool isCircular)
        {
            head = tail = null;
            length = 0;
            this.isCircular = isCircular;
        }
        
        // Metodo que imprime la lista
        public void Print()
        {
            if(IsEmpty())
            {
                Console.WriteLine("La lista esta vacia");
                Thread.Sleep(500);
                return;
            }
            
            Node current = head;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine("\n");
            Thread.Sleep(500);
        }
        
        // Metodo que imprime la lista al reves
        public void PrintBackwards()
        {
            if(IsEmpty())
            {
                Console.WriteLine("La lista esta vacia");
                Thread.Sleep(500);
                return;
            }
            
            Node current = tail;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(current.data);
                current = current.prev;
            }
            Console.WriteLine("\n");
            Thread.Sleep(500);
        }
        
        // Metodo que agrega un dato al final
        public void Append(object data)
        {
            if(IsEmpty()) { head = tail = new Node(data); }
            
            else if(isCircular) { tail = tail.next = new Node(data, head, tail); }
            
            else { tail = tail.next = new Node(data, null, tail); }
            length++;
        }
        
        // Metodo que agrega un elemento al principio
        public void Prepend(object data)
        {
            if(IsEmpty()) { head = tail = new Node(data); }
            
            else if(isCircular) { head = head.prev = new Node(data, head, tail); }
            
            else { head = head.prev = new Node(data, head, null); }
            length++;
        }
        
        // Metodo que agrega un elemento a una posicon especifica de la lista
        public void Insert(object data, int index)
        {
            if(IsEmpty() | index == 1 ) 
            {
                Prepend(data); 
                return;
            }
            
            if(index == length) 
            {
                Append(data); 
                return;
            }
            
            if(index > length) 
            { 
                Console.WriteLine("\nEl indice al que quiere insertar un dato es mayor al tamaño de la lista"); 
                Console.WriteLine("El tamaño actual de la lista es: " + length);
                return;
            }
            
            Node current = head;
            for(int i = 1; i < index; i++)
            {
                // Iteramos hasta la posicion ingresada por el usuario
                current = current.next; 
            }
            
            // Agregamos un nodo en la posicion previa que pasara a ser la posicion deseada
            current.prev = new Node(data, current, current.prev);
            
            // Conectamos el nuevo nodo con el principio de la lista
            current.prev.prev.next = current.prev;
            
            length++;
        }
        
        // Metodo que elimina un elemento al final de la lista
        public void DeleteLast()
        {
            if(IsEmpty()) 
            {  
                Console.WriteLine("La lista esta vacia no se puede eliminar ningun elemento");
                return;
            }
            
            if(length == 1)
            {
                head = tail = null;
                Console.WriteLine("La lista se ha vaciado");
            }
            
            else if(isCircular)
            { 
                tail.prev.next = head;
                tail = tail.prev;
            }
            
            else
            {
                tail.prev.next = null;
                tail = tail.prev;
            }
            
            length--;
        }
        
        // Metodo que elimina el primer elemento de la lista
        public void DeleteFirst()
        {
            if(IsEmpty()) 
            {  
                Console.WriteLine("La lista esta vacia no se puede eliminar ningun elemento");
                return;
            }
            
            if(length == 1)
            {
                head = tail = null;
                Console.WriteLine("La lista se ha vaciado");
            }
            
            else if(isCircular)
            { 
                head.next.prev = tail;
                head = head.next;
            }
            
            else
            {
                head.next.prev = null;
                head = head.next;
            }
            
            length--;
        }
        
        // Metodo que elimina una posicion especifica de la lista
        public void DeleteIndex(int index)
        {
            if(IsEmpty() | index == 1 ) 
            {
                DeleteFirst(); 
                return;
            }
            
            if(index == length) 
            {
                DeleteLast(); 
                return;
            }
            
            if(index > length) 
            { 
                Console.WriteLine("\nEl indice al que quiere eliminar un dato es mayor al tamaño de la lista"); 
                Console.WriteLine("El tamaño actual de la lista es: " + length);
                return;
            }
            
            if(head == tail)
            {
                head = tail = null;
                Console.WriteLine("La lista se ha vaciado");
            }
            
            Node current = head;
            for(int i = 1; i < index; i++)
            {
                // Iteramos hasta la posicion ingresada por el usuario
                current = current.next; 
            }
            
            // El nodo anterior a la posicion ingresada se saltara a la posicion siguiente
            current.prev.next = current.next;
            
            // Conecta la posicion siguiente a la ingresada con la posicion anterior a la ingresada
            current = current.next;
            
            length--;
        }
        
        // Metodo que checa si la lista esta vacia
        private bool IsEmpty() { return length == 0; }
    }
}
