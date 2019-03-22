using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploQuitarDeLista
{
    //Usando listas, agregar N números a una lista
    //y preguntar si se quiere quitar un número.
    //Si es así, quitarlo de la lista y volver a
    //preguntar.Una vez que ya no se quiera
    //quitar números, mostrar la lista.
    //Si el número no se encuentra, mostrar mensaje:
    //"No se encontró número".
    class Program
    {
        static void Main(string[] args)
        {
            List<int> miLista = new List<int>();
            Console.WriteLine("Cuántos elementos?");
            int numeroElementos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar los numeros uno a uno");
            for (int i = 0; i < numeroElementos; i++)
            {
                Console.WriteLine("Ingresar numero: {0}",i+1);
                miLista.Add(int.Parse(Console.ReadLine()));
            }
            do
            {
                Console.WriteLine("Quitar numero? S para Sí - N para No");
                char rpta = char.Parse(Console.ReadLine());
                if (rpta == 's')
                {
                    Console.WriteLine("Qué numero quitar?");
                    int numeroAQuitar = int.Parse(Console.ReadLine());
                    if (miLista.Contains(numeroAQuitar) == true)
                    {
                        miLista.Remove(numeroAQuitar);
                        Console.WriteLine("Se quitó");
                    }
                    else
                        Console.WriteLine("El número no está");
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

            // UTILIZACIÓN DEL MÉTODO FOREACH DE UNA LISTA
            List<Ejemplo> listaEjemplos = new List<Ejemplo>();
            Ejemplo ej1 = new Ejemplo(123);
            Ejemplo ej2 = new Ejemplo(445);
            Ejemplo ej3 = new Ejemplo(0);

            listaEjemplos.Add(ej1);
            listaEjemplos.Add(ej2);
            listaEjemplos.Add(ej3);
            // SE LE ENVÍA UNA FUNCIÓN AL MÉTODO FOR EACH
            listaEjemplos.ForEach(Imprimir);
        }
        //IMPLEMENTACIÓN DE LA FUNCIÓN Imprimir
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
