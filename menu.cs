using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace Program
{
    class Menu
    {
        List list; // Lista utilizada en el programa
        object data; // Dato que se almacena en la lista
        int index; // Posicion especifica a la que se agrega o se elimina un dato de la lista
        
        // Constructor del menu
        public Menu(){}
        
        // Metodo que muestra el menu
        public void Show()
        {
            Console.WriteLine("Lista Doblemente Enlazada Interactiva\n");
            this.list = new List(IsCircular());
            
            int option = 0;
            do
            {
                Operations(ref option);
                if(option == 9) { return; }
            }while(true);
        }
        
        // Metodo que deja al usuario decidir si la lista es circular 
        public bool IsCircular()
        {
            do
            {
                Console.WriteLine("¿Quiere que su lista sea circular?");
                Console.WriteLine("1. Si 2. No");
                short isCircular = Convert.ToInt16(Console.ReadLine());
                
                if(isCircular == 1){ return true; }
                else if(isCircular == 2){ return false;}
                else { Console.WriteLine("Introduzca una opcion valida\n"); }
            } while(true);
        }
        
        // Despliega en el menu las operaciones de la lista
        public void Operations(ref int option)
        {
            Thread.Sleep(500);
            Console.WriteLine("\n¿Que operacion desea realizar?\n");
            
            Console.Write("1. Insertar un elemento al final     ");
            Console.Write("2. Insertar un elemento al principio     ");
            Console.WriteLine("3. Insertar un elemento en cualquier posicion");
            Console.Write("4. Borrar un elemento al final       ");
            Console.Write("5. Borrar un elemento al principio       ");
            Console.WriteLine("6. Borrar un elemento en cualquier posicion");
            Console.Write("7. Imprimir la lista                 ");
            Console.Write("8. Imprimir la lista al reves            ");
            Console.Write("9. Salir Del Programa       \n");
            
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(option)
            {
                case 1: 
                    Console.Write("Introduzca el dato a agregar: ");
                    data = Console.ReadLine();
                    list.Append(data);
                    break;
                case 2: 
                    Console.Write("Introduzca el dato a agregar: ");
                    data = Console.ReadLine();
                    list.Prepend(data);
                    break;
                case 3: 
                    Console.Write("Introduzca el dato a agregar: ");
                    data = Console.ReadLine();
                    Console.Write("Introduzca la posicion a la que se agregara: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    list.Insert(data, index);
                    break;
                case 4: 
                    list.DeleteLast();
                    break;
                case 5: 
                    list.DeleteFirst();
                    break;
                case 6: 
                    Console.Write("Introduzca la posicion que se eliminara: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    list.DeleteIndex(index);
                    break;
                case 7:
                    list.Print();
                    break;
                case 8:
                    list.PrintBackwards();
                    break;
                case 9: 
                    Console.WriteLine("Gracias Por Usar El Programa!");
                    break;
                default: 
                    Console.WriteLine("Elija una opcion entre 1 y 9");
                    break;
            }
        }
    }
}