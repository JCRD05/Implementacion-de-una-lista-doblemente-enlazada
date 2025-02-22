using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node
    {
        public object data; // Dato que almacena el nodo
        public Node next; // Direccion de memoria del nodo siguiente
        public Node prev; // Direccion de memoria del nodo anterior
        
        public Node(object data, Node next, Node prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
        
        // Constructores de los nodos
        public Node(object data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
        
        public Node()
        {
            data = null;
            next = null;
            prev = null;
        }
    }
}
