using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Autor unAutor = new Autor("Mark", "Douglas", "ndouglas@inve.st");
            // SE DEBEN ENVIAR ARGUMENTOS ACORDE CON EL CONSTRUCTOR
            AutorDePeriodico dePeriodico = new AutorDePeriodico("John", "Smith", "js@gmail.com",
                "The New York Times");
            Console.WriteLine(dePeriodico.ObtenerPeriodico());
        }
    }

    class Autor
    {
        // POR DEFECTO TODO ES PRIVADO
        private string _nombre;
        private string _apellido;
        public string _email;
        
        //EL CONSTRUCTOR SIEMPRE DEBE SER PÚBLICO
        public Autor(string nombre, string apellido, string email)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
        }
        public string ObtenerCorreo()
        {
            return _email;
        }
    }
    // EL OPERADOR DOS PUNTOS (:) INDICA HERENCIA
    class AutorDePeriodico : Autor
    {
        string _periodico;

        // EL CONSTRUCTOR PADRE (BASE) RECIBE ARGUMENTOS EN EL CONSTRUCTOR HIJO
        public AutorDePeriodico (string nombre, string apellido, string email,
            string periodico) : base (nombre, apellido, email)
        {
            this._periodico = periodico;
        }
        public string ObtenerPeriodico()
        {
            // SE PUEDE ACCEDER A LOS MÉTODOS Y ATRIBUTOS DE LA CLASE PADRE CON LA
            // PALABRA RESERVADA BASE
            Console.WriteLine(base.ObtenerCorreo());
            Console.WriteLine(base._email);
            Console.WriteLine();
            return _periodico;

        }
    }


}
