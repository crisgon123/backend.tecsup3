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
            /*
            Autor unAutor = new Autor("Mark", "Douglas", "ndouglas@inve.st");
            // SE DEBEN ENVIAR ARGUMENTOS ACORDE CON EL CONSTRUCTOR
            AutorDePeriodico dePeriodico = new AutorDePeriodico("John", "Smith", "js@gmail.com",
                "The New York Times");
            Console.WriteLine(dePeriodico.ObtenerPeriodico());
            */

            FiguraGeometrica miFigura = new FiguraGeometrica("azul");
            Circulo objCirculo = new Circulo(3.4,"rojo");
            //Console.WriteLine(objCirculo.obtenerArea());
            Rectangulo objRectangulo = new Rectangulo("celeste", 5.8, 3.5);
            //Console.WriteLine(rect.obtenerArea());
            Console.WriteLine(objRectangulo);
            Rectangulo objRectangulo2 = new Rectangulo("violeta", 2332, 3553);
            Console.WriteLine(objRectangulo2);
            Console.WriteLine(objCirculo);

        }
    }

    class FiguraGeometrica
    {
        string color ;
        public FiguraGeometrica(string color)
        {
            this.color = color;
        }
        //GET Y SET GENERADO POR C#
        //public string Color { get => color; set => color = value; }

        // PERMITE MODIFICAR EL COMPORTAMIENTO DEL MÉTODO EN LAS CLASES HIJAS
        // ACOMPAÑADO DE OVERRIDE EN LA CLASE HIJA
        public virtual double obtenerArea()
        {
            Console.WriteLine("Área de la figura");
            return 0;
        }
        public virtual double obtenerPerimetro()
        {
            Console.WriteLine("Perímetro de la figura");
            return 0;
        }
    }
    class Circulo : FiguraGeometrica
    {
        double _radio;

        public Circulo (double radio, string color) : base(color)
        {
            _radio = radio;
        }
        public override double obtenerArea()
        {
            return Math.PI * Math.Pow( _radio,2) ;
        }
        public double obtenerPerimetro()
        { 
            return 0; // IMPLEMENTACIÓN DEL PERÍMETRO DE CÍRCULO
        }
    }
    class Rectangulo : FiguraGeometrica
    {
        double ancho;
        double largo;

        public Rectangulo (string color, double ancho,double largo): base(color)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
        public override double obtenerArea()
        {
            return ancho*largo;
        }
        public double obtenerPerimetro()
        {
            return ancho*2+largo*2;
        }
        // SE CAMBIA EL COMPORTAMIENTO DEL MÉTODO TOSTRING() CON OVERRIDE
        public override string ToString()
        {
            return $"Rectangulo[ancho={ancho}, largo={largo}]";
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
