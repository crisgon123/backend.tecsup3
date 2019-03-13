using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeClases
{
    class Program
    {
        
        static void Main()
        {
            Gato.variableEstatica++;
            Gato.mostrarVariables();
            Console.WriteLine();

        }
    }

    class Gato
    {
        public static int variableEstatica;
        public string nombre;
        float peso;
        float altura;
        string color;

        public static void mostrarVariables()
        {

        }
        
        /// Constructor sin parámetros de la clase Gato
        public Gato()
        {
            this.peso = 5;
            Console.WriteLine("Se creó un gato sin nombre.");
        }
        /// Constructor con parámetros de la clase Gato
        public Gato(string nombre)
        {
            Console.WriteLine($"Se creó un gato con nombre: {nombre}.");
            this.peso = 5;
            NombrarGato(nombre);
            //this.nombre = nombre; 
        }
        public void Comer()
        {
            Console.WriteLine("El gato está comiendo.");
            this.peso++;
        }
        public void PesarGato()
        {
            Console.WriteLine($"{nombre} pesa {peso} kilos.");
        }
        public void NombrarGato(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine($"Se nombró correctamente a {nombre}");
        }
        public void Arañar()
        {

        }
        public void Ronronear()
        {

        }
        public void Maullar()
        {
            Console.WriteLine($"El gato {nombre} dice miau.");
        }
    }
}
