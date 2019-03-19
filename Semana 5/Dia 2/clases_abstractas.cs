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

            //FiguraGeometrica miFigura = new FiguraGeometrica("azul");
            Rectangulo miCirculo = new Rectangulo("verde",3.8,5.4);
        }
    }

    //CLASE ABSTRACTA - CLASE INCOMPLETA
    abstract class FiguraGeometrica
    {
        protected string color ;
        public FiguraGeometrica(string color)
        {
            this.color = color;
        }
        // MÉTODOS QUE SE DEBEN IMPLEMENTAR EN CLASES HIJAS
        abstract public double obtenerArea();
        abstract public double obtenerPerimetro();
    }
    class Circulo : FiguraGeometrica
    {
        double _radio;

        public Circulo (double radio, string color) : base(color)
        {
            _radio = radio;
        }
        // MÉTODOS ABSTRACTOS EN CLASE PADRE, DEBEN SER IMPLEMENTADOS
        // OBLIGATORIAMENTE EN LAS CLASES HIJAS
        public override double obtenerArea()
        {
            return Math.PI * Math.Pow(_radio, 2);
        }
        public override double obtenerPerimetro()
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
        // MÉTODOS ABSTRACTOS EN CLASE PADRE, DEBEN SER IMPLEMENTADOS
        // OBLIGATORIAMENTE EN LAS CLASES HIJAS
        public override double obtenerArea()
        {
            return ancho*largo;
        }
        public override double obtenerPerimetro()
        {
            return ancho*2+largo*2;
        }
        // SE CAMBIA EL COMPORTAMIENTO DEL MÉTODO TOSTRING() CON OVERRIDE
        public override string ToString()
        {
            return $"Rectangulo[ancho={ancho}, largo={largo}]";
        }
    }
    
}
