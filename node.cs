using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List 
{
	class node
	{
	    // Atributo que almacena el dato del nodo
	    public string data; 
	    
	    // Referencia al nodo anterior en la lista doblemente enlazada
	    public node prev; 
	    
	    // Referencia al nodo siguiente en la lista doblemente enlazada
	    public node next; 
	    
	    // Constructor que inicializa el nodo con un dato y referencias a nodos previos y siguientes
	    public node(string data, node prev, node next)
	    {
	        this.data = data;
	        this.prev = prev;
	        this.next = next;
	    }
	    
	    // Constructor que inicializa el nodo solo con el dato, dejando las referencias en null
	    public node(string data)
	    {
	        this.data = data;
	        this.prev = null;
	        this.next = null;
	    }
	    
	    // Constructor por defecto que inicializa el nodo con un dato vacío y referencias en null
	    public node()
	    {
	        this.data = " ";
	        this.prev = null;
	        this.next = null;
	    }
	}
}