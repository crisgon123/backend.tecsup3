using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
   interface IAnimal
   {
      //string Nombre { get; set; }
      string Describir();
   }

   class Perro : IAnimal
   {
      //string IAnimal.Nombre { get ; set ; }
      public string nombre { get; set; }

      public Perro(string nombre)
      {
         this.nombre = nombre;
      }

      public void Ladrar()
      {
         Console.WriteLine("Guau! dijo {0}", nombre);
      }

      string IAnimal.Describir()
      {
         return "El perro se llama "+ nombre;
      }
   }

   class Gato : IAnimal
   {
      public string nombre { get; set; }
      public Gato(string nombre)
      {
         this.nombre = nombre;
      }
      public void Maullar()
      {
         Console.WriteLine("Miau! dijo {0}", nombre);
      }
      string IAnimal.Describir()
      {
         return "El gato se llama " + nombre; ;
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         Perro p1 = new Perro("Fido");
         Perro p2 = new Perro("Firulais");

         Gato g = new Gato("Tichondrius");

         p1.Ladrar();
         p2.Ladrar();
         g.Maullar();
         Entrenar(p1);
         Entrenar(g);
      }
      static void Entrenar (IAnimal animal)
      {
         Console.WriteLine($" {animal.Describir()} está entrenando");
      }
   }
}
