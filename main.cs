using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List;

class Program 
{
    // Método que pregunta al usuario si desea realizar otra operación
    static bool Exit()
    {
        int opt;
        do
        {
            Console.WriteLine("¿Desea realizar otra operacion?\n1.Si 2.No\n");
            opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1){
                return true; // Si elige 1, el programa continúa
            }
            else if (opt == 2){
                return false; // Si elige 2, el programa termina
            }
            else 
                Console.WriteLine("Introduzca una opción correcta"); // Mensaje de error en caso de opción inválida
        } while (opt != 1 && opt != 2);
        return true;
    }
    
    // Método que ejecuta las operaciones en la lista según la opción elegida por el usuario
    static void Operations(list lista, int opt)
    {
        string data;
        switch(opt)
        {
            case 1: 
                Console.WriteLine("Introduzca el texto que desea meter al final de la lista\n");
                data = Console.ReadLine();
                lista.Append(data); // Agrega un elemento al final de la lista
                break;
            case 2: 
                Console.WriteLine("Introduzca el texto que desea meter al principio de la lista\n");
                data = Console.ReadLine();
                lista.Prepend(data); // Agrega un elemento al inicio de la lista
                break;
            case 3: 
                lista.DeleteLast(); // Elimina el último elemento de la lista
                break;
            case 4: 
                lista.DeleteFirst(); // Elimina el primer elemento de la lista
                break;
            case 5: 
                lista.Print(); // Imprime los elementos de la lista en orden
                break;
            case 6: 
                lista.PrintBackwards(); // Imprime los elementos de la lista en orden inverso
                break;
            case 7: // Inserta un elemento a un punto dado de la lista
                Console.WriteLine("Introduzca el texto que desea meter al final de la lista\n");
                data = Console.ReadLine();
                Console.WriteLine("¿En que posicion lo quiere colocar?\n");
                int index = Convert.ToInt32(Console.ReadLine());
                lista.Insert(data, index);
                break;
            default: 
                Console.WriteLine("Elija una opcion entre 1 y 7"); // Mensaje de error en caso de opción inválida
                break;
        }
    }
    
	static void Main() 
	{
		int opt = 0;

        // Pregunta al usuario si desea crear una lista
		Console.WriteLine("¿Desea crear una lista?\n");
        Console.WriteLine("1. Si 2. No\n");
        int makeList = Convert.ToInt32(Console.ReadLine());
        if(makeList == 2) {return;} // Saca al usuario del programa

        // Pregunta al usuario si la lista será circular
        Console.WriteLine("¿Desea que sea circular?\n");
        Console.WriteLine("1. Si 2. No\n");
        int isCircular = Convert.ToInt32(Console.ReadLine());

        // Pide el nombre de la lista
        Console.WriteLine("Introduzca el nombre de la lista\n");
        string listName = Console.ReadLine();

        // Define si la lista será circular o no según la opción elegida
        bool Circular;
        if(makeList == 1 && isCircular == 1)
        {
            Circular = true;
        }
        else if(makeList == 1 && isCircular == 2)
        {
            Circular = false;
        }
        else 
        {
            return; // Si el usuario no quiere crear una lista, el programa termina
        }

        // Crea la lista con el nombre y tipo (circular o no) definido por el usuario
        list lista = new list(listName, Circular);
        
        // Bucle que permite al usuario elegir operaciones sobre la lista hasta que decida salir
        do
        {
            Console.WriteLine("¿Que operacion desea hacer?\n");
            Console.WriteLine("1. Agregar un elemento al final\n");
            Console.WriteLine("2. Agregar un elemento al principio\n");
            Console.WriteLine("3. Eliminar un elemento al final\n");
            Console.WriteLine("4. Eliminar un elemento al principio\n");
            Console.WriteLine("5. Imprimir elementos\n");
            Console.WriteLine("6. Imprimir elementos al revés\n");
            Console.WriteLine("7. Insertar un elemento");
            
            opt = Convert.ToInt32(Console.ReadLine());
            Operations(lista, opt); // Ejecuta la operación seleccionada
        } while (Exit() && (opt > 0 && opt < 8)); // Repite mientras el usuario quiera continuar y la opción sea válida
	}
}
