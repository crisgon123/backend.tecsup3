using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeClases2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona per = new Persona("71232493","Christian",27,'S');
            //per.MostrarDatos();
            //per.estadoCivil = 'C';
            /*
            float inicio = Environment.TickCount;
            for (int i = 0; i < 100000000; i++)
            {

            }
            float fin = Environment.TickCount;
            Console.WriteLine((fin - inicio)/1000);
            
            int año;
            año=int.Parse(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
                Console.WriteLine($"El año {año} es bisiesto");

            string diaDeHoy = DateTime.Today.DayOfWeek.ToString();
            DateTime.IsLeapYear(año);
            Console.WriteLine(diaDeHoy);
            
            Triangulo elTri = new Triangulo();
            elTri.calcularHipotenusa();
            elTri.mostrarHipotenusa();
            
            int aleatorio;
            Random ran = new Random();
            for (int i = 243984329; i < 243984339; i++)
            {
                aleatorio = ran.Next(62) + 136;
                Console.WriteLine(aleatorio);
            }
            
            Console.WriteLine("Muestra de mensajes aleatorios: ");
            string[] nombre = { "Jesús", "Manuela", "José", "Jimena", "Mauro", "Irwin", "Luisa" };
            string[] apellido = { "Medina", "Acosta", "Tejada", "Manrique", "Zevallos", "Rojas" };
            string[] verbo = { "jugar", "bailar", "dormir", "estudiar" };
            string[] lugar = { "la universidad", "la combi", "la casa", "fiestas", "ningún lugar" };
            string[] tiempo = { "todos los días de mi vida", "eventualmente", "a toda hora", "de vez en cuando" };
            Random ran = new Random();
            do
            {
                string [] resultado = { $"Hola, soy {nombre[ran.Next(nombre.Length)]} " +
                    $"{apellido[ran.Next(apellido.Length)]} y me gusta " +
                    $"{verbo[ran.Next(verbo.Length)]} en " +
                    $"{lugar[ran.Next(lugar.Length)]} " +
                    $"{tiempo[ran.Next(tiempo.Length)]}" };
                Console.WriteLine(resultado[0]);
                Console.ReadLine();
            } while (true);
            */

            Trabajador t = new Trabajador();
            
        }
    }
    class Trabajador : Persona
    {

    }
    class Persona
    {
        //ATRIBUTOS (CARACTERÍSTICAS)
        string _DNI;
        string _nombre;
        int _edad;
        char _estadoCivil;

        //CONSTRUCTORES
        /*
        public Persona(string dni, string nombre, int edad, char estadoCivil)
        {
            _DNI = dni;
            _nombre = nombre;
            _edad = edad;
            _estadoCivil = estadoCivil;
        }
        */
        //MÉTODOS (ACCIONES QUE REALIZA UN OBJETO)
        public void Comer(string comida)
        {

        }
        public void CambiarEstadoCivil(char estadoCivil)
        {
            _estadoCivil = estadoCivil;
        }
        public char estadoCivil
        {
            get
            {
                return _estadoCivil;
            }
            set
            {
                _estadoCivil = value;
            }
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre:{_nombre }");
            Console.WriteLine($"Dni:{_DNI }");
            Console.WriteLine($"Edad:{_edad }");
            Console.WriteLine($"Estado Civil:{_estadoCivil }");
        }

    }
    class Triangulo
    {
        double _ladoCorto;
        double _ladoLargo;
        double _hipotenusa;

        public Triangulo()
        {
            IngresarLados();
        }

        public void IngresarLados()
        {
            Console.WriteLine("Ingresar lado corto");
            _ladoCorto=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar lado largo");
            _ladoLargo=double.Parse(Console.ReadLine());
        }
        public void calcularHipotenusa()
        { 
            //Math.sqrt //raiz cuadrada
            //Math.pow  
            _hipotenusa = Math.Pow( Math.Pow(_ladoCorto,2)+Math.Pow(_ladoLargo,2),0.5);
        }
        public void mostrarHipotenusa()
        {
            Console.WriteLine($"La hipotenusa es: {_hipotenusa}");
        }
    }
}
