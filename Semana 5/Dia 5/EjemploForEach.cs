using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploQuitarDeLista
{
    //Usando listas, agregar N n�meros a una lista
    //y preguntar si se quiere quitar un n�mero.
    //Si es as�, quitarlo de la lista y volver a
    //preguntar.Una vez que ya no se quiera
    //quitar n�meros, mostrar la lista.
    //Si el n�mero no se encuentra, mostrar mensaje:
    //"No se encontr� n�mero".
    class Program
    {
        static void Main(string[] args)
        {
            List<int> miLista = new List<int>();
            Console.WriteLine("Cu�ntos elementos?");
            int numeroElementos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar los numeros uno a uno");
            for (int i = 0; i < numeroElementos; i++)
            {
                Console.WriteLine("Ingresar numero: {0}",i+1);
                miLista.Add(int.Parse(Console.ReadLine()));
            }
            do
            {
                Console.WriteLine("Quitar numero? S para S� - N para No");
                char rpta = char.Parse(Console.ReadLine());
                if (rpta == 's')
                {
                    Console.WriteLine("Qu� numero quitar?");
                    int numeroAQuitar = int.Parse(Console.ReadLine());
                    if (miLista.Contains(numeroAQuitar) == true)
                    {
                        miLista.Remove(numeroAQuitar);
                        Console.WriteLine("Se quit�");
                    }
                    else
                        Console.WriteLine("El n�mero no est�");
                }
                else if (rpta == 'n')
                {
                    foreach (var item in miLista)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    break;
                }

            } while (true);

            // UTILIZACI�N DEL M�TODO FOREACH DE UNA LISTA
            List<Ejemplo> listaEjemplos = new List<Ejemplo>();
            Ejemplo ej1 = new Ejemplo(123);
            Ejemplo ej2 = new Ejemplo(445);
            Ejemplo ej3 = new Ejemplo(0);

            listaEjemplos.Add(ej1);
            listaEjemplos.Add(ej2);
            listaEjemplos.Add(ej3);
            // SE LE ENV�A UNA FUNCI�N AL M�TODO FOR EACH
            listaEjemplos.ForEach(Imprimir);
        }
        //IMPLEMENTACI�N DE LA FUNCI�N Imprimir
        public static void Imprimir(Ejemplo ej)
        {
            Console.WriteLine();
            Console.Write(ej.getA().ToString());
        }
    }
    class Ejemplo
    {
        int a;
        public Ejemplo(int a)
        {
            this.a = a;
        }
        public int getA()
        {
            return a;
        }
    }
}
